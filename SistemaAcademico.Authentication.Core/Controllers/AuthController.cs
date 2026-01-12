using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // [AUTH-02] Endpoint de Creación de Usuarios
        
        [HttpPost("create-user")]
        // TODO: Descomentar la línea siguiente despues de crear el primer user admin
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto request)
        {
            try
            {
                await _authService.CrearUsuarioAsync(request);
                return Ok(new
                {
                    message = $"Usuario {request.CorreoInstitucional} creado exitosamente."
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // [AUTH-05] Endpoint Refresh Token
        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequestDto dto)
        {
            var result = await _authService.RefreshTokenAsync(dto);

            if (result == null)
            {
                return StatusCode(401, new
                {
                    message = "Refresh token inválido o expirado."
                });
            }

            return Ok(result);
        }
    }
}
