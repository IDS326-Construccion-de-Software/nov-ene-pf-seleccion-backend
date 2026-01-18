using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;
using SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.ApiGateway.Constants;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace SistemaAcademico.ApiGateway.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SelectionController : ControllerBase
{
    private readonly ISeleccionService _seleccionService;

    public SelectionController(ISeleccionService seleccionService)
    {
        _seleccionService = seleccionService;
    }

    /// <summary>
    /// Obtiene la oferta de asignaturas disponibles para seleccionar durante la fase de Selección.
    /// </summary>
    [HttpGet("oferta/{usuarioId}")]
    public async Task<ActionResult<OfertaSeleccionResponseDto>> GetOferta(
        int usuarioId,
        [FromQuery] string? searchTerm,
        [FromQuery] TipoAsignatura? tipoAsignatura,
        [FromQuery] bool soloDisponibles = false,
        [FromQuery] ModalidadSeccion? modalidad = null,
        [FromQuery] int? periodo = null,
        [FromQuery] int page = PaginationParams.page,
        [FromQuery] int itemsPerPage = PaginationParams.itemsPerPage)
    {
        var response = await _seleccionService.GetOfertaAsync(usuarioId, searchTerm, tipoAsignatura, soloDisponibles, modalidad, periodo, page, itemsPerPage);
        if (response.TotalItems > 0 && page > response.TotalPages)
        {
            return NotFound("No hay más páginas disponibles");
        }

        return Ok(response);
    }

    /// <summary>
    /// Selecciona una asignatura durante la fase de Selección.
    /// </summary>
    [HttpPost("seleccionar")]
    public async Task<ActionResult<AccionSeleccionResponseDto>> Seleccionar([FromBody] SeleccionRequest request)
    {
        var result = await _seleccionService.SeleccionarAsync(request.UsuarioId, request.SeccionId);
        if (!result.Success) return BadRequest(result);
        return Ok(result);
    }

    /// <summary>
    /// Obtiene el resumen de las asignaturas seleccionadas por el estudiante.
    /// </summary>
    [HttpGet("resumen/{usuarioId}")]
    public async Task<ActionResult<ResumenSeleccionResponseDto>> GetResumen(int usuarioId)
    {
        var response = await _seleccionService.GetResumenAsync(usuarioId);
        return Ok(response);
    }

    /// <summary>
    /// Cancela una asignatura seleccionada.
    /// </summary>
    [HttpDelete("cancelar/{id}/{usuarioId}")]
    public async Task<ActionResult<AccionSeleccionResponseDto>> Cancelar(int id, int usuarioId)
    {
        var result = await _seleccionService.CancelarSeleccionAsync(id, usuarioId);
        if (!result.Success) return BadRequest(result);
        return Ok(result);
    }

    /// <summary>
    /// Confirma automáticamente las asignaturas preseleccionadas pasándolas a selección definitiva.
    /// Solo disponible durante la fase de Selección.
    /// </summary>
    [HttpPost("confirmar-preseleccion/{usuarioId}")]
    public async Task<IActionResult> ConfirmarPreseleccion(int usuarioId)
    {
        var result = await _seleccionService.ConfirmarPreseleccionAsync(usuarioId);
        if (!result) return BadRequest("No se pudo confirmar la preselección. Verifique que esté en fase de selección y tenga preselecciones activas.");
        return Ok(new { message = "Preselección confirmada exitosamente." });
    }

    /// <summary>
    /// Realiza la selección definitiva de las asignaturas del estudiante.
    /// Este endpoint finaliza el proceso de selección, confirmando de forma definitiva 
    /// todas las asignaturas seleccionadas que serán cursadas en el periodo académico.
    /// Solo disponible durante la fase de Selección.
    /// </summary>
    /// <param name="usuarioId">ID del estudiante.</param>
    /// <returns>Resultado de la operación indicando la cantidad de asignaturas confirmadas en la selección definitiva.</returns>
    [HttpPost("finalizar/{usuarioId}")]
    public async Task<ActionResult<AccionSeleccionResponseDto>> FinalizarSeleccion(int usuarioId)
    {
        var result = await _seleccionService.FinalizarSeleccionAsync(usuarioId);
        if (!result.Success) return BadRequest(result);
        return Ok(result);
    }


}

public class SeleccionRequest
{
    public int UsuarioId { get; set; }
    public int SeccionId { get; set; }
}
