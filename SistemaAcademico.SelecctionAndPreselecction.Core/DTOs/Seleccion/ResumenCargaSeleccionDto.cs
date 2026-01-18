namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class ResumenCargaSeleccionDto
{
    public int CreditosSeleccionados { get; set; }
    public int CreditosMaximos { get; set; } = 25;
    public bool PuedeAgregarMas => CreditosSeleccionados < CreditosMaximos;
    public string MensajeEstado { get; set; } = string.Empty;
}
