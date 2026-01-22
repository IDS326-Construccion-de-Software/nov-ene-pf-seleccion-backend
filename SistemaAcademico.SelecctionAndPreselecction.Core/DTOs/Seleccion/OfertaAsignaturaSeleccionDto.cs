using System.Collections.Generic;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class OfertaAsignaturaSeleccionDto
{
    public int? SeleccionId { get; set; }
    public string AsignaturaId { get; set; } = null!;
    public string Asignatura { get; set; } = null!;
    public int Creditos { get; set; }
    public string TipoAsignatura { get; set; } = null!;
    public int PeriodoTrimestre { get; set; }
    public bool PuedeSeleccionar { get; set; }
    public string? MotivoBloqueo { get; set; }
    public bool Definitiva { get; set; }
    public int TotalSeccionesAsignatura { get; set; }
    public List<SeccionOfertaSeleccionDto> Secciones { get; set; } = new();
}

public class SeccionOfertaSeleccionDto
{
    public int SeccionId { get; set; }
    public string CodigoSeccion { get; set; } = null!;
    public string Profesor { get; set; } = null!;
    public int Modalidad { get; set; }
    public int CupoTotal { get; set; }
    public int CupoDisponible { get; set; }
    public bool Seleccionada { get; set; }
    public EstatusValidacionSeleccionDto? EstatusValidacion { get; set; }
    public List<HorarioOfertaSeleccionDto> Horarios { get; set; } = new();
}

public class HorarioOfertaSeleccionDto
{
    public string Dia { get; set; } = null!;
    public string HoraInicio { get; set; } = null!;
    public string HoraFin { get; set; } = null!;
    public string Aula { get; set; } = null!;
    public string Edificio { get; set; } = null!;
}
