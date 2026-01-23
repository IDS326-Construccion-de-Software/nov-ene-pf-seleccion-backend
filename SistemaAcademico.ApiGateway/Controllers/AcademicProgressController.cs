using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.AcademicProgress.Core.Interfaces;
using SistemaAcademico.AcademicProgress.Core.DTOs;
using System;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [ApiController]
    [Route("api/students/{studentId}/academic-progress")]
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

        /// <summary>
        /// Obtiene los índices académicos (de período y acumulado) para un estudiante.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <returns>Los índices académicos del estudiante.</returns>
        [HttpGet("indices")]
        public async Task<IActionResult> GetAcademicIndices(int studentId)
        {
            try
            {
                var result = await _academicProgressService.GetAcademicIndicesAsync(studentId);

                if (result == null)
                {
                    return NotFound("No se encontraron calificaciones para el estudiante especificado.");
                }

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el reporte de calificaciones finales para un período específico.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <param name="year">El año del período (ej. 2024).</param>
        /// <param name="trimester">El número del trimestre (ej. 3).</param>
        /// <returns>Un reporte con las calificaciones finales del estudiante.</returns>
        [HttpGet("grades/final")]
        public async Task<IActionResult> GetFinalGradesReport(int studentId, [FromQuery] int year, [FromQuery] int trimester)
        {
            try
            {
                var result = await _academicProgressService.GetFinalGradesReportAsync(studentId, year, trimester);

                if (result == null)
                {
                    return NotFound("No se encontraron calificaciones finales para el período especificado.");
                }

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el reporte de calificaciones de medio término para un período específico.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <param name="year">El año del período (ej. 2024).</param>
        /// <param name="trimester">El número del trimestre (ej. 3).</param>
        /// <returns>Un reporte con las calificaciones de medio término del estudiante.</returns>
        [HttpGet("grades/midterm")]
        public async Task<IActionResult> GetMidtermGradesReport(int studentId, [FromQuery] int year, [FromQuery] int trimester)
        {
            try
            {
                var result = await _academicProgressService.GetMidtermGradesReportAsync(studentId, year, trimester);

                if (result == null)
                {
                    return NotFound("No se encontraron calificaciones de medio término para el período especificado.");
                }

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el historial académico completo de un estudiante.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <returns>Un reporte completo con el historial académico del estudiante, organizado por trimestre.</returns>
        [HttpGet("history")]
        public async Task<IActionResult> GetAcademicHistory(int studentId)
        {
            try
            {
                var result = await _academicProgressService.GetAcademicHistoryAsync(studentId);

                if (result == null)
                {
                    return NotFound("No se encontró historial académico para el estudiante especificado.");
                }

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el total de asignaturas cursadas con estado Aprobado para un usuario.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario (query param).</param>
        /// <returns>El total de asignaturas aprobadas.</returns>
        [HttpGet("~/api/academic-progress/asignaturas-cursadas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTotalAsignaturasCursadas([FromQuery] int usuarioId)
        {
            try
            {
                // Verificar si el usuario es estudiante
                var esEstudiante = await _academicProgressRepository.IsEstudianteAsync(usuarioId);
                if (!esEstudiante)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Solo los estudiantes pueden consultar esta información.");
                }

                var total = await _academicProgressRepository.GetTotalAsignaturasCursadasAsync(usuarioId);

                var response = new TotalAsignaturasCursadasDto
                {
                    TotalAsignaturasCursadas = total
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el total de asignaturas pendientes por tomar en el programa académico del usuario.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario (query param).</param>
        /// <returns>El total de asignaturas pendientes.</returns>
        [HttpGet("~/api/academic-progress/asignaturas-pendientes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTotalAsignaturasPendientes([FromQuery] int usuarioId)
        {
            try
            {
                // Verificar si el usuario es estudiante
                var esEstudiante = await _academicProgressRepository.IsEstudianteAsync(usuarioId);
                if (!esEstudiante)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Solo los estudiantes pueden consultar esta información.");
                }

                var total = await _academicProgressRepository.GetTotalAsignaturasPendientesAsync(usuarioId);

                var response = new TotalAsignaturasPendientesDto
                {
                    TotalAsignaturasPendientes = total
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene el trimestre actual de un estudiante.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario (query param).</param>
        /// <returns>El trimestre actual del estudiante.</returns>
        [HttpGet("~/api/academic-progress/trimestre-actual")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTrimestreActual([FromQuery] int usuarioId)
        {
            try
            {
                // Verificar si el usuario es estudiante
                var esEstudiante = await _academicProgressRepository.IsEstudianteAsync(usuarioId);
                if (!esEstudiante)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Solo los estudiantes pueden consultar esta información.");
                }

                var trimestre = await _academicProgressRepository.GetTrimestreActualAsync(usuarioId);

                if (trimestre == null)
                {
                    return NotFound($"No se encontró información del programa académico para el usuario {usuarioId}.");
                }

                var response = new TrimestreActualDto
                {
                    TrimestreActualEstudiante = trimestre.Value
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Obtiene la permanencia de un estudiante.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario (query param).</param>
        /// <returns>La permanencia del estudiante.</returns>
        [HttpGet("~/api/academic-progress/permanencia")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPermanencia([FromQuery] int usuarioId)
        {
            try
            {
                // Verificar si el usuario es estudiante
                var esEstudiante = await _academicProgressRepository.IsEstudianteAsync(usuarioId);
                if (!esEstudiante)
                {
                    return StatusCode(StatusCodes.Status403Forbidden, "Solo los estudiantes pueden consultar esta información.");
                }

                var permanencia = await _academicProgressRepository.GetPermanenciaEstudianteAsync(usuarioId);

                if (permanencia == null)
                {
                    return NotFound($"No se encontró información del programa académico para el usuario {usuarioId}.");
                }

                var response = new PermanenciaEstudianteDto
                {
                    PermanenciaEstudiante = permanencia.Value
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}