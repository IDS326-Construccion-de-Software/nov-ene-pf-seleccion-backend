using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.AcademicProgress.Core.Interfaces;
using SistemaAcademico.AcademicProgress.Core.DTOs;
using System;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [ApiController]
    [Route("api/students/{studentId}/academic-progress")]
    [Authorize] // 🔐 Requiere JWT válido
    public class AcademicProgressController : ControllerBase
    {
        private readonly IAcademicProgressService _academicProgressService;
        private readonly IAcademicProgressRepository _academicProgressRepository;

        public AcademicProgressController(
            IAcademicProgressService academicProgressService,
            IAcademicProgressRepository academicProgressRepository)
        {
            _academicProgressService = academicProgressService;
            _academicProgressRepository = academicProgressRepository;
        }

        [HttpGet("indices")]
        public async Task<IActionResult> GetAcademicIndices(int studentId)
        {
            var result = await _academicProgressService.GetAcademicIndicesAsync(studentId);
            return result == null
                ? NotFound("No se encontraron calificaciones.")
                : Ok(result);
        }

        [HttpGet("grades/final")]
        public async Task<IActionResult> GetFinalGradesReport(
            int studentId,
            [FromQuery] int year,
            [FromQuery] int trimester)
        {
            var result = await _academicProgressService
                .GetFinalGradesReportAsync(studentId, year, trimester);

            return result == null
                ? NotFound("No se encontraron calificaciones finales.")
                : Ok(result);
        }

        [HttpGet("grades/midterm")]
        public async Task<IActionResult> GetMidtermGradesReport(
            int studentId,
            [FromQuery] int year,
            [FromQuery] int trimester)
        {
            var result = await _academicProgressService
                .GetMidtermGradesReportAsync(studentId, year, trimester);

            return result == null
                ? NotFound("No se encontraron calificaciones de medio término.")
                : Ok(result);
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetAcademicHistory(int studentId)
        {
            var result = await _academicProgressService.GetAcademicHistoryAsync(studentId);
            return result == null
                ? NotFound("No se encontró historial académico.")
                : Ok(result);
        }

        [HttpGet("~/api/academic-progress/asignaturas-cursadas")]
        public async Task<IActionResult> GetTotalAsignaturasCursadas([FromQuery] int usuarioId)
        {
            if (!await _academicProgressRepository.IsEstudianteAsync(usuarioId))
                return Forbid("Solo estudiantes pueden acceder.");

            var total = await _academicProgressRepository
                .GetTotalAsignaturasCursadasAsync(usuarioId);

            return Ok(new TotalAsignaturasCursadasDto
            {
                TotalAsignaturasCursadas = total
            });
        }

        [HttpGet("~/api/academic-progress/asignaturas-pendientes")]
        public async Task<IActionResult> GetTotalAsignaturasPendientes([FromQuery] int usuarioId)
        {
            if (!await _academicProgressRepository.IsEstudianteAsync(usuarioId))
                return Forbid("Solo estudiantes pueden acceder.");

            var total = await _academicProgressRepository
                .GetTotalAsignaturasPendientesAsync(usuarioId);

            return Ok(new TotalAsignaturasPendientesDto
            {
                TotalAsignaturasPendientes = total
            });
        }

        [HttpGet("~/api/academic-progress/trimestre-actual")]
        public async Task<IActionResult> GetTrimestreActual([FromQuery] int usuarioId)
        {
            if (!await _academicProgressRepository.IsEstudianteAsync(usuarioId))
                return Forbid("Solo estudiantes pueden acceder.");

            var trimestre = await _academicProgressRepository
                .GetTrimestreActualAsync(usuarioId);

            return trimestre == null
                ? NotFound()
                : Ok(new TrimestreActualDto
                {
                    TrimestreActualEstudiante = trimestre.Value
                });
        }

        [HttpGet("~/api/academic-progress/permanencia")]
        public async Task<IActionResult> GetPermanencia([FromQuery] int usuarioId)
        {
            if (!await _academicProgressRepository.IsEstudianteAsync(usuarioId))
                return Forbid("Solo estudiantes pueden acceder.");

            var permanencia = await _academicProgressRepository
                .GetPermanenciaEstudianteAsync(usuarioId);

            return permanencia == null
                ? NotFound()
                : Ok(new PermanenciaEstudianteDto
                {
                    PermanenciaEstudiante = permanencia.Value
                });
        }
    }
}
