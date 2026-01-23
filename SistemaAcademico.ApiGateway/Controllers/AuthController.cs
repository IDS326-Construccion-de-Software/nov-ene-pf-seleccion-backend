using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _config;

    public AuthController(IConfiguration config)
    {
        _config = config;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public IActionResult Login()
    {
        // ===============================
        // READ JWT SETTINGS CORRECTLY
        // ===============================
        var jwtSettings = _config.GetSection("JwtSettings");

        var secretKey = jwtSettings["SecretKey"];
        var issuer = jwtSettings["Issuer"];
        var audience = jwtSettings["Audience"];
        var duration = jwtSettings["DurationInMinutes"];

        if (string.IsNullOrEmpty(secretKey))
        {
            return StatusCode(500, "JwtSettings:SecretKey no está configurado");
        }

        // ===============================
        // CLAIMS
        // ===============================
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, "Juan"),
            new Claim(ClaimTypes.Role, "estudiante") // 🔑 necesario para isRole
        };

        // ===============================
        // TOKEN CREATION
        // ===============================
        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(secretKey)
        );

        var creds = new SigningCredentials(
            key,
            SecurityAlgorithms.HmacSha256
        );

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(
                int.Parse(duration!)
            ),
            signingCredentials: creds
        );

        return Ok(new
        {
            token = new JwtSecurityTokenHandler().WriteToken(token)
        });
    }
}
