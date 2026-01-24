using System.Threading.Tasks;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Payment.Core.Interfaces
{
    public interface IFacturaRepository
    {
        Task Create(Factura factura);
        Task<Factura?> GetById(int id);
    }
}
