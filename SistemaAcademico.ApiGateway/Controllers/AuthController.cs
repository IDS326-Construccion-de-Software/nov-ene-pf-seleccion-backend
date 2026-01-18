using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Exceptions;
using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        [HttpPost("create-user")]
        // TODO: Descomentar despues de crear el primer user admin
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto request)
        {
            try
            {
                await _authService.CrearUsuarioAsync(request);
                return Ok(new { message = $"Usuario {request.CorreoInstitucional} creado exitosamente." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var result = await _authService.LoginAsync(request);
                return Ok(result);
            }
            catch (PasswordChangeRequiredException)
            {
                return StatusCode(403, new { 
                    error = "Cambio de contraseña requerido." ,
                    message = "Por seguridad, debe cambiar su contraseña antes de continuar."
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { error = "Error interno del servidor." });
            }
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var result = await _authService.RefreshTokenAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
        }

        [AllowAnonymous]
        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] RefreshTokenRequest request)
        {
            await _authService.LogoutAsync(request.RefreshToken);

            return NoContent();
        }

        // ESCENARIO 1 y 2: Cambiar Contraseña (Conociendo la actual)
        // Es AllowAnonymous porque en el Escenario 1 el usuario NO tiene token aún.
        [AllowAnonymous]
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                await _authService.CambiarPasswordAsync(request);
                return Ok(new { message = "Contraseña actualizada exitosamente. Por favor inicie sesión." });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { error = ex.Message }); 
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // ESCENARIO 3 (Paso 1): Solicitar Recuperación (Envío de OTP)
        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto request)
        {
            try
            {
                await _authService.SolicitarRecuperacionAsync(request);
                return Ok(new { message = "Si el correo es correcto, se han enviado las instrucciones." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // ESCENARIO 3 (Paso 2): Resetear Contraseña (Con OTP)
        [AllowAnonymous]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                await _authService.ResetearPasswordConOtpAsync(request);
                return Ok(new { message = "Contraseña restablecida correctamente. Ya puede iniciar sesión." });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        // Obtener información completa del usuario logueado
        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetUsuarioCompleto()
        {
            try
            {
                // Obtener el ID del usuario del token JWT
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

                if (userIdClaim == null)
                    return Unauthorized(new { error = "No se pudo identificar al usuario." });

                if (!int.TryParse(userIdClaim.Value, out int userId))
                    return BadRequest(new { error = "ID de usuario inválido." });

                var usuario = await _authService.ObtenerUsuarioCompletoAsync(userId);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
