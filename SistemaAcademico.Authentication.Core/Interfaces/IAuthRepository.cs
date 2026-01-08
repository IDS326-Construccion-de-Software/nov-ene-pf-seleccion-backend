using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface IAuthRepository
    {
        Task<bool> ExisteCorreoAsync(string correo);
        Task<int> CrearUsuarioAsync(Usuario usuario);
        Task<Usuario?> ObtenerUsuarioLoginAsync(string corre);
        Task GuardarRefreshTokenAsync(UsuarioRefreshToken refreshToken);

    }
}
