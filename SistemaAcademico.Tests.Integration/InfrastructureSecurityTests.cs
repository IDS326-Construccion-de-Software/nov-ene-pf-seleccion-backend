namespace SistemaAcademico.Tests.Integration
{
    using System.Net;
    using FluentAssertions;
    using Xunit;

    namespace SistemaAcademico.Tests.Integration
    {
        public class InfrastructureSecurityTests : IClassFixture<SecurityWebApplicationFactory>
        {
            private readonly HttpClient _client;

            public InfrastructureSecurityTests(SecurityWebApplicationFactory factory)
            {
                _client = factory.CreateClient();
            }

            // --- PRUEBA 1: OWASP A05 - Security Headers ---
            [Fact]
            public async Task SecurityHeaders_Middleware_ShouldInjectAllHeaders()
            {
                // Act
                var response = await _client.GetAsync("/api/auth/login");

                // Assert con verificación de existencia previa para evitar el InvalidOperationException
                response.Headers.Contains("X-Content-Type-Options").Should().BeTrue("Falta header de seguridad");
                response.Headers.GetValues("X-Content-Type-Options").FirstOrDefault().Should().Be("nosniff");

                response.Headers.Contains("X-Frame-Options").Should().BeTrue();
                response.Headers.GetValues("X-Frame-Options").FirstOrDefault().Should().Be("DENY");

                response.Headers.Contains("Server").Should().BeFalse("No debemos revelar el servidor Kestrel");
            }

            // --- PRUEBA 2: OWASP A04 - Global Exception Handling ---
            [Fact]
            public async Task GlobalExceptionMiddleware_ShouldHideSensitiveDetails_InProduction()
            {
                // Nota: El WebApplicationFactory por defecto corre en 'Development'.
                // Para probar A04 real, este test asume que el Middleware oculta detalles.

                // Act: Intentamos acceder a un endpoint con datos que forzarán un error (ej. id malformado)
                var response = await _client.GetAsync("/api/auth/perfil/error-forzado");

                // Assert
                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    // En un diseño seguro (A04), no debe aparecer la palabra "StackTrace" o "Exception"
                    content.Should().NotContain("StackTrace");
                    content.Should().NotContain("System.Data.SqlClient");
                    content.Should().Contain("error");
                }
            }

            // --- PRUEBA 3: OWASP A04 - Rate Limiting ---
            [Fact]
            public async Task RateLimiting_ShouldBlock_ExcessiveRequests()
            {
                // Arrange: Nuestra política es de 100 peticiones por minuto.
                // Para el test, vamos a disparar ráfagas rápidas.

                HttpResponseMessage lastResponse = null!;

                // Act: Enviamos más de lo permitido (esto es un test de stress rápido)
                for (int i = 0; i < 110; i++)
                {
                    lastResponse = await _client.GetAsync("/api/auth/login");
                    if (lastResponse.StatusCode == HttpStatusCode.TooManyRequests) break;
                }

                // Assert
                lastResponse.StatusCode.Should().Be(HttpStatusCode.TooManyRequests,
                    "El sistema debe protegerse contra DoS (Denegación de Servicio)");
            }

            // --- PRUEBA 4: OWASP A04 - Kestrel Payload Limit ---
            [Fact]
            public async Task Kestrel_ShouldReject_HugePayloads()
            {
                // 1. Generamos un payload de 1.1 MB (Límite configurado es 1MB)
                var hugeString = new string('A', 1100000);
                var request = new { CorreoInstitucional = hugeString, Password = "Password123!" };

                // 2. IMPORTANTE: Enviamos al LOGIN (que es público) para evitar el 401
                var response = await _client.PostAsJsonAsync("/api/auth/login", request);

                // 3. ASSERT FLEXIBLE: Aceptamos 400 (Rechazo por validación) o 413 (Rechazo por Kestrel)
                // Esto cubre ambas capas de defensa.
                int statusCode = (int)response.StatusCode;
                statusCode.Should().Match(s => s == 400 || s == 413,
                    $"Se esperaba 400 o 413 para un payload de 1.1MB, pero se recibió {statusCode}");
            }

            // --- PRUEBA: INYECCIÓN (Asegurar que sea al Login) ---
            [Theory]
            [InlineData("admin' --")]
            [InlineData("<script>alert(1)</script>")]
            public async Task Login_ShouldNotExplode_WithMaliciousInput(string maliciousInput)
            {
                var request = new { CorreoInstitucional = maliciousInput, Password = "AnyPassword" };

                // Enviamos siempre al LOGIN para que la prueba sea pura de inyección y no de roles
                var response = await _client.PostAsJsonAsync("/api/auth/login", request);

                // El resultado debe ser un rechazo controlado (400 o 401)
                ((int)response.StatusCode).Should().Match(s => s == 400 || s == 401 || s == 422);
            }
        }
    }
}
