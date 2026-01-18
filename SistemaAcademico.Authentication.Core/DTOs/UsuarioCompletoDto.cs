using System;

namespace SistemaAcademico.Authentication.Core.DTOs;

public class UsuarioCompletoDto
{
    public int IdUsuario { get; set; }
    public string Nombre { get; set; } = null!;
    public string Apellido { get; set; } = null!;
    public string Nacionalidad { get; set; } = null!;
    public string Direccion { get; set; } = null!;
    public string CorreoPersonal { get; set; } = null!;
    public DateTime FechaIngreso { get; set; }
    public int IdRol { get; set; }
    public string Role { get; set; } = null!;
    public string CorreoInstitucional { get; set; } = null!;

    // Información de Estudiante (si aplica)
    public int? IdProgramaAcademico { get; set; }
    public string? NombreProgramaAcademico { get; set; }
    public DateTime? FechaInscripcion { get; set; }
    public string? Estatus { get; set; }
    public int? Permanencia { get; set; }
    public int? TrimestreActual { get; set; }
    public string? IdAreaAcademica { get; set; }
    public string? NombreAreaAcademica { get; set; }

    // Información de Profesor (si aplica)
    public string? GradoAcademico { get; set; }
    public string? Especialidad { get; set; }
    public DateTime? FechaContratacion { get; set; }
    public string? Bio { get; set; }
}
