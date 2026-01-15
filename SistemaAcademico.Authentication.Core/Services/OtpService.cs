using Microsoft.Extensions.Caching.Memory;
using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Services
{
    public class OtpService : IOtpService
    {
        private readonly IMemoryCache _cache;
        public OtpService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public string GenerarCodigoOTP(string key)
        {
            var codigo = new Random().Next(10000, 99999).ToString();
            _cache.Set($"OTP_{key}", codigo, TimeSpan.FromMinutes(5)); // El código expira en 5 minutos, metodo temporal por cache
            return codigo;
        }

        public bool ValidarCodigoOTP(string key, string codigo)
        {
            if (_cache.TryGetValue($"OTP_{key}", out string? guardado) && guardado == codigo)
            {
                _cache.Remove($"OTP_{key}");
                return true;
            }
            return false;
        }
    }
}
