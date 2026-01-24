using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Modules.Support.Core.Entities;
using SistemaAcademico.Modules.Support.Infrastructure.Persistence.Configurations;

namespace SistemaAcademico.Modules.Support.Infrastructure.Persistence
{
    public class SupportDbContext : DbContext
    {
        public SupportDbContext(DbContextOptions<SupportDbContext> options) : base(options) { }

        public DbSet<SupportTicket> SupportTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ahora sí encontrará SupportTicketConfiguration correctamente
            modelBuilder.ApplyConfiguration(new SupportTicketConfiguration());
        }
    }
}