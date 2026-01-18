using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.SelecctionAndPreselecction.Core.DTOs.Seleccion;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.Services;

public class SeleccionService : ISeleccionService
{
    private readonly ISeleccionRepository _seleccionRepository;
    private readonly IPreseleccionRepository _preseleccionRepository;
    private readonly IPeriodoConfigService _periodoConfigService;
    private readonly IMapper _mapper;

    public SeleccionService(
        ISeleccionRepository seleccionRepository, 
        IPreseleccionRepository preseleccionRepository,
        IPeriodoConfigService periodoConfigService,
        IMapper mapper)
    {
        _seleccionRepository = seleccionRepository;
        _preseleccionRepository = preseleccionRepository;
        _periodoConfigService = periodoConfigService;
        _mapper = mapper;
    }

    private async Task<ResumenCargaSeleccionDto> GetResumenCargaAsync(int usuarioId, int periodoId)
    {
        var usuarioPrograma = await _preseleccionRepository.GetUsuarioProgramaAsync(usuarioId);
        if (usuarioPrograma == null) return new ResumenCargaSeleccionDto { MensajeEstado = "Usuario no encontrado" };

        var asignaturasPrograma = await _preseleccionRepository.GetAsignaturasByProgramaAsync(usuarioPrograma.IdProgramaAcademico);
        
        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, periodoId);
        var creditosPre = preselecciones
            .Select(p => asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == p.IdSeccionNavigation.IdAsignatura)?.Creditos ?? 0)
            .Sum();

        var selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, periodoId);
        var creditosSel = selecciones
            .Select(s => asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == s.IdSeccionNavigation.IdAsignatura)?.Creditos ?? 0)
            .Sum();

        int totalCreditos = creditosPre + creditosSel;
        int max = 25;
        int restantes = max - totalCreditos;

        return new ResumenCargaSeleccionDto
        {
            CreditosSeleccionados = totalCreditos,
            CreditosMaximos = max,
            MensajeEstado = restantes > 0 
                ? $"Te quedan {restantes} créditos disponibles" 
                : "Has alcanzado el límite de créditos permitidos"
        };
    }

    private async Task<EstatusValidacionSeleccionDto?> CheckScheduleConflictsAsync(int usuarioId, int periodoId, List<Seccion> nuevasSecciones)
    {
        var selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, periodoId);
        var horariosExistentes = selecciones.SelectMany(s => s.IdSeccionNavigation.SeccionHorarios).ToList();

        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, periodoId);
        horariosExistentes.AddRange(preselecciones.SelectMany(p => p.IdSeccionNavigation.SeccionHorarios));

        foreach (var nuevaSeccion in nuevasSecciones)
        {
            foreach (var nuevoHorario in nuevaSeccion.SeccionHorarios)
            {
                foreach (var existente in horariosExistentes)
                {
                    // No chocar con la misma sección si ya está seleccionada/preseleccionada
                    if (nuevaSeccion.SeccionId == existente.IdSeccion) continue;

                    if (nuevoHorario.Dia == existente.Dia)
                    {
                        if (nuevoHorario.HoraInicio < existente.HoraFin && nuevoHorario.HoraFin > existente.HoraInicio)
                        {
                            return new EstatusValidacionSeleccionDto
                            {
                                PuedeInscribir = false,
                                Motivo = "Choque de horario",
                                DetalleAsignatura = existente.IdSeccionNavigation.IdAsignaturaNavigation.Nombre,
                                Dia = existente.Dia.ToString(),
                                HoraInicio = existente.HoraInicio.ToString(@"hh\:mm"),
                                HoraFin = existente.HoraFin.ToString(@"hh\:mm")
                            };
                        }
                    }
                }
            }
        }

        return null;
    }

    public async Task<OfertaSeleccionResponseDto> GetOfertaAsync(
        int usuarioId, 
        string? searchTerm = null, 
        TipoAsignatura? tipo = null, 
        bool soloDisponibles = false, 
        ModalidadSeccion? modalidad = null,
        int? periodo = null,
        int page = 1,
        int itemsPerPage = 5)
    {
        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null) return new OfertaSeleccionResponseDto();

        var usuarioPrograma = await _preseleccionRepository.GetUsuarioProgramaAsync(usuarioId);
        if (usuarioPrograma == null) return new OfertaSeleccionResponseDto();

        var asignaturasPrograma = await _preseleccionRepository.GetAsignaturasByProgramaAsync(usuarioPrograma.IdProgramaAcademico);
        var historial = await _preseleccionRepository.GetHistorialByUsuarioAsync(usuarioId);
        var secciones = await _preseleccionRepository.GetSeccionesByPeriodoAsync(activePeriod.Codigo);

        // Aplicar filtros
        if (!string.IsNullOrEmpty(searchTerm))
        {
            searchTerm = searchTerm.ToLower();
            var seccionesMatchIds = secciones
                .Where(s => s.SeccionId.ToString().Contains(searchTerm))
                .Select(s => s.IdAsignatura)
                .ToHashSet();

            asignaturasPrograma = asignaturasPrograma
                .Where(a => a.IdAsignatura.ToLower().Contains(searchTerm) || 
                            a.IdAsignaturaNavigation.Nombre.ToLower().Contains(searchTerm) ||
                            seccionesMatchIds.Contains(a.IdAsignatura))
                .ToList();
        }

        if (tipo.HasValue)
        {
            asignaturasPrograma = asignaturasPrograma
                .Where(a => a.IdAsignaturaNavigation.Tipo == tipo.Value)
                .ToList();
        }

        if (periodo.HasValue)
        {
            asignaturasPrograma = asignaturasPrograma
                .Where(a => a.Periodo == periodo.Value)
                .ToList();
        }

        if (modalidad.HasValue)
        {
            secciones = secciones.Where(s => s.Modalidad == modalidad.Value).ToList();
        }

        // Obtener secciones ya seleccionadas
        var selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        
        // Obtener preselecciones procesadas (Procesada = true)
        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var preseleccionesProcesadas = preselecciones.Where(p => p.Procesada).ToList();
        
        var horariosExistentes = selecciones.SelectMany(s => s.IdSeccionNavigation.SeccionHorarios)
            .Concat(preseleccionesProcesadas.SelectMany(p => p.IdSeccionNavigation.SeccionHorarios))
            .ToList();

        var seccionesSeleccionadasIds = selecciones.Select(s => s.IdSeccion)
            .Concat(preseleccionesProcesadas.Select(p => p.IdSeccion))
            .ToHashSet();

        var aprobadasIds = historial
            .Where(h => h.Estatus == HistorialEstatus.Aprobado || h.Estatus == HistorialEstatus.Convalidado || h.Estatus == HistorialEstatus.Exonerado)
            .Select(h => h.IdAsignatura)
            .ToHashSet();

        var oferta = new List<OfertaAsignaturaSeleccionDto>();

        foreach (var apa in asignaturasPrograma)
        {
            if (aprobadasIds.Contains(apa.IdAsignatura)) continue;

            var faltanPrerrequisitos = apa.PreRequisitos.Any(pre => !aprobadasIds.Contains(pre));
            var esValidoParaNivel = apa.Periodo <= usuarioPrograma.TrimestreActual + 1;

            // Obtener asignaturas actualmente seleccionadas
            var asignaturasSeleccionadasIds = selecciones.Select(s => s.IdSeccionNavigation.IdAsignatura)
                .Concat(preseleccionesProcesadas.Select(p => p.IdSeccionNavigation.IdAsignatura))
                .ToHashSet();

            // Validar correquisito
            var faltaCorrequisito = !string.IsNullOrEmpty(apa.Corequisito) &&
                                    !asignaturasSeleccionadasIds.Contains(apa.Corequisito) &&
                                    !aprobadasIds.Contains(apa.Corequisito);

            bool puedeSeleccionar;
            string? motivoBloqueo = null;

            if (!esValidoParaNivel)
            {
                puedeSeleccionar = false;
                motivoBloqueo = $"COMPLETAR TRIMESTRE {usuarioPrograma.TrimestreActual + 1}";
            }
            else
            {
                if (faltanPrerrequisitos)
                {
                    puedeSeleccionar = false;
                    var prerequisitosPendientes = apa.PreRequisitos.Where(pre => !aprobadasIds.Contains(pre)).ToList();
                    motivoBloqueo = $"{string.Join(", ", prerequisitosPendientes)}";
                }
                else if (faltaCorrequisito)
                {
                    puedeSeleccionar = false;
                    motivoBloqueo = $"CORREQUISITO: {apa.Corequisito}";
                }
                else
                {
                    puedeSeleccionar = true;
                }
            }

            var seccionesAsignatura = secciones.Where(s => s.IdAsignatura == apa.IdAsignatura).ToList();
            if (!seccionesAsignatura.Any()) continue;

            var seccionesDto = _mapper.Map<List<SeccionOfertaSeleccionDto>>(seccionesAsignatura);
            foreach (var sDto in seccionesDto)
            {
                sDto.Seleccionada = seccionesSeleccionadasIds.Contains(sDto.SeccionId);
                
                if (!sDto.Seleccionada)
                {
                    var seccionEntidad = seccionesAsignatura.First(s => s.SeccionId == sDto.SeccionId);
                    sDto.EstatusValidacion = await CheckScheduleConflictsAsync(usuarioId, activePeriod.Id, new List<Seccion> { seccionEntidad });
                    
                    if (sDto.EstatusValidacion == null)
                    {
                        sDto.EstatusValidacion = new EstatusValidacionSeleccionDto { PuedeInscribir = true };
                    }
                }
                else
                {
                    sDto.EstatusValidacion = new EstatusValidacionSeleccionDto { PuedeInscribir = true };
                }
            }

            if (soloDisponibles && !puedeSeleccionar) continue;

            var dto = new OfertaAsignaturaSeleccionDto
            {
                SeleccionId = preseleccionesProcesadas.FirstOrDefault(p => p.IdSeccionNavigation.IdAsignatura == apa.IdAsignatura)?.Id 
                                ?? selecciones.FirstOrDefault(s => s.IdSeccionNavigation.IdAsignatura == apa.IdAsignatura)?.Id,
                AsignaturaId = apa.IdAsignatura,
                Asignatura = apa.IdAsignaturaNavigation.Nombre,
                Creditos = apa.Creditos,
                TipoAsignatura = apa.IdAsignaturaNavigation.Tipo.ToString(),
                PeriodoTrimestre = apa.Periodo,
                PuedeSeleccionar = puedeSeleccionar,
                MotivoBloqueo = motivoBloqueo,
                Procesada = preseleccionesProcesadas.Any(p => p.IdSeccionNavigation.IdAsignatura == apa.IdAsignatura),
                TotalSeccionesAsignatura = seccionesDto.Count,
                Secciones = seccionesDto
            };
            oferta.Add(dto);
        }

        var totalItems = oferta.Count;
        var totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
        
        var pagedOferta = oferta
            .OrderByDescending(o => o.Secciones.Any(s => s.Seleccionada))
            .ThenByDescending(o => o.SeleccionId.HasValue)
            .ThenBy(o => o.PeriodoTrimestre)
            .ThenBy(o => o.Asignatura)
            .Skip((page - 1) * itemsPerPage)
            .Take(itemsPerPage)
            .ToList();

        return new OfertaSeleccionResponseDto
        {
            ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id),
            Oferta = pagedOferta,
            Page = page,
            ItemsPerPage = itemsPerPage,
            TotalPages = totalPages,
            TotalItems = totalItems
        };
    }

    public async Task<AccionSeleccionResponseDto> SeleccionarAsync(int usuarioId, int seccionId)
    {
        var fase = await _periodoConfigService.GetCurrentFaseAsync();
        if (fase != PeriodoFase.Seleccion) 
            return new AccionSeleccionResponseDto { Success = false, Message = "El proceso de selección no está activo actualmente." };

        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null || !activePeriod.PermitirModificarEnSeleccion) 
            return new AccionSeleccionResponseDto { Success = false, Message = "No se permite modificar la selección en este momento." };

        // Validar si ya está seleccionada
        var actuales = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        if (actuales.Any(s => s.IdSeccion == seccionId)) 
            return new AccionSeleccionResponseDto { Success = true, Message = "Ya tienes esta sección seleccionada.", ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id) };

        // Validar si la asignatura ya está aprobada
        var seccion = (await _preseleccionRepository.GetSeccionesByIdsAsync(new List<int> { seccionId })).FirstOrDefault();
        if (seccion == null) 
            return new AccionSeleccionResponseDto { Success = false, Message = "Sección no encontrada." };

        var historial = await _preseleccionRepository.GetHistorialByUsuarioAsync(usuarioId);
        if (historial.Any(h => h.IdAsignatura == seccion.IdAsignatura && 
            (h.Estatus == HistorialEstatus.Aprobado || h.Estatus == HistorialEstatus.Convalidado || h.Estatus == HistorialEstatus.Exonerado)))
        {
            return new AccionSeleccionResponseDto { Success = false, Message = "Ya has aprobado esta asignatura." };
        }

        // Validar si ya tiene otra sección de la misma asignatura en este periodo
        if (actuales.Any(s => s.IdSeccionNavigation.IdAsignatura == seccion.IdAsignatura))
        {
            return new AccionSeleccionResponseDto { Success = false, Message = "Ya tienes otra sección de esta asignatura seleccionada." };
        }

        // Validar prerrequisitos y nivel
        var usuarioPrograma = await _preseleccionRepository.GetUsuarioProgramaAsync(usuarioId);
        if (usuarioPrograma == null) return new AccionSeleccionResponseDto { Success = false, Message = "Usuario no encontrado." };

        var asignaturasPrograma = await _preseleccionRepository.GetAsignaturasByProgramaAsync(usuarioPrograma.IdProgramaAcademico);
        var apa = asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == seccion.IdAsignatura);
        
        if (apa != null)
        {
            var aprobadasIds = historial
                .Where(h => h.Estatus == HistorialEstatus.Aprobado || h.Estatus == HistorialEstatus.Convalidado || h.Estatus == HistorialEstatus.Exonerado)
                .Select(h => h.IdAsignatura)
                .ToHashSet();

            var faltanPrerrequisitos = apa.PreRequisitos.Any(pre => !aprobadasIds.Contains(pre));
            var esValidoParaNivel = apa.Periodo <= usuarioPrograma.TrimestreActual + 1;

            if (!esValidoParaNivel)
            {
                return new AccionSeleccionResponseDto { Success = false, Message = $"No puedes seleccionar {seccion.IdAsignatura} porque solo se permiten asignaturas hasta el trimestre {usuarioPrograma.TrimestreActual + 1}." };
            }

            if (faltanPrerrequisitos)
            {
                return new AccionSeleccionResponseDto { Success = false, Message = $"No puedes seleccionar {seccion.IdAsignatura} porque te faltan prerrequisitos para el trimestre {apa.Periodo}." };
            }
        }

        // Validar choques de horario
        var conflicto = await CheckScheduleConflictsAsync(usuarioId, activePeriod.Id, new List<Seccion> { seccion });
        if (conflicto != null)
        {
            return new AccionSeleccionResponseDto 
            { 
                Success = false, 
                Message = "Se detectó un choque de horario.",
                EstatusValidacion = conflicto,
                ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id)
            };
        }

        // Validar límite de créditos
        var resumenActual = await GetResumenCargaAsync(usuarioId, activePeriod.Id);
        int creditosNuevos = asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == seccion.IdAsignatura)?.Creditos ?? 0;

        if (resumenActual.CreditosSeleccionados + creditosNuevos > resumenActual.CreditosMaximos)
        {
            return new AccionSeleccionResponseDto { Success = false, Message = $"No puedes exceder el límite de {resumenActual.CreditosMaximos} créditos." };
        }

        var seleccion = new Seleccion
        {
            IdUsuario = usuarioId,
            IdSeccion = seccionId,
            IdPeriodo = activePeriod.Id,
            FechaRegistro = DateTime.Now,
            FechaConfirmacion = null,
            EstatusAcademico = SeleccionEstatus.Inscrito,
            VieneDePreseleccion = false,
            Activa = true,
            Definitiva = false
        };

        await _seleccionRepository.AddAsync(seleccion);
        
        return new AccionSeleccionResponseDto 
        { 
            Success = true, 
            Message = "Asignatura seleccionada exitosamente.",
            ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id)
        };
    }

    public async Task<ResumenSeleccionResponseDto> GetResumenAsync(int usuarioId)
    {
        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null) return new ResumenSeleccionResponseDto();

        var selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        
        // Obtener solo preselecciones procesadas que NO se hayan convertido en selecciones
        var seccionesSeleccionadas = selecciones.Select(s => s.IdSeccion).ToHashSet();
        var preseleccionesProcesadas = preselecciones
            .Where(p => p.Activa && p.Procesada && !seccionesSeleccionadas.Contains(p.IdSeccion))
            .ToList();

        var usuarioPrograma = await _preseleccionRepository.GetUsuarioProgramaAsync(usuarioId);
        var asignaturasPrograma = usuarioPrograma != null 
            ? await _preseleccionRepository.GetAsignaturasByProgramaAsync(usuarioPrograma.IdProgramaAcademico)
            : new List<AsignaturaProgramaAcademico>();

        var resumenAgrupado = new List<AsignaturaSeleccionResumenDto>();

        // Agrupar selecciones por asignatura
        var seleccionesAgrupadas = selecciones
            .GroupBy(s => s.IdSeccionNavigation.IdAsignatura)
            .ToList();

        foreach (var grupo in seleccionesAgrupadas)
        {
            var primeraSeleccion = grupo.First();
            var asignatura = primeraSeleccion.IdSeccionNavigation.IdAsignaturaNavigation;
            var apa = asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == asignatura.AsignaturaId);

            var secciones = grupo.Select(s => new SeccionSeleccionResumenDto
            {
                SeccionId = s.IdSeccion,
                CodigoSeccion = s.IdSeccionNavigation.NumeroSeccion,
                Profesor = s.IdSeccionNavigation.IdProfesorNavigation != null && s.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation != null
                    ? $"{s.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation.Nombre} {s.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation.Apellido}"
                    : "Por asignar",
                Modalidad = (int)s.IdSeccionNavigation.Modalidad,
                CupoTotal = s.IdSeccionNavigation.Cupo,
                CupoDisponible = s.IdSeccionNavigation.CupoDisponible,
                Estatus = s.EstatusAcademico.ToString(),
                Seleccionada = true,
                Horarios = s.IdSeccionNavigation.SeccionHorarios.Select(h => new HorarioSeleccionResumenDto
                {
                    Dia = h.Dia.ToString(),
                    HoraInicio = h.HoraInicio.ToString(@"hh\:mm"),
                    HoraFin = h.HoraFin.ToString(@"hh\:mm"),
                    Aula = h.IdAulaNavigation?.Nombre ?? "N/A",
                    Edificio = h.IdAulaNavigation?.IdEdificioNavigation?.Nombre ?? "N/A"
                }).ToList()
            }).ToList();

            resumenAgrupado.Add(new AsignaturaSeleccionResumenDto
            {
                SeleccionId = primeraSeleccion.Id,
                AsignaturaId = asignatura.AsignaturaId,
                Asignatura = asignatura.Nombre,
                Creditos = apa?.Creditos ?? 0,
                TipoAsignatura = asignatura.Tipo.ToString(),
                PeriodoTrimestre = apa?.Periodo ?? 0,
                FechaRegistro = primeraSeleccion.FechaRegistro,
                Definitiva = primeraSeleccion.Definitiva,
                TotalSeccionesAsignatura = secciones.Count,
                Secciones = secciones
            });
        }

        // Agrupar preselecciones procesadas por asignatura
        var preseleccionesAgrupadas = preseleccionesProcesadas
            .GroupBy(p => p.IdSeccionNavigation.IdAsignatura)
            .ToList();

        foreach (var grupo in preseleccionesAgrupadas)
        {
            var primeraPreseleccion = grupo.First();
            var asignatura = primeraPreseleccion.IdSeccionNavigation.IdAsignaturaNavigation;
            var apa = asignaturasPrograma.FirstOrDefault(a => a.IdAsignatura == asignatura.AsignaturaId);

            var secciones = grupo.Select(p => new SeccionSeleccionResumenDto
            {
                SeccionId = p.IdSeccion,
                CodigoSeccion = p.IdSeccionNavigation.NumeroSeccion,
                Profesor = p.IdSeccionNavigation.IdProfesorNavigation != null && p.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation != null
                    ? $"{p.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation.Nombre} {p.IdSeccionNavigation.IdProfesorNavigation.IdUsuarioNavigation.Apellido}"
                    : "Por asignar",
                Modalidad = (int)p.IdSeccionNavigation.Modalidad,
                CupoTotal = p.IdSeccionNavigation.Cupo,
                CupoDisponible = p.IdSeccionNavigation.CupoDisponible,
                Estatus = "Preseleccionada",
                Seleccionada = true,
                Horarios = p.IdSeccionNavigation.SeccionHorarios.Select(h => new HorarioSeleccionResumenDto
                {
                    Dia = h.Dia.ToString(),
                    HoraInicio = h.HoraInicio.ToString(@"hh\:mm"),
                    HoraFin = h.HoraFin.ToString(@"hh\:mm"),
                    Aula = h.IdAulaNavigation?.Nombre ?? "N/A",
                    Edificio = h.IdAulaNavigation?.IdEdificioNavigation?.Nombre ?? "N/A"
                }).ToList()
            }).ToList();

            resumenAgrupado.Add(new AsignaturaSeleccionResumenDto
            {
                PreseleccionId = primeraPreseleccion.Id,
                AsignaturaId = asignatura.AsignaturaId,
                Asignatura = asignatura.Nombre,
                Creditos = apa?.Creditos ?? 0,
                TipoAsignatura = asignatura.Tipo.ToString(),
                PeriodoTrimestre = apa?.Periodo ?? 0,
                FechaRegistro = primeraPreseleccion.FechaRegistro,
                Definitiva = false,
                TotalSeccionesAsignatura = secciones.Count,
                Secciones = secciones
            });
        }

        return new ResumenSeleccionResponseDto
        {
            ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id),
            Resumen = resumenAgrupado
        };
    }

    public async Task<AccionSeleccionResponseDto> CancelarSeleccionAsync(int id, int usuarioId)
    {
        var canModify = await _periodoConfigService.CanModifyAsync();
        
        if (!canModify)
        {
            return new AccionSeleccionResponseDto { Success = false, Message = "No se permite modificar la selección en este momento." };
        }

        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null)
        {
            return new AccionSeleccionResponseDto { Success = false, Message = "No hay un periodo activo configurado." };
        }

        // Primero intentar buscar en selecciones
        var seleccion = await _seleccionRepository.GetByIdAsync(id);
        if (seleccion != null && seleccion.IdUsuario == usuarioId)
        {
            // Obtener la asignatura que se quiere eliminar
            var asignaturaAEliminar = seleccion.IdSeccionNavigation.IdAsignatura;

            // Obtener todas las selecciones y preselecciones procesadas del usuario
            var seleccionesAll = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
            var preseleccionesUsuario = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
            var preseleccionesProcesadasAll = preseleccionesUsuario.Where(p => p.Procesada).ToList();

            // Obtener asignaturas del programa para verificar correquisitos
            var usuarioPrograma = await _preseleccionRepository.GetUsuarioProgramaAsync(usuarioId);
            if (usuarioPrograma != null)
            {
                var asignaturasPrograma = await _preseleccionRepository.GetAsignaturasByProgramaAsync(usuarioPrograma.IdProgramaAcademico);

                // Verificar si alguna asignatura seleccionada tiene como correquisito la que se quiere eliminar
                var asignaturasSeleccionadasIds = seleccionesAll.Select(s => s.IdSeccionNavigation.IdAsignatura)
                    .Concat(preseleccionesProcesadasAll.Select(p => p.IdSeccionNavigation.IdAsignatura))
                    .Where(a => a != asignaturaAEliminar)
                    .ToHashSet();

                var asignaturasDependientes = asignaturasPrograma
                    .Where(a => a.Corequisito == asignaturaAEliminar && asignaturasSeleccionadasIds.Contains(a.IdAsignatura))
                    .Select(a => a.IdAsignatura)
                    .ToList();

                if (asignaturasDependientes.Any())
                {
                    return new AccionSeleccionResponseDto
                    {
                        Success = false,
                        Message = $"No puedes eliminar esta asignatura porque es correquisito de: {string.Join(", ", asignaturasDependientes)}. Elimina primero las asignaturas dependientes."
                    };
                }
            }

            // Si viene de preselección, eliminar también la preselección
            if (seleccion.VieneDePreseleccion)
            {
                var preselecciones = preseleccionesUsuario;
                var preseleccion = preselecciones.FirstOrDefault(p => p.IdSeccion == seleccion.IdSeccion);
                
                if (preseleccion != null)
                {
                    await _preseleccionRepository.DeleteAsync(preseleccion);
                }
            }

            await _seleccionRepository.DeleteAsync(seleccion);
            return new AccionSeleccionResponseDto
            {
                Success = true,
                Message = "Asignatura cancelada de la selección.",
                ResumenCarga = await GetResumenCargaAsync(usuarioId, seleccion.IdPeriodo)
            };
        }

        // Si no se encuentra, buscar en preselecciones procesadas
        var preseleccionesAll = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var preseleccionProcesada = preseleccionesAll.FirstOrDefault(p => p.Id == id && p.Procesada);
        
        if (preseleccionProcesada != null)
        {
            // Desmarcar como procesada para que vuelva a estado de preselección
            preseleccionProcesada.Procesada = false;
            await _preseleccionRepository.UpdateAsync(preseleccionProcesada);
            
            return new AccionSeleccionResponseDto
            {
                Success = true,
                Message = "Asignatura preseleccionada removida de la selección.",
                ResumenCarga = await GetResumenCargaAsync(usuarioId, activePeriod.Id)
            };
        }

        return new AccionSeleccionResponseDto { Success = false, Message = "No se pudo cancelar. El registro no existe o no te pertenece." };
    }

    public async Task<bool> ConfirmarPreseleccionAsync(int usuarioId)
    {
        var fase = await _periodoConfigService.GetCurrentFaseAsync();
        if (fase != PeriodoFase.Seleccion) return false;

        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null) return false;

        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var activas = preselecciones.Where(p => p.Activa && !p.Procesada).ToList();

        if (!activas.Any()) return false;

        foreach (var pre in activas)
        {
            var seleccion = new Seleccion
            {
                IdUsuario = usuarioId,
                IdSeccion = pre.IdSeccion,
                IdPeriodo = activePeriod.Id,
                FechaRegistro = DateTime.Now,
                FechaConfirmacion = null,
                EstatusAcademico = SeleccionEstatus.Inscrito,
                VieneDePreseleccion = true,
                Activa = true,
                Definitiva = false
            };

            await _seleccionRepository.AddAsync(seleccion);
            
            pre.Procesada = true;
            await _preseleccionRepository.UpdateAsync(pre);
        }

        return true;
    }

    public async Task<AccionSeleccionResponseDto> FinalizarSeleccionAsync(int usuarioId)
    {
        var fase = await _periodoConfigService.GetCurrentFaseAsync();
        if (fase != PeriodoFase.Seleccion)
        {
            return new AccionSeleccionResponseDto
            {
                Success = false,
                Message = "Solo puedes finalizar la selección durante la fase de Selección."
            };
        }

        var activePeriod = await _periodoConfigService.GetActivePeriodAsync();
        if (activePeriod == null)
        {
            return new AccionSeleccionResponseDto
            {
                Success = false,
                Message = "No hay un periodo activo configurado."
            };
        }

        // Convertir preselecciones procesadas a selecciones definitivas
        var preselecciones = await _preseleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var seccionesSeleccionadas = selecciones.Select(s => s.IdSeccion).ToHashSet();
        
        var preseleccionesProcesadas = preselecciones
            .Where(p => p.Activa && p.Procesada && !seccionesSeleccionadas.Contains(p.IdSeccion))
            .ToList();

        int totalConvertidas = 0;

        // Convertir preselecciones procesadas en selecciones definitivas
        foreach (var pre in preseleccionesProcesadas)
        {
            var seleccion = new Seleccion
            {
                IdUsuario = usuarioId,
                IdSeccion = pre.IdSeccion,
                IdPeriodo = activePeriod.Id,
                FechaRegistro = DateTime.Now,
                FechaConfirmacion = DateTime.Now,
                EstatusAcademico = SeleccionEstatus.Inscrito,
                VieneDePreseleccion = true,
                Activa = true,
                Definitiva = true
            };

            await _seleccionRepository.AddAsync(seleccion);
            totalConvertidas++;
        }

        // Marcar selecciones existentes como definitivas
        selecciones = await _seleccionRepository.GetByUsuarioAndPeriodoAsync(usuarioId, activePeriod.Id);
        var activas = selecciones.Where(s => s.Activa && !s.Definitiva).ToList();

        foreach (var seleccion in activas)
        {
            seleccion.Definitiva = true;
            seleccion.FechaConfirmacion = DateTime.Now;
            await _seleccionRepository.UpdateAsync(seleccion);
        }

        int totalFinalizado = activas.Count + totalConvertidas;

        if (totalFinalizado == 0)
        {
            return new AccionSeleccionResponseDto
            {
                Success = false,
                Message = "No tienes asignaturas seleccionadas activas para finalizar."
            };
        }

        return new AccionSeleccionResponseDto
        {
            Success = true,
            Message = $"Selección finalizada exitosamente. {totalFinalizado} asignatura(s) confirmada(s) de forma definitiva.",
            CantidadAsignaturas = totalFinalizado
        };
    }
}
