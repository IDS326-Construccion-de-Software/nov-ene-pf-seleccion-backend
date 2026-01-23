using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Payment.Core.Interfaces
{
    public interface ICuentaPorPagarRepository
    {
        Task<List<CuentaPorPagar>> GetPendingByStudentId(int studentId);
        Task<CuentaPorPagar?> GetById(int id);
        Task Update(CuentaPorPagar cuentaPorPagar);
    }
}
