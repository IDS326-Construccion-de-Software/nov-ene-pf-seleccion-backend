using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Entities
{
    public class CarreraE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nomenclatura { get; set; }

        // Foreign Key
        public string IdAreaAcademica { get; set; }
        public AreaAcademicaE AreaAcademicaEnt { get; set; }
        public ICollection<ProgramaAcademicoE> ProgramasAcademicosEnt { get; set; } = new List<ProgramaAcademicoE>();
    }
}
