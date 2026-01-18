using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.Persistence;
using Microsoft.IdentityModel.Tokens;
using SistemaAcademico.Authentication.Core.Exceptions;

namespace SistemaAcademico.Authentication.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly ITokenService _tokenService;
        private readonly ILoginThrottlingService _throttlingService;
        private readonly IOtpService _otpService;
        private readonly IEmailService _emailService;

        public AuthService(
            IAuthRepository repository,
            ITokenService tokenService,
            ILoginThrottlingService throttlingService,
            IOtpService otpService,
            IEmailService emailService)
        {
            _repository = repository;
            _tokenService = tokenService;
            _throttlingService = throttlingService;
            _otpService = otpService;
            _emailService = emailService;
        }



        public async Task<int> CrearUsuarioAsync(CreateUserDto dto)
        {
            bool existe = await _repository.ExisteCorreoAsync(dto.CorreoInstitucional);

            if (existe)
                throw new Exception($"El usuario {dto.CorreoInstitucional} ya existe.");

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var nuevoUsuario = new Usuario
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Nacionalidad = dto.Nacionalidad,
                Direccion = dto.Direccion,
                Telefono = dto.Telefono,
                CorreoPersonal = dto.CorreoPersonal,
                CorreoInstitucional = dto.CorreoInstitucional,
                FechaIngreso = DateTime.UtcNow,
                ClaveHash = passwordHash,
                IdRol = dto.IdRol,
                CambioClaveSolicitado = true
            };

            nuevoUsuario.UsuarioRols = new List<UsuarioRol>
            {
                new UsuarioRol
                {
                    IdRol = dto.IdRol,
                    Estatus = "Activo"
                }
            };

            return await _repository.CrearUsuarioAsync(nuevoUsuario);
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            if (await _throttlingService.EstaBloqueadoAsync(request.CorreoInstitucional))
                throw new UnauthorizedAccessException("Cuenta bloqueada temporalmente. Intente más tarde.");

            var usuario = await _repository.ObtenerUsuarioLoginAsync(request.CorreoInstitucional);

            if (usuario == null || !BCrypt.Net.BCrypt.Verify(request.Password, usuario.ClaveHash))
            {
                await _throttlingService.RegistrarIntentoFallidoAsync(request.CorreoInstitucional);
                throw new UnauthorizedAccessException("Credenciales inválidas.");
            }

            var rolActivo = usuario.UsuarioRols.FirstOrDefault(ur => ur.Estatus == "Activo");

            if (rolActivo == null)
            {
                throw new UnauthorizedAccessException("El usuario no tiene roles activos para acceder.");
            }

            if (usuario.CambioClaveSolicitado == true)
            {
                throw new PasswordChangeRequiredException();
            }

            await _throttlingService.ResetearIntentosAsync(request.CorreoInstitucional);

            string nombreRol = rolActivo.IdRolNavigation?.Descripcion ?? "RolDesconocido";
            var accessToken = _tokenService.GenerarAccessToken(usuario, nombreRol);
            var refreshToken = _tokenService.GenerarRefreshToken();

            var tokenEntity = new UsuarioRefreshToken
            {
                Token = refreshToken,
                IdUsuario = usuario.IdUsuario,
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.Now.AddDays(7)
            };
            await _repository.GuardarRefreshTokenAsync(tokenEntity);

            return new LoginResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                NombreUsuario = $"{usuario.Nombre} {usuario.Apellido}",
                Rol = nombreRol,
                CambioClaveSolicitado = usuario.CambioClaveSolicitado ?? false
            };
        }

        public async Task<LoginResponse> RefreshTokenAsync(RefreshTokenRequest request)
        {
            //buscar el refresh token
            var tokenGuardado = await _repository.ObtenerRefreshTokenAsync(request.RefreshToken);

            if (tokenGuardado == null)
            {
                throw new SecurityTokenException("Refresh Token invalido");
            }

            if (tokenGuardado.FechaExpiracion < DateTime.UtcNow)
            {
                await _repository.EliminarRefreshTokenAsync(tokenGuardado);
                throw new SecurityTokenException("Refresh Token expirado");
            }

            var usuario = await _repository.ObtenerUsuarioPorIdAsync(tokenGuardado.IdUsuario);

            if (usuario == null)
            {
                await _repository.EliminarRefreshTokenAsync(tokenGuardado);
                throw new SecurityTokenException("Usuario no encontrado");
            }

            // borrar el viejo
            await _repository.EliminarRefreshTokenAsync(tokenGuardado);

            //generar nuevos
            var rolActivo = usuario.UsuarioRols.FirstOrDefault(ur => ur.Estatus == "Activo");
            string nombreRol = rolActivo?.IdRolNavigation?.Descripcion ?? "RolDesconocido";

            var newAccessToken = _tokenService.GenerarAccessToken(usuario, nombreRol);
            var newRefreshToken = _tokenService.GenerarRefreshToken();

            //guardar el nuevo
            var newTokenEntity = new UsuarioRefreshToken
            {
                Token = newRefreshToken,
                IdUsuario = usuario.IdUsuario,
                FechaCreacion = DateTime.UtcNow,
                FechaExpiracion = DateTime.Now.AddDays(7)
            };

            await _repository.GuardarRefreshTokenAsync(newTokenEntity);

            return new LoginResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken,
                NombreUsuario = $"{usuario.Nombre} {usuario.Apellido}",
                Rol = nombreRol,
                CambioClaveSolicitado = usuario.CambioClaveSolicitado ?? false
            };
        }

        public async Task LogoutAsync(string refreshToken)
        {
            var tokenEntity = await _repository.ObtenerRefreshTokenAsync(refreshToken);
            if (tokenEntity != null)
            {
                await _repository.EliminarRefreshTokenAsync(tokenEntity);
            }
        }

        public async Task CambiarPasswordAsync(ChangePasswordDto dto)
        {
            var usuario = await _repository.ObtenerUsuarioLoginAsync(dto.CorreoInstitucional);
            if (usuario == null) throw new UnauthorizedAccessException("Usuario no encontrado.");

            if (!BCrypt.Net.BCrypt.Verify(dto.PasswordActual, usuario.ClaveHash))
                throw new UnauthorizedAccessException("La contraseña actual es incorrecta.");

            if (BCrypt.Net.BCrypt.Verify(dto.NuevaPassword, usuario.ClaveHash))
                throw new ArgumentException("La nueva contraseña no puede ser igual a la anterior.");

            usuario.ClaveHash = BCrypt.Net.BCrypt.HashPassword(dto.NuevaPassword);

            usuario.CambioClaveSolicitado = false;

            await _repository.ActualizarUsuarioAsync(usuario);
            await _repository.RevocarTodosLosTokensUsuarioAsync(usuario.IdUsuario);
            string htmlAlerta = GenerarHtmlAlertaCambio(usuario.Nombre);
            await _emailService.EnviarCorreoAsync(usuario.CorreoPersonal, "⚠️ Seguridad: Contraseña Modificada", htmlAlerta);
        }

        public async Task SolicitarRecuperacionAsync(ForgotPasswordDto dto)
        {
            var usuario = await _repository.ObtenerUsuarioLoginAsync(dto.CorreoInstitucional);
            if (usuario == null) return;

            string otp = _otpService.GenerarCodigoOTP(usuario.CorreoInstitucional);
            string cuerpoHtml = GenerarPlantillaHtml(usuario.Nombre, otp);


            await _emailService.EnviarCorreoAsync(usuario.CorreoPersonal, "Recuperación", cuerpoHtml);
        }

        public async Task ResetearPasswordConOtpAsync(ResetPasswordDto dto)
        {
            if (!_otpService.ValidarCodigoOTP(dto.CorreoInstitucional, dto.CodigoOTP))
                throw new UnauthorizedAccessException("Código OTP inválido.");

            var usuario = await _repository.ObtenerUsuarioLoginAsync(dto.CorreoInstitucional);
            if (usuario == null) throw new Exception("Usuario no encontrado.");

            usuario.ClaveHash = BCrypt.Net.BCrypt.HashPassword(dto.NuevaPassword);

            usuario.CambioClaveSolicitado = false;

            await _repository.ActualizarUsuarioAsync(usuario);
            await _repository.RevocarTodosLosTokensUsuarioAsync(usuario.IdUsuario);
            string htmlAlerta = GenerarHtmlAlertaCambio(usuario.Nombre);
            await _emailService.EnviarCorreoAsync(usuario.CorreoPersonal, "⚠️ Seguridad: Contraseña Modificada", htmlAlerta);
        }

        //TODO: Mejorar el diseño del email (cambiar el color del cuadro)
        private string GenerarPlantillaHtml(string nombre, string otp)
        {
            return $@"
                <div style='font-family: Arial, sans-serif; max-width: 500px; margin: auto; border: 1px solid #ddd; border-radius: 10px; overflow: hidden;'>
                    <div style='background-color: #0d6efd; color: white; padding: 20px; text-align: center;'>
                        <h2 style='margin: 0;'>Universidad - Sistema Académico</h2>
                    </div>
                    <div style='padding: 20px; color: #333;'>
                        <p>Hola <strong>{nombre}</strong>,</p>
                        <p>Hemos recibido una solicitud para restablecer tu contraseña. Usa el siguiente código:</p>
                        <div style='background-color: #f8f9fa; border: 2px dashed #0d6efd; padding: 15px; text-align: center; font-size: 24px; font-weight: bold; letter-spacing: 5px; color: #0d6efd; margin: 20px 0;'>
                            {otp}
                        </div>
                        <p style='font-size: 12px; color: #666;'>Este código expira en 5 minutos. Si no fuiste tú, ignora este mensaje.</p>
                    </div>
                    <div style='background-color: #eee; padding: 10px; text-align: center; font-size: 11px; color: #777;'>
                        &copy; {DateTime.Now.Year} Sistema Académico. No responder a este correo.
                    </div>
                </div>";
        }

        private string GenerarHtmlAlertaCambio(string nombre)
        {
            return $@"
            <div style='font-family: Arial, color: #333; padding: 20px; border: 1px solid #ccc; border-radius: 5px;'>
                <h2 style='color: #d9534f;'>⚠️ Alerta de Seguridad</h2>
                <p>Hola <strong>{nombre}</strong>,</p>
                <p>Te informamos que la contraseña de tu cuenta institucional ha sido modificada exitosamente hace un momento.</p>
                <p>Si fuiste tú, ignora este mensaje.</p>
                <p style='font-weight: bold;'>Si NO fuiste tú, por favor contacta a soporte inmediatamente.</p>
            </div>";
        }

        public async Task<UsuarioCompletoDto> ObtenerUsuarioCompletoAsync(int idUsuario)
        {
            var usuario = await _repository.ObtenerUsuarioPorIdAsync(idUsuario);

            if (usuario == null)
                throw new Exception("Usuario no encontrado.");

            var dto = new UsuarioCompletoDto
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Nacionalidad = usuario.Nacionalidad,
                Direccion = usuario.Direccion,
                CorreoPersonal = usuario.CorreoPersonal,
                FechaIngreso = usuario.FechaIngreso,
                IdRol = usuario.IdRol,
                Role = usuario.IdRolNavigation?.Descripcion ?? "",
                CorreoInstitucional = usuario.CorreoInstitucional
            };

            // Si es estudiante (IdRol == 2)
            if (usuario.IdRol == 2)
            {
                var programaAcademico = usuario.UsuarioProgramaAcademicos.FirstOrDefault();
                if (programaAcademico != null)
                {
                    dto.IdProgramaAcademico = programaAcademico.IdProgramaAcademico;
                    dto.NombreProgramaAcademico = programaAcademico.IdProgramaAcademicoNavigation?.IdCarreraNavigation?.Nombre ?? "";
                    dto.FechaInscripcion = programaAcademico.FechaInscripcion;
                    dto.Estatus = programaAcademico.Estatus;
                    dto.Permanencia = programaAcademico.Permanencia;
                    dto.TrimestreActual = programaAcademico.TrimestreActual;

                    // Área académica del programa (a través de Carrera)
                    var areaAcademica = programaAcademico.IdProgramaAcademicoNavigation?.IdCarreraNavigation?.IdAreaAcademicaNavigation;
                    if (areaAcademica != null)
                    {
                        dto.IdAreaAcademica = areaAcademica.AreaAcademicaId;
                        dto.NombreAreaAcademica = areaAcademica.AreaAcademicaNombre;
                    }
                }
            }

            // Si es profesor (IdRol == 1)
            if (usuario.IdRol == 1 && usuario.Profesor != null)
            {
                dto.GradoAcademico = usuario.Profesor.GradoAcademico;
                dto.Especialidad = usuario.Profesor.Especialidad;
                dto.FechaContratacion = usuario.Profesor.FechaContratacion;
                dto.Bio = usuario.Profesor.Bio;

                // Área académica del profesor
                var areaProfesor = usuario.UsuarioAreaAcademicas.FirstOrDefault();
                if (areaProfesor != null)
                {
                    dto.IdAreaAcademica = areaProfesor.IdAreaAcademica;
                    dto.NombreAreaAcademica = areaProfesor.IdAreaAcademicaNavigation?.AreaAcademicaNombre ?? "";
                }
            }

            return dto;
        }
    }
}
