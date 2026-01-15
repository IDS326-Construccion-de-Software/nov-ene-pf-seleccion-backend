using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Exceptions
{
    public class PasswordChangeRequiredException : Exception
    {
        public PasswordChangeRequiredException() : base("Debe cambiar su contraseña obligatoriamente.") { }
    }
}
