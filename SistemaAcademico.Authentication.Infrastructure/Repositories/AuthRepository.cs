using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Infrastructure.Repositories
{
    public class AuthRepository: IAuthRepository
    {
        private readonly SistemaAcademicoContext _context;

        public AuthRepository(SistemaAcademicoContext context)
        {
            _context = context;
        }

        public async Task<bool> ExisteCorreoAsync(string correo)
        {
            return await _context.Usuarios
                .AnyAsync(u => u.CorreoInstitucional == correo);
        }

        public async Task<int> CrearUsuarioAsync(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            await _context.SaveChangesAsync();
            return usuario.IdUsuario;
        }

        public async Task<Usuario?> ObtenerUsuarioLoginAsync(string correo)
        {
            return await _context.Usuarios
                .Include(u => u.UsuarioRols)
                .ThenInclude(ur => ur.IdRolNavigation)
                .FirstOrDefaultAsync(u => u.CorreoInstitucional == correo);
        }

        public async Task GuardarRefreshTokenAsync(UsuarioRefreshToken token)
        {
            await _context.Set<UsuarioRefreshToken>().AddAsync(token);
            await _context.SaveChangesAsync();
        }

    }
}
