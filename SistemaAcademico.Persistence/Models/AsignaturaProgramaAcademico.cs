using System;
using System.Collections.Generic;

namespace SistemaAcademico.Persistence.Models;

public partial class AsignaturaProgramaAcademico
{
    public string IdAsignatura { get; set; } = null!;

    public int IdProgramaAcademico { get; set; }

    public List<string> PreRequisitos { get; set; } = new List<string>();

    public string? Corequisito { get; set; }

    public int Creditos { get; set; }

    public int Periodo { get; set; }

    public virtual Asignatura? CorequisitoNavigation { get; set; }

    public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;

    public virtual ProgramaAcademico IdProgramaAcademicoNavigation { get; set; } = null!;
}
