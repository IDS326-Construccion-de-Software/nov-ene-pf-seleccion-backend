using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAcademico.Modules.Support.Core.Entities;
namespace SistemaAcademico.Modules.Support.Infrastructure.Persistence.Configurations
{
    public class SupportTicketConfiguration : IEntityTypeConfiguration<SupportTicket>
    {
        public void Configure(EntityTypeBuilder<SupportTicket> builder)
        {
            // Mapeo explícito para asegurar que el Enum se guarde como número (int)
            // en la columna 'motivoSolicitud'
            builder.Property(x => x.Reason)
                    .HasConversion<int>()
                    .HasColumnName("motivoSolicitud"); // Refuerzo del nombre en español
        }
    }
}