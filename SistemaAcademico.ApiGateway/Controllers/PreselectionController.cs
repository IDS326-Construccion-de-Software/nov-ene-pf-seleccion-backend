using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.ApiGateway.Constants;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Preseleccion;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "estudiante")]
    public class PreselectionController : ControllerBase
    {
        private readonly IPreseleccionService _preseleccionService;

        public PreselectionController(IPreseleccionService preseleccionService)
        {
            _preseleccionService = preseleccionService;
        }

        [HttpGet("oferta/{usuarioId}")]
        public async Task<ActionResult<OfertaResponseDto>> GetOferta(
            int usuarioId,
            [FromQuery] string? searchTerm,
            [FromQuery] TipoAsignatura? tipoAsignatura,
            [FromQuery] bool soloDisponibles = false,
            [FromQuery] ModalidadSeccion? modalidad = null,
            [FromQuery] int? periodo = null,
            [FromQuery] int page = PaginationParams.page,
            [FromQuery] int itemsPerPage = PaginationParams.itemsPerPage)
        {
            var response = await _preseleccionService.GetOfertaAsync(
                usuarioId, searchTerm, tipoAsignatura,
                soloDisponibles, modalidad, periodo, page, itemsPerPage);

            if (response.TotalItems > 0 && page > response.TotalPages)
                return NotFound("No hay más páginas disponibles");

            return Ok(response);
        }

        [HttpPost("guardar")]
        public async Task<ActionResult<AccionPreseleccionResponseDto>> Guardar(
            [FromBody] GuardarPreseleccionRequest request)
        {
            var result = await _preseleccionService
                .GuardarPreseleccionAsync(request.UsuarioId, request.SeccionId);

            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("resumen/{usuarioId}")]
        public async Task<ActionResult<ResumenPreseleccionResponseDto>> GetResumen(int usuarioId)
        {
            return Ok(await _preseleccionService.GetResumenAsync(usuarioId));
        }

        [HttpDelete("cancelar/{id}/{usuarioId}")]
        public async Task<ActionResult<AccionPreseleccionResponseDto>> Cancelar(int id, int usuarioId)
        {
            var result = await _preseleccionService.CancelarPreseleccionAsync(id, usuarioId);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("finalizar/{usuarioId}")]
        public async Task<ActionResult<AccionPreseleccionResponseDto>> FinalizarPreseleccion(int usuarioId)
        {
            var result = await _preseleccionService.FinalizarPreseleccionAsync(usuarioId);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }
    }

    public class GuardarPreseleccionRequest
    {
        public int UsuarioId { get; set; }
        public int SeccionId { get; set; }
    }
}
