using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Services
{
    public class MockEmailService : IEmailService
    {
        public Task EnviarCorreoAsync(string destinatario, string asunto, string cuerpo)
        {
            // Solo para revisar si funciona antes de usar smtp real
            System.Diagnostics.Debug.WriteLine($"[EMAIL] To: {destinatario} | OTP: {cuerpo}");
            return Task.CompletedTask;
        }

    }
}
