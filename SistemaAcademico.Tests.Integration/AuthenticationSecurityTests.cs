using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SistemaAcademico.Tests.Integration
{
    public class AuthenticationSecurityTests : IClassFixture<SecurityWebApplicationFactory>
    {
        private readonly HttpClient _client;

        public AuthenticationSecurityTests(SecurityWebApplicationFactory factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task OWASP_A07_BruteForce_Protection_Works()
        {
            // Asegúrate que 'Email' y 'Password' existan en tu clase LoginRequest
            var badLogin = new { CorreoInstitucional = "hacker@test.com", Password = "ClaveEquivocada123!" };

            // 5 intentos fallidos
            for (int i = 0; i < 5; i++)
            {
                await _client.PostAsJsonAsync("/api/auth/login", badLogin);
            }

            // El 6to intento DEBE ser Forbidden (403)
            var response = await _client.PostAsJsonAsync("/api/auth/login", badLogin);

            // Si sigue dando 400, imprimiremos el error para saber qué campo falta
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var errorDetail = await response.Content.ReadAsStringAsync();
                throw new Exception($"El API devolvió 400. Detalle: {errorDetail}");
            }

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Forbidden);
        }

        [Fact]
        public async Task OWASP_A01_Endpoint_Register_IsRestrictedToAdmins()
        {
            // Arrange: Un usuario anónimo intenta registrar a alguien
            var newUser = new { Email = "nuevo@academia.com", Password = "Password123!", Role = "Profesor" };

            // Act: Llamada sin Token de Administrador
            var response = await _client.PostAsJsonAsync("/api/auth/create-user", newUser);

            // Assert: Debe ser denegado
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized, "Nadie debe registrar usuarios sin estar logueado como Admin");
        }

        [Fact]
        public async Task OWASP_A05_SecurityHeaders_ArePresent()
        {
            // Act
            var response = await _client.GetAsync("/api/auth/login"); // Probamos un endpoint público

            // Assert: Verificamos que no estemos dando pistas de nuestra tecnología (Seguridad por oscuridad)
            response.Headers.Contains("Server").Should().BeFalse("No debemos exponer el header 'Server' (Kestrel)");
            response.Headers.Contains("X-Powered-By").Should().BeFalse("No debemos exponer 'X-Powered-By'");
        }

        [Fact]
        public async Task Login_Response_ShouldNotContainSensitiveData()
        {
            // Arrange: Usamos las credenciales del usuario que sembramos en la base de datos de memoria
            var loginRequest = new { CorreoInstitucional = "admin@test.com", Password = "Admin123!" };

            // Act
            var response = await _client.PostAsJsonAsync("/api/auth/login", loginRequest);
            var content = await response.Content.ReadAsStringAsync();

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            // Verificamos que campos sensibles NO estén en el JSON de respuesta
            content.Should().NotContain("ClaveHash");
            content.Should().NotContain("PasswordHash");
            content.Should().NotContain("Salt");
        }
    }
}