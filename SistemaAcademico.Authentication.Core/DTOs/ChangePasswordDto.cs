using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.DTOs
{
    public class ChangePasswordDto
    {
        [Required, EmailAddress]
        public string CorreoInstitucional { get; set; }
        [Required]
        public string PasswordActual { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", 
            ErrorMessage = "La contraseña debe tener mayúscula, número y min 8 caracteres.")]
        public string NewPassword { get; set; } = string.Empty;

        [Compare("NewPassword", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmarPassword { get; set; } = string.Empty;
    }
}
