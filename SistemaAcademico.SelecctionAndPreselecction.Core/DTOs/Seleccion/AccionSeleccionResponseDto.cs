namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class AccionSeleccionResponseDto
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public ResumenCargaSeleccionDto ResumenCarga { get; set; } = new();
    public EstatusValidacionSeleccionDto? EstatusValidacion { get; set; }
    public int? CantidadAsignaturas { get; set; }
}
