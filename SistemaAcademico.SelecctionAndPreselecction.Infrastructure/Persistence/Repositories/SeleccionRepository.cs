using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

namespace SistemaAcademico.SelecctionAndPreselecction.Infrastructure.Persistence.Repositories;

public class SeleccionRepository : ISeleccionRepository
{
    private readonly SistemaAcademicoContext _db;

    public SeleccionRepository(SistemaAcademicoContext context)
    {
        _db = context;
    }

    public async Task AddAsync(Seleccion seleccion)
    {
        await _db.Seleccions.AddAsync(seleccion);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Seleccion>> GetByUsuarioAndPeriodoAsync(int usuarioId, int periodoId)
    {
        return await _db.Seleccions
            .Include(s => s.IdSeccionNavigation)
                .ThenInclude(s => s.IdAsignaturaNavigation)
            .Include(s => s.IdSeccionNavigation)
                .ThenInclude(s => s.IdProfesorNavigation)
                    .ThenInclude(p => p.IdUsuarioNavigation)
            .Include(s => s.IdSeccionNavigation)
                .ThenInclude(s => s.SeccionHorarios)
                    .ThenInclude(h => h.IdAulaNavigation)
                        .ThenInclude(a => a.IdEdificioNavigation)
            .Where(s => s.IdUsuario == usuarioId && s.IdPeriodo == periodoId)
            .ToListAsync();
    }

    public async Task<Seleccion?> GetByIdAsync(int id)
    {
        return await _db.Seleccions
            .Include(s => s.IdSeccionNavigation)
                .ThenInclude(sec => sec.IdAsignaturaNavigation)
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task UpdateAsync(Seleccion seleccion)
    {
        _db.Seleccions.Update(seleccion);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(Seleccion seleccion)
    {
        _db.Seleccions.Remove(seleccion);
        await _db.SaveChangesAsync();
    }
}
