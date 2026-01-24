using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Payment.Core.Interfaces;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Payment.Infrastructure.Repositories
{
    public class CuentaPorPagarRepository : ICuentaPorPagarRepository
    {
        private readonly SistemaAcademicoContext _context;

        public CuentaPorPagarRepository(SistemaAcademicoContext context)
        {
            _context = context;
        }

        public async Task<List<CuentaPorPagar>> GetPendingByStudentId(int studentId)
        {
            return await _context.CuentaPorPagars
                .Where(c => c.IdUsuario == studentId && !c.Pagada && c.CantidadRestante > 0)
                .OrderBy(c => c.FechaVencimiento)
                .ToListAsync();
        }

        public async Task<CuentaPorPagar?> GetById(int id)
        {
            return await _context.CuentaPorPagars
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task Update(CuentaPorPagar cuentaPorPagar)
        {
            _context.CuentaPorPagars.Update(cuentaPorPagar);
            await _context.SaveChangesAsync();
        }
    }
}
