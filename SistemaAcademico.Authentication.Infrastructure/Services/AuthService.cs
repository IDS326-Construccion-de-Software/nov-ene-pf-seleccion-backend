using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SistemaAcademico.Authentication.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly SistemaAcademicoContext _dbContext;
        private readonly IConfiguration _configuration;

        public AuthService(SistemaAcademicoContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public async Task<int> CrearUsuarioAsync(CreateUserDto dto)
        {
            var nuevo = new Usuario
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                CorreoInstitucional = dto.CorreoInstitucional,
                ClaveHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                IdRol = dto.IdRol,
                FechaIngreso = DateOnly.FromDateTime(DateTime.UtcNow)
            };

            _dbContext.Usuarios.Add(nuevo);
            await _dbContext.SaveChangesAsync();
            return nuevo.IdUsuario;
        }

        public async Task<AuthResponseDto?> LoginAsync(LoginDto dto)
        {
            var usuario = await _dbContext.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.CorreoInstitucional == dto.Email);

            if (usuario == null)
                return null;

            if (!BCrypt.Net.BCrypt.Verify(dto.Password, usuario.ClaveHash))
                return null;

            var jwtSection = _configuration.GetSection("JwtSettings");

            var secret = jwtSection["SecretKey"]
                ?? throw new InvalidOperationException("JwtSettings:SecretKey no configurado");

            var issuer = jwtSection["Issuer"];
            var audience = jwtSection["Audience"];

            var accessMinutes = int.Parse(jwtSection["AccessTokenDurationMinutes"] ?? "60");
            var refreshDays = int.Parse(jwtSection["RefreshTokenDurationDays"] ?? "7");

            var key = Encoding.UTF8.GetBytes(secret);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString()),
                new Claim(ClaimTypes.Email, usuario.CorreoInstitucional),
                new Claim(ClaimTypes.Name, $"{usuario.Nombre} {usuario.Apellido}")
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(accessMinutes),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature
                )
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(securityToken);

            // REFRESH TOKEN
            var refreshTokenValue = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));

            var refreshEntity = new UsuarioRefreshToken
            {
                Token = refreshTokenValue,
                IdUsuario = usuario.IdUsuario,
                FechaCreacion = DateOnly.FromDateTime(DateTime.UtcNow),
                FechaExpiracion = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(refreshDays))
            };

            _dbContext.UsuarioRefreshTokens.Add(refreshEntity);
            await _dbContext.SaveChangesAsync();

            return new AuthResponseDto
            {
                AccessToken = accessToken,
                AccessTokenExpiresAt = tokenDescriptor.Expires!.Value,
                RefreshToken = refreshTokenValue,
                RefreshTokenExpiresAt =
                    refreshEntity.FechaExpiracion.ToDateTime(TimeOnly.MinValue),
                Email = usuario.CorreoInstitucional,
                UserId = usuario.IdUsuario
            };
        }

        /// <summary>
        /// Cierra sesión del usuario invalidando el refresh token.
        /// Implementación mínima para cumplir el contrato.
        /// </summary>
        public Task LogoutAsync(string refreshToken)
        {
            // Fase 1: no se invalida aún en BD (no rompe al equipo)
            return Task.CompletedTask;
        }
    }
}
