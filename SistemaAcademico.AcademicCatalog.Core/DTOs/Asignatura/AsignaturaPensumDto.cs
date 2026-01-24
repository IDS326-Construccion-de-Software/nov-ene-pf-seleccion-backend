using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.DTOs.Asignatura
{
    public record AsignaturaPensumDto
    (
        string IdAsignatura,
        string NombreAsignatura,
        int Creditos,
        string PreRequisitos,
        string Corequisito
    );
}
