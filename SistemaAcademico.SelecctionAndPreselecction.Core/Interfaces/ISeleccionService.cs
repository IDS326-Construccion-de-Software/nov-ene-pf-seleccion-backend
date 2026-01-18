using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;
using SistemaAcademico.Persistence.Data;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

public interface ISeleccionService
{
    Task<OfertaSeleccionResponseDto> GetOfertaAsync(
        int usuarioId, 
        string? searchTerm = null, 
        TipoAsignatura? tipo = null, 
        bool soloDisponibles = false, 
        ModalidadSeccion? modalidad = null,
        int? periodo = null,
        int page = 1,
        int itemsPerPage = 5);
    Task<AccionSeleccionResponseDto> SeleccionarAsync(int usuarioId, int seccionId);
    Task<ResumenSeleccionResponseDto> GetResumenAsync(int usuarioId);
    Task<AccionSeleccionResponseDto> CancelarSeleccionAsync(int id, int usuarioId);
    Task<bool> ConfirmarPreseleccionAsync(int usuarioId);
    Task<AccionSeleccionResponseDto> FinalizarSeleccionAsync(int usuarioId);
}
