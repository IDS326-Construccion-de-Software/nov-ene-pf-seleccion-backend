using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Entities
{
    public class AreaAcademicaE
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        // Relación: Un área tiene muchas carreras
        public ICollection<CarreraE> Carreras { get; set; } = new List<CarreraE>();
    }
}

