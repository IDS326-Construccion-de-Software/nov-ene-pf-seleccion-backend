using System;
using System.Collections.Generic;
using SistemaAcademico.Persistence.Models;
using BCrypt.Net;

namespace SistemaAcademico.Persistence.Data;

public static class IdentityAccessUsersData
{
    private static readonly string PasswordHash = BCrypt.Net.BCrypt.HashPassword("Candado6947!");

    public static List<Rol> GetRols() => new()
    {
        new Rol { RolId = 1, Descripcion = "Profesor" },
        new Rol { RolId = 2, Descripcion = "Estudiante" },
        new Rol { RolId = 3, Descripcion = "Administrador" }
    };

    public static List<Usuario> GetUsuarios() => new()
    {
        new Usuario
        {
            IdUsuario = 1077547,
            Nombre = "Juan",
            Apellido = "Perez",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 123",
            Telefono = "8091234567",
            CorreoPersonal = "juan.perez@gmail.com",
            CorreoInstitucional = "j.perez@institucional.edu.do",
            FechaIngreso = DateTime.Now,
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077546,
            Nombre = "Maria",
            Apellido = "Gomez",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Winston Churchill",
            Telefono = "8095551234",
            CorreoPersonal = "maria.gomez@gmail.com",
            CorreoInstitucional = "m.gomez@institucional.edu.do",
            FechaIngreso = new DateTime(2024, 1, 10),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 2
        },
        new Usuario
        {
            IdUsuario = 1077548,
            Nombre = "Carlos",
            Apellido = "Rodriguez",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 456",
            Telefono = "8091234568",
            CorreoPersonal = "carlos.rodriguez@gmail.com",
            CorreoInstitucional = "c.rodriguez@institucional.edu.do",
            FechaIngreso = new DateTime(2023, 6, 15),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077549,
            Nombre = "Ana",
            Apellido = "Martinez",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Libertad",
            Telefono = "8091234569",
            CorreoPersonal = "ana.martinez@gmail.com",
            CorreoInstitucional = "a.martinez@institucional.edu.do",
            FechaIngreso = new DateTime(2023, 9, 20),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077550,
            Nombre = "Roberto",
            Apellido = "Hernandez",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 789",
            Telefono = "8091234570",
            CorreoPersonal = "roberto.hernandez@gmail.com",
            CorreoInstitucional = "r.hernandez@institucional.edu.do",
            FechaIngreso = new DateTime(2022, 1, 10),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077551,
            Nombre = "Sofia",
            Apellido = "Lopez",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Principal",
            Telefono = "8091234571",
            CorreoPersonal = "sofia.lopez@gmail.com",
            CorreoInstitucional = "s.lopez@institucional.edu.do",
            FechaIngreso = new DateTime(2021, 8, 5),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077552,
            Nombre = "Diego",
            Apellido = "Sanchez",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 321",
            Telefono = "8091234572",
            CorreoPersonal = "diego.sanchez@gmail.com",
            CorreoInstitucional = "d.sanchez@institucional.edu.do",
            FechaIngreso = new DateTime(2020, 3, 15),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077553,
            Nombre = "Luis",
            Apellido = "Ramirez",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 555",
            Telefono = "8091234573",
            CorreoPersonal = "luis.ramirez@gmail.com",
            CorreoInstitucional = "l.ramirez@institucional.edu.do",
            FechaIngreso = new DateTime(2023, 2, 20),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077554,
            Nombre = "Patricia",
            Apellido = "Torres",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Independencia",
            Telefono = "8091234574",
            CorreoPersonal = "patricia.torres@gmail.com",
            CorreoInstitucional = "p.torres@institucional.edu.do",
            FechaIngreso = new DateTime(2019, 7, 1),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077555,
            Nombre = "Miguel",
            Apellido = "Castro",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 666",
            Telefono = "8091234575",
            CorreoPersonal = "miguel.castro@gmail.com",
            CorreoInstitucional = "m.castro@institucional.edu.do",
            FechaIngreso = new DateTime(2022, 11, 10),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077556,
            Nombre = "Carmen",
            Apellido = "Jimenez",
            Nacionalidad = "Dominicana",
            Direccion = "Av. 27 de Febrero",
            Telefono = "8091234576",
            CorreoPersonal = "carmen.jimenez@gmail.com",
            CorreoInstitucional = "c.jimenez@institucional.edu.do",
            FechaIngreso = new DateTime(2021, 4, 25),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077557,
            Nombre = "Fernando",
            Apellido = "Vega",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 777",
            Telefono = "8091234577",
            CorreoPersonal = "fernando.vega@gmail.com",
            CorreoInstitucional = "f.vega@institucional.edu.do",
            FechaIngreso = new DateTime(2023, 5, 12),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077558,
            Nombre = "Alejandra",
            Apellido = "Morales",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Abraham Lincoln",
            Telefono = "8091234578",
            CorreoPersonal = "alejandra.morales@gmail.com",
            CorreoInstitucional = "a.morales@institucional.edu.do",
            FechaIngreso = new DateTime(2018, 9, 1),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077559,
            Nombre = "Ricardo",
            Apellido = "Medina",
            Nacionalidad = "Dominicana",
            Direccion = "Calle 888",
            Telefono = "8091234579",
            CorreoPersonal = "ricardo.medina@gmail.com",
            CorreoInstitucional = "r.medina@institucional.edu.do",
            FechaIngreso = new DateTime(2022, 6, 18),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        },
        new Usuario
        {
            IdUsuario = 1077560,
            Nombre = "Laura",
            Apellido = "Diaz",
            Nacionalidad = "Dominicana",
            Direccion = "Av. Tiradentes",
            Telefono = "8091234580",
            CorreoPersonal = "laura.diaz@gmail.com",
            CorreoInstitucional = "l.diaz@institucional.edu.do",
            FechaIngreso = new DateTime(2020, 1, 8),
            ClaveHash = PasswordHash,
            CambioClaveSolicitado = false,
            IdRol = 1
        }
    };

    public static List<UsuarioRol> GetUsuarioRoles() => new()
    {
        new UsuarioRol
        {
            IdUsuario = 1077547,
            IdRol = 1, // Juan es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077546,
            IdRol = 2, // Maria es Estudiante
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077548,
            IdRol = 1, // Carlos es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077549,
            IdRol = 1, // Ana es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077550,
            IdRol = 1, // Roberto es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077551,
            IdRol = 1, // Sofia es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077552,
            IdRol = 1, // Diego es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077553,
            IdRol = 1, // Luis es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077554,
            IdRol = 1, // Patricia es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077555,
            IdRol = 1, // Miguel es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077556,
            IdRol = 1, // Carmen es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077557,
            IdRol = 1, // Fernando es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077558,
            IdRol = 1, // Alejandra es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077559,
            IdRol = 1, // Ricardo es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioRol
        {
            IdUsuario = 1077560,
            IdRol = 1, // Laura es Profesor
            Estatus = EstatusUsuario.Activo.ToString()
        }
    };

    public static List<UsuarioAreaAcademica> GetUsuarioAreaAcademicas() => new()
    {
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077547,
            IdAreaAcademica = "ING", // Juan en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077546,
            IdAreaAcademica = "ING", // Maria en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077548,
            IdAreaAcademica = "ING", // Carlos en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077549,
            IdAreaAcademica = "ING", // Ana en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077550,
            IdAreaAcademica = "ING", // Roberto en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077551,
            IdAreaAcademica = "ING", // Sofia en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077552,
            IdAreaAcademica = "ING", // Diego en Ingeniería
            Estatus = EstatusUsuario.Activo.ToString()        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077553,
            IdAreaAcademica = "IDS", // Luis en Ingeniería de Software
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077554,
            IdAreaAcademica = "AHC", // Patricia en Comunicación
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077555,
            IdAreaAcademica = "ICS", // Miguel en Ciberseguridad
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077556,
            IdAreaAcademica = "CBM", // Carmen en Matemáticas
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077557,
            IdAreaAcademica = "ADM", // Fernando en Administración
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077558,
            IdAreaAcademica = "CSH", // Alejandra en Humanidades
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077559,
            IdAreaAcademica = "INS", // Ricardo en Computación
            Estatus = EstatusUsuario.Activo.ToString()
        },
        new UsuarioAreaAcademica
        {
            IdUsuario = 1077560,
            IdAreaAcademica = "SHI", // Laura en Inglés
            Estatus = EstatusUsuario.Activo.ToString()        }
    };

}
