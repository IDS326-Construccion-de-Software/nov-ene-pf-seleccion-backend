using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Exceptions
{
    public class AccountBlockedException : Exception
    {
        public AccountBlockedException(string message) : base(message)
        {
        }
    }
}
