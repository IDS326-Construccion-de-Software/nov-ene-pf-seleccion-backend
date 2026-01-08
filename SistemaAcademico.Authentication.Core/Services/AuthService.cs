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

namespace SistemaAcademico.Authentication.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository;
        private readonly ITokenService _tokenService;
        private readonly ILoginThrottlingService _throttlingService;

        public AuthService(
            IAuthRepository repository,
            ITokenService tokenService,
            ILoginThrottlingService throttlingService)
        {
            _repository = repository;
            _tokenService = tokenService;
            _throttlingService = throttlingService;
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

                FechaIngreso = DateOnly.FromDateTime(DateTime.Now),

                ClaveHash = passwordHash,

                IdRol = dto.IdRol
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

            await _throttlingService.ResetearIntentosAsync(request.CorreoInstitucional);

            string nombreRol = rolActivo.IdRolNavigation?.Descripcion ?? "RolDesconocido";
            var accessToken = _tokenService.GenerarAccessToken(usuario, nombreRol);
            var refreshToken = _tokenService.GenerarRefreshToken();

            var tokenEntity = new UsuarioRefreshToken
            {
                Token = refreshToken,
                IdUsuario = usuario.IdUsuario,
                FechaCreacion = DateOnly.FromDateTime(DateTime.Now),
                FechaExpiracion = DateOnly.FromDateTime(DateTime.Now.AddDays(7))
            };
            await _repository.GuardarRefreshTokenAsync(tokenEntity);

            return new LoginResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                NombreUsuario = $"{usuario.Nombre} {usuario.Apellido}",
                Rol = nombreRol,
                //DebeCambiarPassword = usuario.DebeCambiarContrasenia
            };
        }
    }
}
