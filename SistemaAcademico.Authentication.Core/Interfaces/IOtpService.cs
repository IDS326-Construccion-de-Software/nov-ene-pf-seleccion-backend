using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface IOtpService
    {
        string GenerarCodigoOTP(string key);
        bool ValidarCodigoOTP(string key, string codigo);
    }
}
