namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class EstatusValidacionSeleccionDto
{
    public bool PuedeInscribir { get; set; }
    public string? Motivo { get; set; }
    public string? DetalleAsignatura { get; set; }
    public string? Dia { get; set; }
    public string? HoraInicio { get; set; }
    public string? HoraFin { get; set; }
}
