using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Persistence.Models
{
    public partial class Soporte
    {
        public int IdSoporte { get; set; }

        public string IdAsignatura { get; set; } = null!;

        public string IdUsuario { get; set; } = null!;

        public int MotivoSolicitud { get; set; }

        
        public virtual Asignatura IdAsignaturaNavigation { get; set; } = null!;

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
