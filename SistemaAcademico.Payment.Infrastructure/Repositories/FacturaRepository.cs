using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Payment.Core.Interfaces;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Payment.Infrastructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        private readonly SistemaAcademicoContext _context;

        public FacturaRepository(SistemaAcademicoContext context)
        {
            _context = context;
        }

        public async Task Create(Factura factura)
        {
            await _context.Facturas.AddAsync(factura);
            await _context.SaveChangesAsync();
        }

        public async Task<Factura?> GetById(int id)
        {
            return await _context.Facturas
                .Include(f => f.DetalleFacturas)
                .FirstOrDefaultAsync(f => f.IdFactura == id);
        }
    }
}
