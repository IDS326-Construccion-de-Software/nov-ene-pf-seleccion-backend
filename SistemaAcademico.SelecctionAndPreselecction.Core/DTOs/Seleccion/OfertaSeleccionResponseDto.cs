using System.Collections.Generic;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class OfertaSeleccionResponseDto
{
    public ResumenCargaSeleccionDto ResumenCarga { get; set; } = new();
    public IEnumerable<OfertaAsignaturaSeleccionDto> Oferta { get; set; } = new List<OfertaAsignaturaSeleccionDto>();
    public int Page { get; set; }
    public int ItemsPerPage { get; set; }
    public int TotalPages { get; set; }
    public int TotalItems { get; set; }
}
