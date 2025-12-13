using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Authentication.Core.Entities;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Authentication.Infrastructure.Persistence.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly SistemaAcademicoContext _context;

        public RefreshTokenRepository(SistemaAcademicoContext context)
        {
            _context = context;
        }

        public async Task<RefreshToken?> GetByTokenAsync(string token)
        {
            return await _context.Set<RefreshToken>()
                .FirstOrDefaultAsync(rt => rt.Token == token && !rt.Revocado);
        }

        public async Task RevokeAsync(RefreshToken refreshToken)
        {
            refreshToken.Revocado = true;
            await _context.SaveChangesAsync();
        }
    }
}
