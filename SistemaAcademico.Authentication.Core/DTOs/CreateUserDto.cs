using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.DTOs
{
    public class CreateUserDto
    {
        [Required, StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        public string Nacionalidad { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(255)]
        public string CorreoPersonal { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(255)]
        public string CorreoInstitucional { get; set; } = string.Empty;
            
        [Required, StringLength(50, MinimumLength =8)]
        // [AUTH-10] Reglas de fortaleza: Mínimo 8 chars, 1 mayúscula, 1 número.
        // Regex explicación:
        // (?=.*[A-Z]) = Al menos una mayúscula
        // (?=.*\d)    = Al menos un número
        // .{8,}       = Mínimo 8 caracteres
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{8,}$",
            ErrorMessage = "La contraseña debe tener mayúscula, número y min 8 caracteres.")]
        public string Password { get; set; } = string.Empty;
        [Required]
        public int IdRol { get; set; }
    }
}
