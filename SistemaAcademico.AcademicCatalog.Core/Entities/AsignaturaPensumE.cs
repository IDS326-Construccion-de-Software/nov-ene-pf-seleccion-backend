using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Entities
{
    public class AsignaturaPensumE
    {
        public string IdAsignatura { get; set; }
        public int IdProgramaAcademico { get; set; }
        public string PreRequisitos { get; set; }
        public string Corequisito { get; set; }
        public int Creditos { get; set; }

        // Propiedades de Navegación
        public AsignaturaE Asignatura { get; set; }
        public ProgramaAcademicoE ProgramaAcademico { get; set; }
    }
}
