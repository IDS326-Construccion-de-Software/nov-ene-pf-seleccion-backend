using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[ApiController]
[Route("api/auth")]
public class AuthLogoutController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthLogoutController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout([FromBody] LogoutRequestDto dto)
    {
        await _authService.LogoutAsync(dto.RefreshToken);
        return NoContent();
    }
}

