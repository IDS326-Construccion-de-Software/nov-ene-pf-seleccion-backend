using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

namespace SistemaAcademico.SelecctionAndPreselecction.Infrastructure.Persistence.Repositories;

public class PreseleccionRepository : IPreseleccionRepository
{
    private readonly SistemaAcademicoContext _db;

    public PreseleccionRepository(SistemaAcademicoContext context)
    {
        _db = context;
    }

    public async Task<UsuarioProgramaAcademico?> GetUsuarioProgramaAsync(int usuarioId)
    {
        return await _db.UsuarioProgramaAcademicos
            .FirstOrDefaultAsync(up => up.IdUsuario == usuarioId);
    }

    public async Task<IEnumerable<AsignaturaProgramaAcademico>> GetAsignaturasByProgramaAsync(int programaId)
    {
        return await _db.AsignaturaProgramaAcademicos
            .Include(apa => apa.IdAsignaturaNavigation)
            .Where(apa => apa.IdProgramaAcademico == programaId)
            .ToListAsync();
    }

    public async Task<IEnumerable<HistorialAcademico>> GetHistorialByUsuarioAsync(int usuarioId)
    {
        return await _db.HistorialAcademicos
            .Where(h => h.IdUsuario == usuarioId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Seccion>> GetSeccionesByPeriodoAsync(string periodoCodigo)
    {
        return await _db.Seccions
            .Include(s => s.IdAsignaturaNavigation)
            .Include(s => s.IdProfesorNavigation)
                .ThenInclude(p => p.IdUsuarioNavigation)
            .Include(s => s.SeccionHorarios)
                .ThenInclude(sh => sh.IdAulaNavigation)
                    .ThenInclude(a => a.IdEdificioNavigation)
            .Where(s => s.PeriodoAcademico == periodoCodigo)
            .ToListAsync();
    }

    public async Task<IEnumerable<Seccion>> GetSeccionesByIdsAsync(List<int> seccionIds)
    {
        return await _db.Seccions
            .Include(s => s.IdAsignaturaNavigation)
            .Include(s => s.SeccionHorarios)
                .ThenInclude(sh => sh.IdAulaNavigation)
                    .ThenInclude(a => a.IdEdificioNavigation)
            .Where(s => seccionIds.Contains(s.SeccionId))
            .ToListAsync();
    }

    public async Task<IEnumerable<Preseleccion>> GetByUsuarioAndPeriodoAsync(int usuarioId, int periodoId)
    {
        return await _db.Preseleccions
            .Include(p => p.IdSeccionNavigation)
                .ThenInclude(s => s.IdAsignaturaNavigation)
            .Include(p => p.IdSeccionNavigation)
                .ThenInclude(s => s.IdProfesorNavigation)
                    .ThenInclude(pr => pr.IdUsuarioNavigation)
            .Include(p => p.IdSeccionNavigation)
                .ThenInclude(s => s.SeccionHorarios)
                    .ThenInclude(sh => sh.IdAulaNavigation)
                        .ThenInclude(a => a.IdEdificioNavigation)
            .Where(p => p.IdUsuario == usuarioId && p.IdPeriodo == periodoId && p.Activa)
            .ToListAsync();
    }

    public async Task<IEnumerable<Preseleccion>> GetByUsuarioAndPeriodoAllAsync(int usuarioId, int periodoId)
    {
        return await _db.Preseleccions
            .Where(p => p.IdUsuario == usuarioId && p.IdPeriodo == periodoId)
            .ToListAsync();
    }

    public async Task<Preseleccion?> GetByIdAsync(int id)
    {
        return await _db.Preseleccions
            .Include(p => p.IdSeccionNavigation)
                .ThenInclude(s => s.IdAsignaturaNavigation)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task AddAsync(Preseleccion preseleccion)
    {
        await _db.Preseleccions.AddAsync(preseleccion);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Preseleccion preseleccion)
    {
        _db.Preseleccions.Update(preseleccion);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Preseleccion preseleccion)
    {
        _db.Preseleccions.Remove(preseleccion);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateSeccionAsync(Seccion seccion)
    {
        _db.Seccions.Update(seccion);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteUnprocessedPreselectionsByPeriodAsync(int periodoId)
    {
        var unprocessedPreselections = await _db.Preseleccions
            .Include(p => p.IdSeccionNavigation)
            .Where(p => p.IdPeriodo == periodoId && p.Activa && !p.Procesada)
            .ToListAsync();

        if (unprocessedPreselections.Any())
        {
            // Restaurar cupos de las secciones
            foreach (var preseleccion in unprocessedPreselections)
            {
                if (preseleccion.IdSeccionNavigation != null)
                {
                    preseleccion.IdSeccionNavigation.CupoDisponible++;
                }
            }

            _db.Preseleccions.RemoveRange(unprocessedPreselections);
            await _db.SaveChangesAsync();
        }
    }
}
