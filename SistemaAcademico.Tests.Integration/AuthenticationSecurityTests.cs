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
            var newUser = new { CorreoInstitucional = "nuevo@academia.com", Password = "Password123!", Role = "Profesor" };

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

        [Fact]
        public async Task Login_WithHugePayload_ShouldReturnBadRequestOrTooLarge()
        {
            // ARRANGE: 1.1 MB para asegurar que supere el límite de 1MB
            string hugeEmail = new string('A', 1100000);

            // Usamos el endpoint de Login porque es público
            var request = new
            {
                Email = hugeEmail,
                Password = "Password123!"
            };

            // ACT: Enviamos al LOGIN
            var response = await _client.PostAsJsonAsync("/api/auth/login", request);

            // ASSERT
            int statusCode = (int)response.StatusCode;

            // Ahora sí, el sistema lo rechazará por tamaño (413) o por validación (400)
            // Pero NO por 401 porque el login es público.
            statusCode.Should().Match(s => s == 400 || s == 413,
                $"Se esperaba un rechazo por tamaño, pero se recibió {statusCode}");
        }

        [Theory]
        [InlineData("admin@test.com", "ClaveMal123!")]
        [InlineData("noexiste@test.com", "CualquierClave")]
        public async Task ChangePassword_ShouldReturnSameError_RegardlessOfReason(string email, string pass)
        {
            var request = new
            {
                CorreoInstitucional = email,
                PasswordActual = pass,
                NuevaPassword = "NewSecurePass123!",
                ConfirmarPassword = "NewSecurePass123!"
            };

            var response = await _client.PostAsJsonAsync("/api/auth/change-password", request);

            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var body = await response.Content.ReadAsStringAsync();
                throw new Exception($"El servidor devolvió 400. Detalles: {body}");
            }

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}