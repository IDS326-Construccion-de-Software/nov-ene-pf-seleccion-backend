using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SistemaAcademico.Tests.Integration
{
    public class InjectionSecurityTests : IClassFixture<SecurityWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public InjectionSecurityTests(SecurityWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Theory]
        [InlineData("admin' --")]               // SQL Injection clásico
        [InlineData("admin' OR '1'='1")]        // Bypass de login
        [InlineData("<script>alert(1)</script>")] // XSS (Inyección de Script)
        [InlineData("admin@test.com; DROP TABLE Usuarios")] // Intento de borrado
        public async Task Login_ShouldNotExplode_WithMaliciousInput(string maliciousInput)
        {
            // Arrange
            var request = new { Email = maliciousInput, Password = "AnyPassword" };

            // Act
            var response = await _client.PostAsJsonAsync("/api/auth/login", request);

            // Assert
            // Un sistema seguro no debe dar Error 500 (Internal Server Error)
            // Debe dar 400 (BadRequest) o 401 (Unauthorized)
            response.StatusCode.Should().NotBe(HttpStatusCode.InternalServerError,
                $"El input {maliciousInput} causó un error interno en el servidor. ¡Posible vulnerabilidad!");

            response.StatusCode.Should().Match(s =>
                (int)s == 400 || (int)s == 401 || (int)s == 422,
                "El sistema debe rechazar o denegar inputs maliciosos de forma controlada.");
        }
    }
}
