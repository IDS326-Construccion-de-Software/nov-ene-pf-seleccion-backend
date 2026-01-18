using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;

public interface ISeleccionRepository
{
    Task AddAsync(Seleccion seleccion);
    Task<IEnumerable<Seleccion>> GetByUsuarioAndPeriodoAsync(int usuarioId, int periodoId);
    Task<Seleccion?> GetByIdAsync(int id);
    Task UpdateAsync(Seleccion seleccion);
    Task DeleteAsync(Seleccion seleccion);
}
