using SistemaAcademico.Authentication.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Core.Interfaces
{
    public interface IAuthService
    {
        Task<int> CrearUsuarioAsync(CreateUserDto dto);
        Task<LoginResponse> LoginAsync(LoginRequest request);
        //Task<LoginResponse> RefreshTokenAsync(RefreshTokenRequest request);
        //Task LogoutAsync(string refreshToken);
    }
}
