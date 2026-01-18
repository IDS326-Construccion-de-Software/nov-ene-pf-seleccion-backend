using System;
using System.Collections.Generic;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;

public class ResumenSeleccionResponseDto
{
    public ResumenCargaSeleccionDto ResumenCarga { get; set; } = new();
    public IEnumerable<AsignaturaSeleccionResumenDto> Resumen { get; set; } = new List<AsignaturaSeleccionResumenDto>();
}

public class AsignaturaSeleccionResumenDto
{
    public int? SeleccionId { get; set; }
    public int? PreseleccionId { get; set; }
    public string AsignaturaId { get; set; } = string.Empty;
    public string Asignatura { get; set; } = string.Empty;
    public int Creditos { get; set; }
    public string TipoAsignatura { get; set; } = string.Empty;
    public int PeriodoTrimestre { get; set; }
    public DateTime? FechaRegistro { get; set; }
    public bool Definitiva { get; set; }
    public int TotalSeccionesAsignatura { get; set; }
    public List<SeccionSeleccionResumenDto> Secciones { get; set; } = new();
}

public class SeccionSeleccionResumenDto
{
    public int SeccionId { get; set; }
    public string CodigoSeccion { get; set; } = string.Empty;
    public string Profesor { get; set; } = string.Empty;
    public int Modalidad { get; set; }
    public int CupoTotal { get; set; }
    public int CupoDisponible { get; set; }
    public string Estatus { get; set; } = string.Empty;
    public bool Seleccionada { get; set; }
    public List<HorarioSeleccionResumenDto> Horarios { get; set; } = new();
}

public class HorarioSeleccionResumenDto
{
    public string Dia { get; set; } = string.Empty;
    public string HoraInicio { get; set; } = string.Empty;
    public string HoraFin { get; set; } = string.Empty;
    public string Aula { get; set; } = string.Empty;
    public string Edificio { get; set; } = string.Empty;
}
