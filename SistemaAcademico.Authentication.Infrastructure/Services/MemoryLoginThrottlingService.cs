using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Infrastructure.Services
{
    public class MemoryLoginThrottlingService : ILoginThrottlingService
    {
        private readonly IMemoryCache _cache;
        private readonly int _maxAttempts;
        private readonly int _lockoutMinutes;
        private readonly ILogger<MemoryLoginThrottlingService> _logger;

        public MemoryLoginThrottlingService(IMemoryCache cache, IConfiguration configuration, ILogger<MemoryLoginThrottlingService> logger)
        {
            _cache = cache;
            _logger = logger;

            // Leemos la configuración. Si no existe, usamos valores por defecto seguros (5 intentos, 7 min)
            var section = configuration.GetSection("LoginThrottling");
            string? maxAttemptsVal = section["MaxFailedAttempts"];
            string? lockoutMinVal = section["LockoutMinutes"];

            _maxAttempts = int.TryParse(maxAttemptsVal, out int m) ? m : 5;
            _lockoutMinutes = int.TryParse(lockoutMinVal, out int l) ? l : 7;
        }

        public Task<bool> EstaBloqueadoAsync(string key)
        {
            // Verificamos si existe la llave de BLOQUEO
            return Task.FromResult(_cache.TryGetValue($"BLOCK_{key}", out _));
        }

        public Task RegistrarIntentoFallidoAsync(string key)
        {
            var attemptsKey = $"ATTEMPTS_{key}";

            // Obtenemos los intentos actuales o iniciamos en 0
            // Configuramos una expiración deslizante: si deja de intentar por el tiempo de bloqueo, se resetea solo.
            int intentos = _cache.GetOrCreate(attemptsKey, entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromMinutes(_lockoutMinutes);
                return 0;
            });

            intentos++;
            _cache.Set(attemptsKey, intentos);

            if (intentos >= _maxAttempts)
            {
                // El bloqueo expira automáticamente después del tiempo configurado
                _cache.Set($"BLOCK_{key}", true, TimeSpan.FromMinutes(_lockoutMinutes));

                _logger.LogWarning(
                    "SEGURIDAD: Intento de fuerza bruta detectado. Usuario {Email} ha sido BLOQUEADO por {Minutes} minutos.", 
                    key, _lockoutMinutes
                );
            }

            return Task.CompletedTask;
        }

        public Task ResetearIntentosAsync(string key)
        {
            // Login exitoso: Borramos todo rastro de intentos y bloqueos
            _cache.Remove($"ATTEMPTS_{key}");
            _cache.Remove($"BLOCK_{key}");
            return Task.CompletedTask;
        }
    }
}
