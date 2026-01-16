using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface IEmailService
    {
        Task EnviarCorreoAsync(string destinatario, string asunto, string cuerpo);
    }
}
