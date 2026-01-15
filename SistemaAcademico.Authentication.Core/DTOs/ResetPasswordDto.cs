using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.DTOs
{
    public class ResetPasswordDto
    {
        [Required, EmailAddress]
        public string CorreoInstitucional { get; set; } = string.Empty;
        [Required]
        public string CodigoOTP { get; set; } = string.Empty;
        [Required]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "La contraseña debe tener mayúscula, número y min 8 caracteres.")]
        public string NuevaPassword { get; set; } = string.Empty;
        [Compare("NuevaPassword", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmarPassword { get; set; } = string.Empty;

    }
}
