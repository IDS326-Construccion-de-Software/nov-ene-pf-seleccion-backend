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

        public async Task<UsuarioRefreshToken?> ObtenerRefreshTokenAsync(string token)
        {
            return await _context.Set<UsuarioRefreshToken>()
                .FirstOrDefaultAsync(t => t.Token == token);
        }

        public async Task<Usuario?> ObtenerUsuarioPorIdAsync(int idUsuario)
        {
            return await _context.Usuarios
                .Include(u => u.IdRolNavigation)
                .Include(u => u.UsuarioRols)
                    .ThenInclude(ur => ur.IdRolNavigation)
                .Include(u => u.UsuarioProgramaAcademicos)
                    .ThenInclude(upa => upa.IdProgramaAcademicoNavigation)
                        .ThenInclude(pa => pa.IdCarreraNavigation)
                            .ThenInclude(c => c.IdAreaAcademicaNavigation)
                .Include(u => u.Profesor)
                .Include(u => u.UsuarioAreaAcademicas)
                    .ThenInclude(uaa => uaa.IdAreaAcademicaNavigation)
                .FirstOrDefaultAsync(u => u.IdUsuario == idUsuario);
        }
        //public async Task<UsuarioRefreshToken?> ObtenerRefreshTokenAsync(string token)
        //{
        //    var refreshToken = await _context.Set<UsuarioRefreshToken>()
        //        .FirstOrDefaultAsync(t => t.Token == token);

        //    if (refreshToken == null) return null;

        //    //buscar el usuario
        //    var usuario = await _context.Usuarios
        //        .Include(u => u.UsuarioRols)
        //        .ThenInclude(ur => ur.IdRolNavigation)
        //        .FirstOrDefaultAsync(u => u.IdUsuario == refreshToken.IdUsuario);



        //}

        public async Task EliminarRefreshTokenAsync(UsuarioRefreshToken token)
        {
            _context.Set<UsuarioRefreshToken>().Remove(token);
            await _context.SaveChangesAsync();
        }

        public async Task ActualizarUsuarioAsync(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task RevocarTodosLosTokensUsuarioAsync(int idUsuario)
        {
            // Buscamos todos los tokens de ese usuario
            var tokens = _context.Set<UsuarioRefreshToken>()
                .Where(t => t.IdUsuario == idUsuario);

            // Los borramos todos
            _context.Set<UsuarioRefreshToken>().RemoveRange(tokens);
            await _context.SaveChangesAsync();
        }
    }
}
