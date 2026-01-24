using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Entities
{
    public class AsignaturaE
    {
        public string Id { get; set; }
        public string Nombre { get; set; }

        // Relación inversa 
        public ICollection<AsignaturaPensumE> AsignaturasPrograma { get; set; }
    }
}
