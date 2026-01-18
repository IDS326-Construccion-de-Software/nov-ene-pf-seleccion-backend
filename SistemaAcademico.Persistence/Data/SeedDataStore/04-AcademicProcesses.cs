using System;
using System.Collections.Generic;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Persistence.Data;

public static class AcademicProcessesData
{
    public static List<PeriodoConfig> GetPeriodoConfigs() => new()
    {
        new PeriodoConfig
        {
            Id = 1,
            Nombre = "Primer Trimestre 2026",
            Codigo = "2026-01",
            PreseleccionInicio = new DateTime(2026, 1, 6),
            PreseleccionFin = new DateTime(2026, 1, 20),
            SeleccionInicio = new DateTime(2026, 1, 21),
            SeleccionFin = new DateTime(2026, 1, 30),
            RetiroInicio = new DateTime(2026, 2, 1),
            RetiroFin = new DateTime(2026, 3, 15),
            PermitirModificarEnSeleccion = true
        }
    };

    public static List<Preseleccion> GetPreseleccions() => new()
    {
        // // Maria Gomez (Estudiante)
        // new Preseleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 1,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // new Preseleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 2,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // // Roberto Hernandez (Estudiante)
        // new Preseleccion
        // {
        //     IdUsuario = 1077550,
        //     IdSeccion = 3,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // new Preseleccion
        // {
        //     IdUsuario = 1077550,
        //     IdSeccion = 4,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // // Sofia Lopez (Estudiante)
        // new Preseleccion
        // {
        //     IdUsuario = 1077551,
        //     IdSeccion = 7,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // new Preseleccion
        // {
        //     IdUsuario = 1077551,
        //     IdSeccion = 8,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // // Diego Sanchez (Estudiante)
        // new Preseleccion
        // {
        //     IdUsuario = 1077552,
        //     IdSeccion = 11,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // },
        // new Preseleccion
        // {
        //     IdUsuario = 1077552,
        //     IdSeccion = 12,
        //     IdPeriodo = 1,
        //     FechaRegistro = DateTime.Now,
        //     Procesada = true,
        //     Activa = false
        // }
    };

    public static List<Seleccion> GetSeleccions() => new()
    {
        // // Maria Gomez (Estudiante)
        // new Seleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 1,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = true,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 3,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = true,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 5,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077546,
        //     IdSeccion = 7,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // // Roberto Hernandez (Estudiante)
        // new Seleccion
        // {
        //     IdUsuario = 1077550,
        //     IdSeccion = 3,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = true,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077550,
        //     IdSeccion = 9,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077550,
        //     IdSeccion = 11,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // // Sofia Lopez (Estudiante)
        // new Seleccion
        // {
        //     IdUsuario = 1077551,
        //     IdSeccion = 7,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = true,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077551,
        //     IdSeccion = 13,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077551,
        //     IdSeccion = 15,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // // Diego Sanchez (Estudiante)
        // new Seleccion
        // {
        //     IdUsuario = 1077552,
        //     IdSeccion = 11,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = true,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077552,
        //     IdSeccion = 17,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // },
        // new Seleccion
        // {
        //     IdUsuario = 1077552,
        //     IdSeccion = 19,
        //     IdPeriodo = 1,
        //     VieneDePreseleccion = false,
        //     FechaConfirmacion = DateTime.Now,
        //     EstatusAcademico = SeleccionEstatus.Inscrito
        // }
    };

    public static List<UsuarioProgramaAcademico> GetUsuarioProgramaAcademicos() => new()
    {
        new UsuarioProgramaAcademico
        {
            IdUsuario = 1077546, // Maria Gomez
            IdProgramaAcademico = 1, // IDS 2020
            FechaInscripcion = new DateTime(2024, 1, 10),
            Estatus = "Activo",
            Permanencia = 25,
            TrimestreActual = 1
        },
    };

    public static List<HistorialAcademico> GetHistorialAcademicos() => new()
    {
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077546,
        //     IdAsignatura = "AHO102", // Orientación
        //     IdPeriodo = 1,
        //     Calificacion = 95,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077546,
        //     IdAsignatura = "CBA1X3", // Vida en el medio ambiente
        //     IdPeriodo = 1,
        //     Calificacion = 88,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077550,
        //     IdAsignatura = "CBM101", // Algebra
        //     IdPeriodo = 1,
        //     Calificacion = 92,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077550,
        //     IdAsignatura = "AHC109", // Redacción
        //     IdPeriodo = 1,
        //     Calificacion = 85,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077551,
        //     IdAsignatura = "CSH112", // Ciudadanía y Ética
        //     IdPeriodo = 1,
        //     Calificacion = 89,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077551,
        //     IdAsignatura = "SHI103", // Inglés 01
        //     IdPeriodo = 1,
        //     Calificacion = 78,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077552,
        //     IdAsignatura = "IDS207", // Introducción a Ingeniería de Software
        //     IdPeriodo = 1,
        //     Calificacion = 94,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // },
        // new HistorialAcademico
        // {
        //     IdUsuario = 1077552,
        //     IdAsignatura = "EAA1X1", // Electivas I
        //     IdPeriodo = 1,
        //     Calificacion = 87,
        //     Estatus = HistorialEstatus.Aprobado,
        //     FechaRegistro = DateTime.Now.AddMonths(-6)
        // }
    };
}
