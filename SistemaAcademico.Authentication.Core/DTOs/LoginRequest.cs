using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.DTOs
{
    public class LoginRequest
    {
        [Required, EmailAddress] 
        public string CorreoInstitucional { get; set; } = string.Empty;
        [Required] 
        public string Password { get; set; } = string.Empty;
    }
}
