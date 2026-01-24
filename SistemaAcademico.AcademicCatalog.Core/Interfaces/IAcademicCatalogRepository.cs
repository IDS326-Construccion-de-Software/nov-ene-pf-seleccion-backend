using SistemaAcademico.AcademicCatalog.Core.Entities;
using SistemaAcademico.AcademicCatalog.Core.DTOs.Asignatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Interfaces
{
    public interface IAcademicCatalogRepository
    {
        Task<IEnumerable<AsignaturaPensumE>> GetAsignaturasByPensumIdAsync(int pensumId);
    }
}
