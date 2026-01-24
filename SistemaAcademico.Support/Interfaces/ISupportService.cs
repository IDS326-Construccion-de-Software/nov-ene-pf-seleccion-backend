using System.Threading.Tasks;
using SistemaAcademico.Modules.Support.Core.DTOs;

namespace SistemaAcademico.Modules.Support.Core.Interfaces
{
    public interface ISupportService
    {
        Task<int> CreateTicketAsync(string userId, CreateSupportTicketDto dto);
    }
}