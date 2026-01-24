using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Entities
{
    public class ProgramaAcademicoE
    {
        public int Id { get; set; }
        public string Periodo { get; set; }
        public string Estatus { get; set; }
        public int TotalCreditos { get; set; }
        public int TrimestresMaximos { get; set; }

        public int CarreraId { get; set; }
        public CarreraE Carrera { get; set; }
        public ICollection<AsignaturaPensumE> AsignaturasDelPrograma { get; set; }
        = new List<AsignaturaPensumE>();
    }
}
