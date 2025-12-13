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
                .FirstOrDefaultAsync(rt => rt.Token == token);
        }

        public async Task AddAsync(RefreshToken refreshToken)
        {
            _context.Set<RefreshToken>().Add(refreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(RefreshToken refreshToken)
        {
            _context.Set<RefreshToken>().Update(refreshToken);
            await _context.SaveChangesAsync();
        }
    }
}
