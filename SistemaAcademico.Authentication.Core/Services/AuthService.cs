using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Authentication.Core.DTOs;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.Persistence;

namespace SistemaAcademico.Authentication.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _repository; 

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CrearUsuarioAsync(CreateUserDto dto)
        {
            bool existe = await _repository.ExisteCorreoAsync(dto.CorreoInstitucional);

            if (existe)
                throw new Exception($"El usuario {dto.CorreoInstitucional} ya existe.");

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var nuevoUsuario = new Usuario
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Nacionalidad = dto.Nacionalidad,
                Direccion = dto.Direccion,
                Telefono = dto.Telefono,
                CorreoPersonal = dto.CorreoPersonal,
                CorreoInstitucional = dto.CorreoInstitucional,

                FechaIngreso = DateOnly.FromDateTime(DateTime.Now),

                ClaveHash = passwordHash,

                IdRol = dto.IdRol
            };

            return await _repository.CrearUsuarioAsync(nuevoUsuario);
        }
    }
}
