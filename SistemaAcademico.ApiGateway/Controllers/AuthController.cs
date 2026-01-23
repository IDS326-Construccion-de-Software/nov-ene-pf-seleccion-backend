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
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto request)
        {
            await _authService.CrearUsuarioAsync(request);
            return Ok(new { message = $"Usuario {request.CorreoInstitucional} creado exitosamente." });
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // El Middleware atrapará PasswordChangeRequired, AccountBlocked y UnauthorizedAccess
            var result = await _authService.LoginAsync(request);
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var result = await _authService.RefreshTokenAsync(request);
            return Ok(result);
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
            await _authService.CambiarPasswordAsync(request);
            return Ok(new { message = "Contraseña actualizada exitosamente." });
        }

        // ESCENARIO 3 (Paso 1): Solicitar Recuperación (Envío de OTP)
        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto request)
        {
            await _authService.SolicitarRecuperacionAsync(request);
            return Ok(new { message = "Si el correo es correcto, se han enviado las instrucciones." });
        }

        // ESCENARIO 3 (Paso 2): Resetear Contraseña (Con OTP)
        [AllowAnonymous]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto request)
        {
            await _authService.ResetearPasswordConOtpAsync(request);
            return Ok(new { message = "Contraseña restablecida correctamente." });
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
