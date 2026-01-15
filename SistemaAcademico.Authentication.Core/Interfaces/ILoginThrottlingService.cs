using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface ILoginThrottlingService
    {
        Task RegistrarIntentoFallidoAsync(string key);
        Task<bool> EstaBloqueadoAsync(string key);
        Task ResetearIntentosAsync(string key);
    }
}
