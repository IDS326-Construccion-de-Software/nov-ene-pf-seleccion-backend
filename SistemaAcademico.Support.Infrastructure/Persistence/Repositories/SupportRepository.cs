using System.Threading.Tasks;
using SistemaAcademico.Modules.Support.Core.Entities;
using SistemaAcademico.Modules.Support.Core.Interfaces;

namespace SistemaAcademico.Modules.Support.Infrastructure.Persistence.Repositories
{
    public class SupportRepository : ISupportRepository
    {
        // Usamos el SupportDbContext local
        private readonly SupportDbContext _context;

        public SupportRepository(SupportDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SupportTicket ticket)
        {
            await _context.SupportTickets.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }
    }
}