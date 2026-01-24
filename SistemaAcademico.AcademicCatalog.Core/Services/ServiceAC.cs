using SistemaAcademico.AcademicCatalog.Core.DTOs.Asignatura;
using SistemaAcademico.AcademicCatalog.Core.DTOs.Career;
using SistemaAcademico.AcademicCatalog.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Core.Services
{
    public class AcademicCatalogService : IAcademicCatalogService
    {
        private readonly IAcademicCatalogRepository _repository;

        public AcademicCatalogService(IAcademicCatalogRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<AsignaturaPensumDto>> GetAsignaturasByPensumIdAsync(int pensumId)
        {
            var asignaturasEntidad = await _repository.GetAsignaturasByPensumIdAsync(pensumId);

            return asignaturasEntidad.Select(ap => new AsignaturaPensumDto(
                ap.IdAsignatura,
                ap.Asignatura.Nombre,
                ap.Creditos,
                ap.PreRequisitos ?? "",
                ap.Corequisito?.ToString() ?? "N/A"
            ));
        }
    }
}
