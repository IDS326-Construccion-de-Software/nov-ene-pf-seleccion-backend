using System.Threading.Tasks;
using SistemaAcademico.Modules.Support.Core.Entities;

namespace SistemaAcademico.Modules.Support.Core.Interfaces
{
    public interface ISupportRepository
    {
        Task AddAsync(SupportTicket ticket);
    }
}