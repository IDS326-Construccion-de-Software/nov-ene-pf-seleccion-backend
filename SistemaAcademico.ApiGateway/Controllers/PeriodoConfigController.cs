using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.PeriodoConfig;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodoConfigController : ControllerBase
    {
        private readonly IPeriodoConfigService _periodoConfigService;

        public PeriodoConfigController(IPeriodoConfigService periodoConfigService)
        {
            _periodoConfigService = periodoConfigService;
        }

        /// <summary>
        /// Obtiene todos los periodos académicos configurados en el sistema.
        /// </summary>
        /// <returns>Lista de todos los periodos académicos.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeriodoConfigDto>>> GetAll()
        {
            var periods = await _periodoConfigService.GetAllAsync();
            return Ok(periods);
        }

        /// <summary>
        /// Obtiene un periodo académico específico por su ID.
        /// </summary>
        /// <param name="id">ID del periodo académico.</param>
        /// <returns>Información del periodo académico solicitado.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<PeriodoConfigDto>> GetById(int id)
        {
            var period = await _periodoConfigService.GetByIdAsync(id);
            if (period == null) return NotFound($"No se encontró el periodo con ID {id}.");
            return Ok(period);
        }

        /// <summary>
        /// Obtiene el periodo académico activo actual basado en la fecha del sistema.
        /// Determina automáticamente qué periodo está vigente comparando la fecha actual 
        /// con los rangos de PreseleccionInicio y SeleccionFin de cada periodo.
        /// </summary>
        /// <returns>Periodo académico activo actual con su ID, código (ej: "2026-01") y nombre (ej: "Noviembre 2025 - Enero 2026").</returns>
        /// <response code="200">Retorna el periodo activo con toda su información.</response>
        /// <response code="404">No hay ningún periodo activo en la fecha actual.</response>
        [HttpGet("active")]
        public async Task<IActionResult> GetActivePeriod()
        {
            var period = await _periodoConfigService.GetActivePeriodAsync();
            if (period == null) return NotFound("No hay un periodo activo configurado.");
            return Ok(period);
        }

        /// <summary>
        /// Obtiene la fase actual del periodo académico activo.
        /// </summary>
        /// <returns>Fase actual: Preseleccion, Seleccion, Espera o Cerrado.</returns>
        [HttpGet("fase")]
        public async Task<IActionResult> GetCurrentFase()
        {
            var fase = await _periodoConfigService.GetCurrentFaseAsync();
            return Ok(new { Fase = fase.ToString() });
        }

        /// <summary>
        /// Verifica si se pueden realizar modificaciones en el periodo actual.
        /// Las modificaciones están permitidas en fase de Preselección o en Selección 
        /// si el periodo tiene habilitado PermitirModificarEnSeleccion.
        /// </summary>
        /// <returns>true si se pueden hacer modificaciones, false en caso contrario.</returns>
        [HttpGet("can-modify")]
        public async Task<IActionResult> CanModify()
        {
            var canModify = await _periodoConfigService.CanModifyAsync();
            return Ok(new { CanModify = canModify });
        }

        /// <summary>
        /// Crea un nuevo periodo académico.
        /// </summary>
        /// <param name="dto">Datos del periodo a crear.</param>
        /// <returns>Mensaje de confirmación.</returns>
        [HttpPost]
        public async Task<IActionResult> CreatePeriod([FromBody] CreatePeriodoConfigDto dto)
        {
            await _periodoConfigService.CreateAsync(dto);
            return Ok("Periodo creado exitosamente.");
        }

        /// <summary>
        /// Actualiza las fechas y configuración de un periodo académico existente.
        /// </summary>
        /// <param name="id">ID del periodo a actualizar.</param>
        /// <param name="dto">Nuevos datos del periodo.</param>
        /// <returns>Mensaje de confirmación.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePeriodDates(int id, [FromBody] CreatePeriodoConfigDto dto)
        {
            await _periodoConfigService.UpdateDatesAsync(id, dto);
            return Ok("Fechas del periodo actualizadas exitosamente.");
        }

        /// <summary>
        /// Elimina un periodo académico del sistema.
        /// </summary>
        /// <param name="id">ID del periodo a eliminar.</param>
        /// <returns>Mensaje de confirmación.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeriod(int id)
        {
            await _periodoConfigService.DeleteAsync(id);
            return Ok("Periodo eliminado exitosamente.");
        }

    }
}
