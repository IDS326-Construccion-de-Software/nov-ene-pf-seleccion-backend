using SistemaAcademico.Authentication.Core.Entities;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface IRefreshTokenRepository
    {
        /// <summary>
        /// Obtiene un refresh token válido por su valor.
        /// </summary>
        Task<RefreshToken?> GetByTokenAsync(string token);

        /// <summary>
        /// Guarda un nuevo refresh token.
        /// </summary>
        Task AddAsync(RefreshToken refreshToken);

        /// <summary>
        /// Actualiza un refresh token existente (revocar).
        /// </summary>
        Task UpdateAsync(RefreshToken refreshToken);
    }
}
