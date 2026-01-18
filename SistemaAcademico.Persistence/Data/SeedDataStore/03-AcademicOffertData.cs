using System;
using System.Collections.Generic;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Persistence.Data;

public static class AcademicOffertData
{
    public static List<Edificio> GetEdificios() => new()
    {
        new Edificio
        {
            IdEdificio = 1,
            Nombre = "Ercilia Pepín",
            Nomenclatura = "EP"
        },
        new Edificio
        {
            IdEdificio = 2,
            Nombre = "De Ramón Picazo",
            Nomenclatura = "DP"
        },
        new Edificio
        {
            IdEdificio = 3,
            Nombre = "Osvaldo García de la Concha",
            Nomenclatura = "GC"
        },
        new Edificio
        {
            IdEdificio = 4,
            Nombre = "Eduardo Latorre – Edificio de Postgrado",
            Nomenclatura = "EL"
        },
        new Edificio
        {
            IdEdificio = 5,
            Nombre = "Fernando Defilló",
            Nomenclatura = "FD"
        },
        new Edificio
        {
            IdEdificio = 6,
            Nombre = "Evangelina Rodríguez",
            Nomenclatura = "ER"
        },
        new Edificio
        {
            IdEdificio = 7,
            Nombre = "Pedro Francisco Bonó",
            Nomenclatura = "PB"
        },
        new Edificio
        {
            IdEdificio = 8,
            Nombre = "Ana Mercedes Henríquez",
            Nomenclatura = "AH"
        },
        new Edificio
        {
            IdEdificio = 9,
            Nombre = "Arturo Jiménes Sabater",
            Nomenclatura = "AJ"
        }
    };

    public static List<Aula> GetAulas() => new()
    {
        new Aula
        {
            IdAula = 1,
            Nombre = "Aula GC-201",
            Capacidad = 45,
            IdEdificio = 3
        },
        new Aula
        {
            IdAula = 2,
            Nombre = "Aula GC-202",
            Capacidad = 45,
            IdEdificio = 3
        },
        new Aula
        {
            IdAula = 3,
            Nombre = "Aula GC-203",
            Capacidad = 45,
            IdEdificio = 3
        },
        new Aula
        {
            IdAula = 4,
            Nombre = "LabTI FD-403",
            Capacidad = 45,
            IdEdificio = 5
        },
        new Aula
        {
            IdAula = 5,
            Nombre = "LabTI FD-405",
            Capacidad = 45,
            IdEdificio = 5
        },
        new Aula
        {
            IdAula = 6,
            Nombre = "Aula EP-101",
            Capacidad = 45,
            IdEdificio = 1
        },
        new Aula
        {
            IdAula = 7,
            Nombre = "Aula DP-102",
            Capacidad = 45,
            IdEdificio = 2
        },
        new Aula
        {
            IdAula = 8,
            Nombre = "Aula EL-301",
            Capacidad = 45,
            IdEdificio = 4
        },
        new Aula
        {
            IdAula = 9,
            Nombre = "Aula ER-205",
            Capacidad = 45,
            IdEdificio = 6
        },
        new Aula
        {
            IdAula = 10,
            Nombre = "Aula PB-104",
            Capacidad = 45,
            IdEdificio = 7
        },
        new Aula
        {
            IdAula = 11,
            Nombre = "Aula AH-201",
            Capacidad = 40,
            IdEdificio = 8
        },
        new Aula
        {
            IdAula = 12,
            Nombre = "Aula AH-202",
            Capacidad = 35,
            IdEdificio = 8
        },
        new Aula
        {
            IdAula = 13,
            Nombre = "Aula AJ-101",
            Capacidad = 50,
            IdEdificio = 9
        },
        new Aula
        {
            IdAula = 14,
            Nombre = "Aula AJ-102",
            Capacidad = 45,
            IdEdificio = 9
        },
        new Aula
        {
            IdAula = 15,
            Nombre = "LabTI FD-401",
            Capacidad = 30,
            IdEdificio = 5
        },
        new Aula
        {
            IdAula = 16,
            Nombre = "LabTI FD-402",
            Capacidad = 30,
            IdEdificio = 5
        },
        new Aula
        {
            IdAula = 17,
            Nombre = "Aula GC-204",
            Capacidad = 40,
            IdEdificio = 3
        },
        new Aula
        {
            IdAula = 18,
            Nombre = "Aula GC-301",
            Capacidad = 50,
            IdEdificio = 3
        },
        new Aula
        {
            IdAula = 19,
            Nombre = "Aula EP-102",
            Capacidad = 40,
            IdEdificio = 1
        },
        new Aula
        {
            IdAula = 20,
            Nombre = "Aula EP-201",
            Capacidad = 45,
            IdEdificio = 1
        },
        new Aula
        {
            IdAula = 21,
            Nombre = "Aula DP-201",
            Capacidad = 35,
            IdEdificio = 2
        },
        new Aula
        {
            IdAula = 22,
            Nombre = "Aula EL-302",
            Capacidad = 40,
            IdEdificio = 4
        },
        new Aula
        {
            IdAula = 23,
            Nombre = "Aula ER-301",
            Capacidad = 45,
            IdEdificio = 6
        },
        new Aula
        {
            IdAula = 24,
            Nombre = "Aula PB-201",
            Capacidad = 50,
            IdEdificio = 7
        },
        new Aula
        {
            IdAula = 25,
            Nombre = "Auditorio GC-001",
            Capacidad = 120,
            IdEdificio = 3
        }
    };

    public static List<Profesor> GetProfesors() => new()
    {
        new Profesor
        {
            IdUsuario = 1077547,
            GradoAcademico = "Maestría en Ciencias",
            Especialidad = "Ingeniería de Software",
            FechaContratacion = DateTime.Now,
            Estatus = EstatusProfesor.Activo,
            Bio = "Profesor con 10 años de experiencia."
        },
        new Profesor
        {
            IdUsuario = 1077548,
            GradoAcademico = "Doctorado en Matemáticas",
            Especialidad = "Análisis Matemático",
            FechaContratacion = new DateTime(2023, 6, 15),
            Estatus = EstatusProfesor.Activo,
            Bio = "Profesor especializado en Cálculo y Álgebra."
        },
        new Profesor
        {
            IdUsuario = 1077549,
            GradoAcademico = "Maestría en Educación",
            Especialidad = "Ciencias Naturales",
            FechaContratacion = new DateTime(2023, 9, 20),
            Estatus = EstatusProfesor.Activo,
            Bio = "Profesor con experiencia en ciencias ambientales."
        },
        new Profesor
        {
            IdUsuario = 1077550,
            GradoAcademico = "Doctorado en Ciencias de la Computación",
            Especialidad = "Inteligencia Artificial",
            FechaContratacion = new DateTime(2022, 1, 10),
            Estatus = EstatusProfesor.Activo,
            Bio = "Investigador en Machine Learning y Deep Learning con publicaciones internacionales."
        },
        new Profesor
        {
            IdUsuario = 1077551,
            GradoAcademico = "Maestría en Sistemas de Información",
            Especialidad = "Base de Datos",
            FechaContratacion = new DateTime(2021, 8, 5),
            Estatus = EstatusProfesor.Activo,
            Bio = "Experto en diseño y optimización de bases de datos relacionales y NoSQL."
        },
        new Profesor
        {
            IdUsuario = 1077552,
            GradoAcademico = "Doctorado en Física",
            Especialidad = "Física Aplicada",
            FechaContratacion = new DateTime(2020, 3, 15),
            Estatus = EstatusProfesor.Activo,
            Bio = "Profesor con experiencia en mecánica clásica y termodinámica."
        },
        new Profesor
        {
            IdUsuario = 1077553,
            GradoAcademico = "Maestría en Ingeniería de Software",
            Especialidad = "Desarrollo Web",
            FechaContratacion = new DateTime(2023, 2, 20),
            Estatus = EstatusProfesor.Activo,
            Bio = "Especialista en frameworks modernos: React, Angular y .NET."
        },
        new Profesor
        {
            IdUsuario = 1077554,
            GradoAcademico = "Doctorado en Lingüística",
            Especialidad = "Comunicación y Redacción",
            FechaContratacion = new DateTime(2019, 7, 1),
            Estatus = EstatusProfesor.Activo,
            Bio = "Experto en argumentación lingüística y redacción técnica."
        },
        new Profesor
        {
            IdUsuario = 1077555,
            GradoAcademico = "Maestría en Ciberseguridad",
            Especialidad = "Seguridad Informática",
            FechaContratacion = new DateTime(2022, 11, 10),
            Estatus = EstatusProfesor.Activo,
            Bio = "Certificado en ethical hacking y análisis de vulnerabilidades."
        },
        new Profesor
        {
            IdUsuario = 1077556,
            GradoAcademico = "Doctorado en Matemáticas Aplicadas",
            Especialidad = "Estadística y Probabilidad",
            FechaContratacion = new DateTime(2021, 4, 25),
            Estatus = EstatusProfesor.Activo,
            Bio = "Investigador en modelos estadísticos y análisis de datos."
        },
        new Profesor
        {
            IdUsuario = 1077557,
            GradoAcademico = "Maestría en Administración de Empresas",
            Especialidad = "Gestión de Proyectos",
            FechaContratacion = new DateTime(2023, 5, 12),
            Estatus = EstatusProfesor.Activo,
            Bio = "Certificado PMP con experiencia en metodologías ágiles."
        },
        new Profesor
        {
            IdUsuario = 1077558,
            GradoAcademico = "Doctorado en Filosofía",
            Especialidad = "Ética y Humanidades",
            FechaContratacion = new DateTime(2018, 9, 1),
            Estatus = EstatusProfesor.Activo,
            Bio = "Especialista en ética profesional y pensamiento crítico."
        },
        new Profesor
        {
            IdUsuario = 1077559,
            GradoAcademico = "Maestría en Redes y Telecomunicaciones",
            Especialidad = "Infraestructura de Redes",
            FechaContratacion = new DateTime(2022, 6, 18),
            Estatus = EstatusProfesor.Activo,
            Bio = "Experto en arquitectura de redes y protocolos de comunicación."
        },
        new Profesor
        {
            IdUsuario = 1077560,
            GradoAcademico = "Maestría en Inglés",
            Especialidad = "Idiomas",
            FechaContratacion = new DateTime(2020, 1, 8),
            Estatus = EstatusProfesor.Activo,
            Bio = "Profesor de inglés técnico y comunicación empresarial."
        }
    };

    public static List<Seccion> GetSeccions() => new()
    {
        #region Trimestre 1
        
        // 1. AHC109 - REDACCION
        new Seccion
        {
            SeccionId = 1,
            IdAsignatura = "AHC109",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 2,
            IdAsignatura = "AHC109",
            NumeroSeccion = "002",
            Cupo = 38,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 3,
            IdAsignatura = "AHC109",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 2. AHO102 - ORIENTACION ACADEMICA
        new Seccion
        {
            SeccionId = 4,
            IdAsignatura = "AHO102",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 5,
            IdAsignatura = "AHO102",
            NumeroSeccion = "002",
            Cupo = 32,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 3. CBA1X3 - VIDA EN EL MEDIO AMBIENTE
        new Seccion
        {
            SeccionId = 6,
            IdAsignatura = "CBA1X3",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 10,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 7,
            IdAsignatura = "CBA1X3",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 1,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 8,
            IdAsignatura = "CBA1X3",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },

        // 4. CBM101 - ALGEBRA Y GEOMETRIA ANALITICA
        new Seccion
        {
            SeccionId = 9,
            IdAsignatura = "CBM101",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 10,
            IdAsignatura = "CBM101",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 13,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 11,
            IdAsignatura = "CBM101",
            NumeroSeccion = "003",
            Cupo = 38,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 5. CSH112 - CIUDADANIA Y ETICA
        new Seccion
        {
            SeccionId = 12,
            IdAsignatura = "CSH112",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 14,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 13,
            IdAsignatura = "CSH112",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 3,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 14,
            IdAsignatura = "CSH112",
            NumeroSeccion = "003",
            Cupo = 32,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077547
        },

        // 6. EAA1X1 - ELECTIVAS I
        new Seccion
        {
            SeccionId = 15,
            IdAsignatura = "EAA1X1",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 16,
            IdAsignatura = "EAA1X1",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 1,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },

        // 7. EAA1X2 - ELECTIVAS II
        new Seccion
        {
            SeccionId = 17,
            IdAsignatura = "EAA1X2",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 2,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 18,
            IdAsignatura = "EAA1X2",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 19,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },

        // 8. EAA1X3 - ELECTIVAS III
        new Seccion
        {
            SeccionId = 19,
            IdAsignatura = "EAA1X3",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 20,
            IdAsignatura = "EAA1X3",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },

        // 9. IDS207 - INTRODUCCION A LA INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 21,
            IdAsignatura = "IDS207",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 22,
            IdAsignatura = "IDS207",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },

        // 10. SHI103 - INGLES 01
        new Seccion
        {
            SeccionId = 23,
            IdAsignatura = "SHI103",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 10,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 24,
            IdAsignatura = "SHI103",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 5,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        #endregion

        #region Trimestre 2
        
        // 11. AHC110 - ARGUMENTACIÓN LINGÜÍSTICA
        new Seccion
        {
            SeccionId = 25,
            IdAsignatura = "AHC110",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 26,
            IdAsignatura = "AHC110",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548,
        },

        // 12. CBM102 - CALCULO DIFERENCIAL
        new Seccion
        {
            SeccionId = 27,
            IdAsignatura = "CBM102",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 28,
            IdAsignatura = "CBM102",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 29,
            IdAsignatura = "CBM102",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 13. CSS102 - SER HUMANO Y SOCIEDAD
        new Seccion
        {
            SeccionId = 30,
            IdAsignatura = "CSS102",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 31,
            IdAsignatura = "CSS102",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },

        // 14. EAA1X4 - ELECTIVAS DE AREAS ACADEMICAS IV
        new Seccion
        {
            SeccionId = 32,
            IdAsignatura = "EAA1X4",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 33,
            IdAsignatura = "EAA1X4",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 15. IDS323 - TECNICAS FUNDAMENTALES DE INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 34,
            IdAsignatura = "IDS323",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 35,
            IdAsignatura = "IDS323",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 16. IDS323L - LAB. TECNICAS FUNDAMENTALES
        new Seccion
        {
            SeccionId = 36,
            IdAsignatura = "IDS323L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 37,
            IdAsignatura = "IDS323L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 17. ING102 - INTRODUCCION A LA PROGRAMACION
        new Seccion
        {
            SeccionId = 38,
            IdAsignatura = "ING102",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 39,
            IdAsignatura = "ING102",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 40,
            IdAsignatura = "ING102",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 18. ING102L - LAB. DE INTRODUCCION A LA PROGRAMACION
        new Seccion
        {
            SeccionId = 41,
            IdAsignatura = "ING102L",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 42,
            IdAsignatura = "ING102L",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 43,
            IdAsignatura = "ING102L",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 19. SHI104 - INGLES 02 (BASICO II)
        new Seccion
        {
            SeccionId = 44,
            IdAsignatura = "SHI104",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 45,
            IdAsignatura = "SHI104",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        #endregion

        #region Trimestre 3

        // 20. CBF210 - FISICA MECANICA I
        new Seccion
        {
            SeccionId = 46,
            IdAsignatura = "CBF210",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 47,
            IdAsignatura = "CBF210",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 21. CBF210L - LABORATORIO DE FISICA MECANICA I
        new Seccion
        {
            SeccionId = 48,
            IdAsignatura = "CBF210L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 49,
            IdAsignatura = "CBF210L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 22. CBM201 - CALCULO INTEGRAL
        new Seccion
        {
            SeccionId = 50,
            IdAsignatura = "CBM201",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 51,
            IdAsignatura = "CBM201",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 52,
            IdAsignatura = "CBM201",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077548
        },

        // 23. IDS202 - TECNOLOGIA DE OBJETOS
        new Seccion
        {
            SeccionId = 53,
            IdAsignatura = "IDS202",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 54,
            IdAsignatura = "IDS202",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 24. IDS202L - LABORATORIO TECNOLOGIA DE OBJETOS
        new Seccion
        {
            SeccionId = 55,
            IdAsignatura = "IDS202L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 56,
            IdAsignatura = "IDS202L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 25. IDS340 - DESARROLLO DE SOFTWARE I
        new Seccion
        {
            SeccionId = 57,
            IdAsignatura = "IDS340",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 58,
            IdAsignatura = "IDS340",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 26. IDS340L - LABORATORIO DE DESARROLLO DE SOFTWARE I
        new Seccion
        {
            SeccionId = 59,
            IdAsignatura = "IDS340L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 60,
            IdAsignatura = "IDS340L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 27. ING228 - HOJA DE CALCULO PARA INGENIEROS
        new Seccion
        {
            SeccionId = 61,
            IdAsignatura = "ING228",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 62,
            IdAsignatura = "ING228",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 28. SHI105 - INGLES 03 (INTERMEDIO I)
        new Seccion
        {
            SeccionId = 63,
            IdAsignatura = "SHI105",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 64,
            IdAsignatura = "SHI105",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        #endregion

        #region Trimestre 4

        // 29. AHQ101 - QUEHACER CIENTIFICO
        new Seccion
        {
            SeccionId = 65,
            IdAsignatura = "AHQ101",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 66,
            IdAsignatura = "AHQ101",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },

        // 30. CBF211 - FISICA MECANICA II
        new Seccion
        {
            SeccionId = 67,
            IdAsignatura = "CBF211",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 68,
            IdAsignatura = "CBF211",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077549
        },

        // 31. CBF211L - LABORATORIO DE FISICA MECANICA II
        new Seccion
        {
            SeccionId = 69,
            IdAsignatura = "CBF211L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 70,
            IdAsignatura = "CBF211L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },

        // 32. CBM202 - CALCULO VECTORIAL
        new Seccion
        {
            SeccionId = 71,
            IdAsignatura = "CBM202",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 72,
            IdAsignatura = "CBM202",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },

        // 33. CSH113 - PENSAMIENTO CREATIVO
        new Seccion
        {
            SeccionId = 73,
            IdAsignatura = "CSH113",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077547
        },

        // 34. IDS341 - DESARROLLO DE SOFTWARE II
        new Seccion
        {
            SeccionId = 74,
            IdAsignatura = "IDS341",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 75,
            IdAsignatura = "IDS341",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 35. IDS341L - LABORATORIO DE DESARROLLO DE SOFTWARE II
        new Seccion
        {
            SeccionId = 76,
            IdAsignatura = "IDS341L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 77,
            IdAsignatura = "IDS341L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },

        // 36. IDS342 - CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE I
        new Seccion
        {
            SeccionId = 78,
            IdAsignatura = "IDS342",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077549
        },

        // 37. SHI106 - INGLES 04 (INTERMEDIO II)
        new Seccion
        {
            SeccionId = 79,
            IdAsignatura = "SHI106",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 80,
            IdAsignatura = "SHI106",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        #endregion

        #region Trimestre 5

        // 38. CBM208 - ALGEBRA LINEAL
        new Seccion
        {
            SeccionId = 81,
            IdAsignatura = "CBM208",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 82,
            IdAsignatura = "CBM208",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 32,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077556
        },

        // 39. IDS208 - TEAM BUILDING
        new Seccion
        {
            SeccionId = 83,
            IdAsignatura = "IDS208",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077557
        },
        new Seccion
        {
            SeccionId = 84,
            IdAsignatura = "IDS208",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 40. IDS311 - PROCESO DE SOFTWARE
        new Seccion
        {
            SeccionId = 85,
            IdAsignatura = "IDS311",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 86,
            IdAsignatura = "IDS311",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 41. IDS324 - INGENIERIA DE REQUERIMIENTOS DE SOFTWARE
        new Seccion
        {
            SeccionId = 87,
            IdAsignatura = "IDS324",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 88,
            IdAsignatura = "IDS324",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077553
        },

        // 42. IDS324L - LAB. INGENIERIA DE REQUERIMIENTOS DE SOFTWARE
        new Seccion
        {
            SeccionId = 89,
            IdAsignatura = "IDS324L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 90,
            IdAsignatura = "IDS324L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 43. IDS343 - ESTRUCTURAS DE DATOS Y ALGORITMOS I
        new Seccion
        {
            SeccionId = 91,
            IdAsignatura = "IDS343",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 92,
            IdAsignatura = "IDS343",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },

        // 44. IDS343L - LAB. ESTRUCTURAS DE DATOS Y ALGORITMOS I
        new Seccion
        {
            SeccionId = 93,
            IdAsignatura = "IDS343L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 94,
            IdAsignatura = "IDS343L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },

        // 45. SHI107 - INGLES 05 (AVANZADO I)
        new Seccion
        {
            SeccionId = 95,
            IdAsignatura = "SHI107",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077560
        },
        new Seccion
        {
            SeccionId = 96,
            IdAsignatura = "SHI107",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077560
        },
        #endregion

        #region Trimestre 6

        // 46. CBM203 - ECUACIONES DIFERENCIALES
        new Seccion
        {
            SeccionId = 97,
            IdAsignatura = "CBM203",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077556
        },
        new Seccion
        {
            SeccionId = 98,
            IdAsignatura = "CBM203",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077556
        },

        // 47. CSH105 - PROYECTO INTEGRADOR DE ESTUDIOS GENERALES
        new Seccion
        {
            SeccionId = 99,
            IdAsignatura = "CSH105",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077558
        },
        new Seccion
        {
            SeccionId = 100,
            IdAsignatura = "CSH105",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077558
        },

        // 48. IDS344 - ESTRUCTURAS DE DATOS Y ALGORITMOS II
        new Seccion
        {
            SeccionId = 101,
            IdAsignatura = "IDS344",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 102,
            IdAsignatura = "IDS344",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 103,
            IdAsignatura = "IDS344",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077553
        },

        // 49. IDS344L - LABORATORIO ESTRUCTURAS DE DATOS Y ALGORITMOS II
        new Seccion
        {
            SeccionId = 104,
            IdAsignatura = "IDS344L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 105,
            IdAsignatura = "IDS344L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 106,
            IdAsignatura = "IDS344L",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 50. IEC208 - FUNDAMENTOS ELECTRÓNICA DIGITAL
        new Seccion
        {
            SeccionId = 107,
            IdAsignatura = "IEC208",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077559
        },
        new Seccion
        {
            SeccionId = 108,
            IdAsignatura = "IEC208",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077559
        },

        // 51. IEC208L - LABORATORIO FUNDAMENTOS ELECTRÓNICA DIGITAL
        new Seccion
        {
            SeccionId = 109,
            IdAsignatura = "IEC208L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077559
        },
        new Seccion
        {
            SeccionId = 110,
            IdAsignatura = "IEC208L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077559
        },

        // 52. INS377 - BASES DE DATOS I
        new Seccion
        {
            SeccionId = 111,
            IdAsignatura = "INS377",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 112,
            IdAsignatura = "INS377",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 113,
            IdAsignatura = "INS377",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077555
        },

        // 53. INS377L - LABORATORIO BASES DE DATOS I
        new Seccion
        {
            SeccionId = 114,
            IdAsignatura = "INS377L",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 115,
            IdAsignatura = "INS377L",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },

        // 54. SHI108 - INGLES 06 (AVANZADO II)
        new Seccion
        {
            SeccionId = 116,
            IdAsignatura = "SHI108",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077560
        },
        new Seccion
        {
            SeccionId = 117,
            IdAsignatura = "SHI108",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077560
        },
        new Seccion
        {
            SeccionId = 118,
            IdAsignatura = "SHI108",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077560
        },
        #endregion

        #region Trimestre 7

        // 55. CBM305 - MATEMATICA DISCRETA I
        new Seccion
        {
            SeccionId = 119,
            IdAsignatura = "CBM305",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 120,
            IdAsignatura = "CBM305",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077556
        },

        // 56. IDS329 - INGENIERIA DE FACTORES HUMANOS
        new Seccion
        {
            SeccionId = 121,
            IdAsignatura = "IDS329",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 122,
            IdAsignatura = "IDS329",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 57. IDS329L - LABORATORIO INGENIERIA DE FACTORES HUMANOS
        new Seccion
        {
            SeccionId = 123,
            IdAsignatura = "IDS329L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 124,
            IdAsignatura = "IDS329L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 58. IDS345 - DESARROLLO DE SOFTWARE III
        new Seccion
        {
            SeccionId = 125,
            IdAsignatura = "IDS345",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 126,
            IdAsignatura = "IDS345",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 127,
            IdAsignatura = "IDS345",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077550
        },

        // 59. IDS345L - LABORATORIO DE DESARROLLO DE SOFTWARE III
        new Seccion
        {
            SeccionId = 128,
            IdAsignatura = "IDS345L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 129,
            IdAsignatura = "IDS345L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 130,
            IdAsignatura = "IDS345L",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },

        // 60. IDS346 - MODELOS Y METODOS DE LA INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 131,
            IdAsignatura = "IDS346",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 132,
            IdAsignatura = "IDS346",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 61. INS380 - BASES DE DATOS II
        new Seccion
        {
            SeccionId = 133,
            IdAsignatura = "INS380",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 134,
            IdAsignatura = "INS380",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 135,
            IdAsignatura = "INS380",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077555
        },

        // 62. INS380L - LABORATORIO DE BASES DE DATOS II
        new Seccion
        {
            SeccionId = 136,
            IdAsignatura = "INS380L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 137,
            IdAsignatura = "INS380L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 138,
            IdAsignatura = "INS380L",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        #endregion

        #region Trimestre 8

        // 63. ICS202 - ALGORITMOS MALICIOSOS
        new Seccion
        {
            SeccionId = 139,
            IdAsignatura = "ICS202",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 140,
            IdAsignatura = "ICS202",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077555
        },

        // 64. ICS202L - LABORATORIO DE ALGORITMOS MALICIOSOS
        new Seccion
        {
            SeccionId = 141,
            IdAsignatura = "ICS202L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 142,
            IdAsignatura = "ICS202L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },

        // 65. IDS325 - ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE
        new Seccion
        {
            SeccionId = 143,
            IdAsignatura = "IDS325",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 144,
            IdAsignatura = "IDS325",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 145,
            IdAsignatura = "IDS325",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 66. IDS325L - LABORATORIO ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE
        new Seccion
        {
            SeccionId = 146,
            IdAsignatura = "IDS325L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 147,
            IdAsignatura = "IDS325L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 67. IDS335 - DISEÑO DE SOFTWARE
        new Seccion
        {
            SeccionId = 148,
            IdAsignatura = "IDS335",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 149,
            IdAsignatura = "IDS335",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077550
        },

        // 68. IDS347 - TENDENCIAS EN DESARROLLO DE SOFTWARE
        new Seccion
        {
            SeccionId = 150,
            IdAsignatura = "IDS347",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 151,
            IdAsignatura = "IDS347",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 152,
            IdAsignatura = "IDS347",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077547
        },

        // 69. IDS347L - LABORATORIO TENDENCIAS EN DESARROLLO DE SOFTWARE
        new Seccion
        {
            SeccionId = 153,
            IdAsignatura = "IDS347L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 154,
            IdAsignatura = "IDS347L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 155,
            IdAsignatura = "IDS347L",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },

        // 70. ING214 - ANALISIS DE DATOS EN INGENIERIA
        new Seccion
        {
            SeccionId = 156,
            IdAsignatura = "ING214",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077556
        },
        new Seccion
        {
            SeccionId = 157,
            IdAsignatura = "ING214",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077556
        },
        new Seccion
        {
            SeccionId = 158,
            IdAsignatura = "ING214",
            NumeroSeccion = "003",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },
        #endregion

        #region Trimestre 9

        // 71. CON213 - FUNDAMENTOS DE CONTABILIDAD
        new Seccion
        {
            SeccionId = 159,
            IdAsignatura = "CON213",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 32,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077557
        },
        new Seccion
        {
            SeccionId = 160,
            IdAsignatura = "CON213",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077557
        },

        // 72. IDS303 - PRACTICA PROFESIONAL DE INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 161,
            IdAsignatura = "IDS303",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 162,
            IdAsignatura = "IDS303",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },

        // 73. IDS309 - ARQUITECTURA DE SOFTWARE
        new Seccion
        {
            SeccionId = 163,
            IdAsignatura = "IDS309",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 164,
            IdAsignatura = "IDS309",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 165,
            IdAsignatura = "IDS309",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077553
        },

        // 74. IDS348 - DESARROLLO DE APLICACIONES WEB
        new Seccion
        {
            SeccionId = 166,
            IdAsignatura = "IDS348",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 167,
            IdAsignatura = "IDS348",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 168,
            IdAsignatura = "IDS348",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077550
        },

        // 75. IDS348L - LABORATORIO DESARROLLO DE APLICACIONES WEB
        new Seccion
        {
            SeccionId = 169,
            IdAsignatura = "IDS348L",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 170,
            IdAsignatura = "IDS348L",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 171,
            IdAsignatura = "IDS348L",
            NumeroSeccion = "003",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077550
        },

        // 76. ING230 - INGENIERIA ECONOMICA
        new Seccion
        {
            SeccionId = 172,
            IdAsignatura = "ING230",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077557
        },
        new Seccion
        {
            SeccionId = 173,
            IdAsignatura = "ING230",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 77. ING231 - EXPERIMENTACION EN INGENIERIA
        new Seccion
        {
            SeccionId = 174,
            IdAsignatura = "ING231",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077552
        },
        new Seccion
        {
            SeccionId = 175,
            IdAsignatura = "ING231",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077549
        },
        #endregion

        #region Trimestre 10
        // 78. IDS326 - CONSTRUCCION DE SOFTWARE
        new Seccion
        {
            SeccionId = 176,
            IdAsignatura = "IDS326",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 177,
            IdAsignatura = "IDS326",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },

        // 79. IDS326L - LABORATORIO CONSTRUCCION DE SOFTWARE
        new Seccion
        {
            SeccionId = 178,
            IdAsignatura = "IDS326L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 179,
            IdAsignatura = "IDS326L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077548
        },

        // 80. IDS349 - DESARROLLO DE APLICACIONES MOVILES
        new Seccion
        {
            SeccionId = 180,
            IdAsignatura = "IDS349",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 181,
            IdAsignatura = "IDS349",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 182,
            IdAsignatura = "IDS349",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077547
        },

        // 81. IDS349L - LABORATORIO DESARROLLO DE APLICACIONES MOVILES
        new Seccion
        {
            SeccionId = 183,
            IdAsignatura = "IDS349L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 184,
            IdAsignatura = "IDS349L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },
        new Seccion
        {
            SeccionId = 185,
            IdAsignatura = "IDS349L",
            NumeroSeccion = "003",
            Cupo = 25,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077547
        },

        // 82. ING235 - FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS
        new Seccion
        {
            SeccionId = 186,
            IdAsignatura = "ING235",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 32,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077552
        },
        new Seccion
        {
            SeccionId = 187,
            IdAsignatura = "ING235",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 83. ING235L - LABORATORIO FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS
        new Seccion
        {
            SeccionId = 188,
            IdAsignatura = "ING235L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077552
        },
        new Seccion
        {
            SeccionId = 189,
            IdAsignatura = "ING235L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },

        // 84. INS371 - ARQUITECTURA DEL COMPUTADOR
        new Seccion
        {
            SeccionId = 190,
            IdAsignatura = "INS371",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 191,
            IdAsignatura = "INS371",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 85. INS371L - LABORATORIO ARQUITECTURA COMPUTADOR
        new Seccion
        {
            SeccionId = 192,
            IdAsignatura = "INS371L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 193,
            IdAsignatura = "INS371L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 86. ISE2E1 - IMPACTO SOCIAL (ELECTIVA)
        new Seccion
        {
            SeccionId = 194,
            IdAsignatura = "ISE2E1",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 35,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 195,
            IdAsignatura = "ISE2E1",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077558
        },
        #endregion

        #region Trimestre 11
        // 87. ECO322 - ECONOMIA DE EMPRESA
        new Seccion
        {
            SeccionId = 196,
            IdAsignatura = "ECO322",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 32,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 197,
            IdAsignatura = "ECO322",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077558
        },

        // 88. IDS328 - ADMINISTRACION DE CONFIGURACION
        new Seccion
        {
            SeccionId = 198,
            IdAsignatura = "IDS328",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 199,
            IdAsignatura = "IDS328",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 89. IDS328L - LABORATORIO DE ADMINISTRACION DE CONFIGURACION
        new Seccion
        {
            SeccionId = 200,
            IdAsignatura = "IDS328L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 201,
            IdAsignatura = "IDS328L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 90. IDS330 - INTELIGENCIA ARTIFICIAL
        new Seccion
        {
            SeccionId = 202,
            IdAsignatura = "IDS330",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 30,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 203,
            IdAsignatura = "IDS330",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 204,
            IdAsignatura = "IDS330",
            NumeroSeccion = "003",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077554
        },

        // 91. IDS330L - LABORATORIO INTELIGENCIA ARTIFICIAL
        new Seccion
        {
            SeccionId = 205,
            IdAsignatura = "IDS330L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 206,
            IdAsignatura = "IDS330L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 207,
            IdAsignatura = "IDS330L",
            NumeroSeccion = "003",
            Cupo = 25,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Hibrida,
            IdProfesor = 1077554
        },

        // 92. IDS350 - CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE II
        new Seccion
        {
            SeccionId = 208,
            IdAsignatura = "IDS350",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 209,
            IdAsignatura = "IDS350",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077552
        },

        // 93. IDS351 - PRUEBAS DE SOFTWARE
        new Seccion
        {
            SeccionId = 210,
            IdAsignatura = "IDS351",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 211,
            IdAsignatura = "IDS351",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 94. INS373 - SISTEMAS OPERATIVOS
        new Seccion
        {
            SeccionId = 212,
            IdAsignatura = "INS373",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 213,
            IdAsignatura = "INS373",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 95. INS373L - LABORATORIO SISTEMAS OPERATIVOS
        new Seccion
        {
            SeccionId = 214,
            IdAsignatura = "INS373L",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 215,
            IdAsignatura = "INS373L",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },
        #endregion

        #region Trimestre 12
        // 96. ADM315 - ADMINISTRACION Y GESTION EMPRESARIAL
        new Seccion
        {
            SeccionId = 216,
            IdAsignatura = "ADM315",
            NumeroSeccion = "001",
            Cupo = 40,
            CupoDisponible = 32,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077551
        },
        new Seccion
        {
            SeccionId = 217,
            IdAsignatura = "ADM315",
            NumeroSeccion = "002",
            Cupo = 40,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077554
        },

        // 97. EEE2X1 - ELECTIVAS DE ESTUDIOS ESPECIALIZADOS I
        new Seccion
        {
            SeccionId = 218,
            IdAsignatura = "EEE2X1",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 219,
            IdAsignatura = "EEE2X1",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077552
        },

        // 98. ICS320 - FUNDAMENTOS DE CIBERSEGURIDAD
        new Seccion
        {
            SeccionId = 220,
            IdAsignatura = "ICS320",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 24,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 221,
            IdAsignatura = "ICS320",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 99. IDS339 - DEVOPS Y DEVSECOPS
        new Seccion
        {
            SeccionId = 222,
            IdAsignatura = "IDS339",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 22,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 223,
            IdAsignatura = "IDS339",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 100. IDS352 - ANTEPROYECTO DE GRADO
        new Seccion
        {
            SeccionId = 224,
            IdAsignatura = "IDS352",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 225,
            IdAsignatura = "IDS352",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077552
        },

        // 101. IDS353 - PASANTIA PROFESIONAL I
        new Seccion
        {
            SeccionId = 226,
            IdAsignatura = "IDS353",
            NumeroSeccion = "001",
            Cupo = 20,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 227,
            IdAsignatura = "IDS353",
            NumeroSeccion = "002",
            Cupo = 20,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077558
        },

        // 102. IDS354 - GESTION DE LA INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 228,
            IdAsignatura = "IDS354",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 229,
            IdAsignatura = "IDS354",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077551
        },
        #endregion

        #region Trimestre 13
        // 103. EEE2X2 - ELECTIVAS DE ESTUDIOS ESPECIALIZADOS II
        new Seccion
        {
            SeccionId = 230,
            IdAsignatura = "EEE2X2",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 231,
            IdAsignatura = "EEE2X2",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 104. EEP3X1 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES I
        new Seccion
        {
            SeccionId = 232,
            IdAsignatura = "EEP3X1",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 233,
            IdAsignatura = "EEP3X1",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 105. IDS322 - MANTENIMIENTO DE SOFTWARE
        new Seccion
        {
            SeccionId = 234,
            IdAsignatura = "IDS322",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 24,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 235,
            IdAsignatura = "IDS322",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077551
        },

        // 106. IDS355 - PROYECTO DE GRADO
        new Seccion
        {
            SeccionId = 236,
            IdAsignatura = "IDS355",
            NumeroSeccion = "001",
            Cupo = 20,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 237,
            IdAsignatura = "IDS355",
            NumeroSeccion = "002",
            Cupo = 20,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077552
        },

        // 107. IDS356 - PASANTIA PROFESIONAL II
        new Seccion
        {
            SeccionId = 238,
            IdAsignatura = "IDS356",
            NumeroSeccion = "001",
            Cupo = 20,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077555
        },
        new Seccion
        {
            SeccionId = 239,
            IdAsignatura = "IDS356",
            NumeroSeccion = "002",
            Cupo = 20,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077558
        },

        // 108. IDS3X5 - CERTIFICACION PROFESIONAL
        new Seccion
        {
            SeccionId = 240,
            IdAsignatura = "IDS3X5",
            NumeroSeccion = "001",
            Cupo = 25,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077554
        },
        new Seccion
        {
            SeccionId = 241,
            IdAsignatura = "IDS3X5",
            NumeroSeccion = "002",
            Cupo = 25,
            CupoDisponible = 18,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077557
        },
        #endregion

        #region Trimestre 14
        // 109. EEP3X2 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES II
        new Seccion
        {
            SeccionId = 242,
            IdAsignatura = "EEP3X2",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077547
        },
        new Seccion
        {
            SeccionId = 243,
            IdAsignatura = "EEP3X2",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077550
        },

        // 110. EEP3X3 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES III
        new Seccion
        {
            SeccionId = 244,
            IdAsignatura = "EEP3X3",
            NumeroSeccion = "001",
            Cupo = 35,
            CupoDisponible = 28,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077553
        },
        new Seccion
        {
            SeccionId = 245,
            IdAsignatura = "EEP3X3",
            NumeroSeccion = "002",
            Cupo = 35,
            CupoDisponible = 25,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077556
        },

        // 111. IDS334 - SEMINARIO DE TECNOLOGIA E INGENIERIA DE SOFTWARE
        new Seccion
        {
            SeccionId = 246,
            IdAsignatura = "IDS334",
            NumeroSeccion = "001",
            Cupo = 30,
            CupoDisponible = 24,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077548
        },
        new Seccion
        {
            SeccionId = 247,
            IdAsignatura = "IDS334",
            NumeroSeccion = "002",
            Cupo = 30,
            CupoDisponible = 20,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077551
        },

        // 112. IDS357 - PROYECTO FINAL DE GRADO
        new Seccion
        {
            SeccionId = 248,
            IdAsignatura = "IDS357",
            NumeroSeccion = "001",
            Cupo = 20,
            CupoDisponible = 15,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Presencial,
            IdProfesor = 1077549
        },
        new Seccion
        {
            SeccionId = 249,
            IdAsignatura = "IDS357",
            NumeroSeccion = "002",
            Cupo = 20,
            CupoDisponible = 12,
            PeriodoAcademico = "2026-01",
            Estatus = EstatusSeccion.Activa,
            Modalidad = ModalidadSeccion.Virtual,
            IdProfesor = 1077552
        }
        #endregion
    };

    public static List<SeccionHorario> GetSeccionHorarios() => new()
    {
        #region Trimestre 1
        
        // 1. AHC109 - REDACCION
        new SeccionHorario
        {
            IdSeccionHorario = 1,
            IdSeccion = 1,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 2,
            IdSeccion = 1,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 3,
            IdSeccion = 2,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 4,
            IdSeccion = 2,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 2. AHO102 - ORIENTACION ACADEMICA
        new SeccionHorario
        {
            IdSeccionHorario = 5,
            IdSeccion = 3,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 6,
            IdSeccion = 4,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 2
        },

        // 3. CBA1X3 - VIDA EN EL MEDIO AMBIENTE
        new SeccionHorario
        {
            IdSeccionHorario = 7,
            IdSeccion = 5,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 8,
            IdSeccion = 6,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },

        // 4. CBM101 - ALGEBRA Y GEOMETRIA ANALITICA
        new SeccionHorario
        {
            IdSeccionHorario = 9,
            IdSeccion = 7,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 10,
            IdSeccion = 7,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 11,
            IdSeccion = 8,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 12,
            IdSeccion = 8,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 3
        },

        // 5. CSH112 - CIUDADANIA Y ETICA
        new SeccionHorario
        {
            IdSeccionHorario = 13,
            IdSeccion = 9,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 14,
            IdSeccion = 10,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 2
        },

        // 6. EAA1X1 - ELECTIVAS I
        new SeccionHorario
        {
            IdSeccionHorario = 15,
            IdSeccion = 11,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 16,
            IdSeccion = 12,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 7
        },

        // 7. EAA1X2 - ELECTIVAS II
        new SeccionHorario
        {
            IdSeccionHorario = 17,
            IdSeccion = 13,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 18,
            IdSeccion = 14,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 8
        },

        // 8. EAA1X3 - ELECTIVAS III
        new SeccionHorario
        {
            IdSeccionHorario = 19,
            IdSeccion = 15,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 9
        },
        new SeccionHorario
        {
            IdSeccionHorario = 20,
            IdSeccion = 16,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 9
        },

        // 9. IDS207 - INTRODUCCION A LA INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 21,
            IdSeccion = 17,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 22,
            IdSeccion = 18,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 4
        },

        // 10. SHI103 - INGLES 01
        new SeccionHorario
        {
            IdSeccionHorario = 23,
            IdSeccion = 19,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 24,
            IdSeccion = 20,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 10
        },
        #endregion

        #region Trimestre 2

        // 11. AHC110 - ARGUMENTACIÓN LINGÜÍSTICA
        new SeccionHorario
        {
            IdSeccionHorario = 25,
            IdSeccion = 21,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 26,
            IdSeccion = 21,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 27,
            IdSeccion = 22,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 28,
            IdSeccion = 22,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 2
        },

        // 12. CBM102 - CALCULO DIFERENCIAL
        new SeccionHorario
        {
            IdSeccionHorario = 29,
            IdSeccion = 23,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 30,
            IdSeccion = 23,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 31,
            IdSeccion = 24,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 32,
            IdSeccion = 24,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 33,
            IdSeccion = 25,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 34,
            IdSeccion = 25,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 5
        },

        // 13. CSS102 - SER HUMANO Y SOCIEDAD
        new SeccionHorario
        {
            IdSeccionHorario = 35,
            IdSeccion = 26,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 36,
            IdSeccion = 27,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 6
        },

        // 14. EAA1X4 - ELECTIVAS DE AREAS ACADEMICAS IV
        new SeccionHorario
        {
            IdSeccionHorario = 37,
            IdSeccion = 28,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 38,
            IdSeccion = 29,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 7
        },

        // 15. IDS323 - TECNICAS FUNDAMENTALES DE INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 39,
            IdSeccion = 30,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 40,
            IdSeccion = 30,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 41,
            IdSeccion = 31,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 9
        },
        new SeccionHorario
        {
            IdSeccionHorario = 42,
            IdSeccion = 31,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 9
        },

        // 16. IDS323L - LAB. TECNICAS FUNDAMENTALES
        new SeccionHorario
        {
            IdSeccionHorario = 43,
            IdSeccion = 32,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(18, 30),
            HoraFin = new TimeOnly(20, 30),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 44,
            IdSeccion = 32,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 30),
            HoraFin = new TimeOnly(20, 30),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 45,
            IdSeccion = 33,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 30),
            HoraFin = new TimeOnly(20, 30),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 46,
            IdSeccion = 33,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 30),
            HoraFin = new TimeOnly(20, 30),
            IdAula = 5
        },

        // 17. ING102 - INTRODUCCION A LA PROGRAMACION
        new SeccionHorario
        {
            IdSeccionHorario = 47,
            IdSeccion = 34,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 48,
            IdSeccion = 35,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 49,
            IdSeccion = 36,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 10
        },

        // 18. ING102L - LABORATORIO DE INTRODUCCION A LA PROGRAMACION
        new SeccionHorario
        {
            IdSeccionHorario = 50,
            IdSeccion = 37,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 51,
            IdSeccion = 38,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 52,
            IdSeccion = 39,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 4
        },

        // 19. SHI104 - INGLES 02 (BASICO II)
        new SeccionHorario
        {
            IdSeccionHorario = 53,
            IdSeccion = 40,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 54,
            IdSeccion = 41,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 2
        },
        #endregion

        #region Trimestre 3

        // 20. CBF210 - FISICA MECANICA I
        new SeccionHorario
        {
            IdSeccionHorario = 55,
            IdSeccion = 42,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 56,
            IdSeccion = 42,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 57,
            IdSeccion = 43,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 58,
            IdSeccion = 43,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 6
        },

        // 21. CBF210L - LABORATORIO DE FISICA MECANICA I
        new SeccionHorario
        {
            IdSeccionHorario = 59,
            IdSeccion = 44,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 60,
            IdSeccion = 45,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 5
        },

        // 22. CBM201 - CALCULO INTEGRAL
        new SeccionHorario
        {
            IdSeccionHorario = 61,
            IdSeccion = 46,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 62,
            IdSeccion = 46,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 63,
            IdSeccion = 47,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 64,
            IdSeccion = 47,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 65,
            IdSeccion = 48,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 66,
            IdSeccion = 48,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 3
        },

        // 23. IDS202 - TECNOLOGIA DE OBJETOS
        new SeccionHorario
        {
            IdSeccionHorario = 67,
            IdSeccion = 49,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 68,
            IdSeccion = 49,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 69,
            IdSeccion = 50,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 9
        },
        new SeccionHorario
        {
            IdSeccionHorario = 70,
            IdSeccion = 50,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 9
        },

        // 24. IDS202L - LABORATORIO TECNOLOGIA DE OBJETOS
        new SeccionHorario
        {
            IdSeccionHorario = 71,
            IdSeccion = 51,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 72,
            IdSeccion = 52,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 5
        },

        // 25. IDS340 - DESARROLLO DE SOFTWARE I
        new SeccionHorario
        {
            IdSeccionHorario = 73,
            IdSeccion = 53,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 30),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 74,
            IdSeccion = 54,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 30),
            IdAula = 7
        },

        // 26. IDS340L - LABORATORIO DE DESARROLLO DE SOFTWARE I
        new SeccionHorario
        {
            IdSeccionHorario = 75,
            IdSeccion = 55,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 76,
            IdSeccion = 56,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 5
        },

        // 27. ING228 - HOJA DE CALCULO PARA INGENIEROS
        new SeccionHorario
        {
            IdSeccionHorario = 77,
            IdSeccion = 57,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 78,
            IdSeccion = 58,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },

        // 28. SHI105 - INGLES 03 (INTERMEDIO I)
        new SeccionHorario
        {
            IdSeccionHorario = 79,
            IdSeccion = 59,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 80,
            IdSeccion = 60,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 6
        },
        #endregion

        #region Trimestre 4

        // 29. AHQ101 - QUEHACER CIENTIFICO
        new SeccionHorario
        {
            IdSeccionHorario = 81,
            IdSeccion = 65,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 82,
            IdSeccion = 65,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 83,
            IdSeccion = 66,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 2
        },

        // 30. CBF211 - FISICA MECANICA II
        new SeccionHorario
        {
            IdSeccionHorario = 84,
            IdSeccion = 67,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 85,
            IdSeccion = 67,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 86,
            IdSeccion = 68,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 87,
            IdSeccion = 68,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 6
        },

        // 31. CBF211L - LABORATORIO DE FISICA MECANICA II
        new SeccionHorario
        {
            IdSeccionHorario = 88,
            IdSeccion = 69,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 30),
            HoraFin = new TimeOnly(18, 30),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 89,
            IdSeccion = 70,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 5
        },

        // 32. CBM202 - CALCULO VECTORIAL
        new SeccionHorario
        {
            IdSeccionHorario = 90,
            IdSeccion = 71,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 91,
            IdSeccion = 71,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 92,
            IdSeccion = 72,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 93,
            IdSeccion = 72,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 2
        },

        // 33. CSH113 - PENSAMIENTO CREATIVO
        new SeccionHorario
        {
            IdSeccionHorario = 94,
            IdSeccion = 73,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(15, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 95,
            IdSeccion = 73,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 7
        },

        // 34. IDS341 - DESARROLLO DE SOFTWARE II
        new SeccionHorario
        {
            IdSeccionHorario = 96,
            IdSeccion = 74,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 97,
            IdSeccion = 74,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 98,
            IdSeccion = 75,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 9
        },
        new SeccionHorario
        {
            IdSeccionHorario = 99,
            IdSeccion = 75,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 9
        },

        // 35. IDS341L - LABORATORIO DE DESARROLLO DE SOFTWARE II
        new SeccionHorario
        {
            IdSeccionHorario = 100,
            IdSeccion = 76,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 101,
            IdSeccion = 77,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 5
        },

        // 36. IDS342 - CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE I
        new SeccionHorario
        {
            IdSeccionHorario = 102,
            IdSeccion = 78,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 10
        },

        // 37. SHI106 - INGLES 04 (INTERMEDIO II)
        new SeccionHorario
        {
            IdSeccionHorario = 103,
            IdSeccion = 79,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 104,
            IdSeccion = 80,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(13, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        #endregion

        #region Trimestre 5

        // 38. CBM208 - ALGEBRA LINEAL
        new SeccionHorario
        {
            IdSeccionHorario = 105,
            IdSeccion = 81,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 106,
            IdSeccion = 81,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 107,
            IdSeccion = 82,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(17, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 108,
            IdSeccion = 82,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 2
        },

        // 39. IDS208 - TEAM BUILDING
        new SeccionHorario
        {
            IdSeccionHorario = 109,
            IdSeccion = 83,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(15, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 110,
            IdSeccion = 84,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(21, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 111,
            IdSeccion = 84,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 7
        },

        // 40. IDS311 - PROCESO DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 112,
            IdSeccion = 85,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(13, 0),
            HoraFin = new TimeOnly(15, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 113,
            IdSeccion = 85,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(13, 0),
            HoraFin = new TimeOnly(15, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 114,
            IdSeccion = 86,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 8
        },
        new SeccionHorario
        {
            IdSeccionHorario = 115,
            IdSeccion = 86,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 8
        },

        // 41. IDS324 - INGENIERIA DE REQUERIMIENTOS DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 116,
            IdSeccion = 87,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 117,
            IdSeccion = 87,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 118,
            IdSeccion = 88,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 9
        },
        new SeccionHorario
        {
            IdSeccionHorario = 119,
            IdSeccion = 88,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 9
        },

        // 42. IDS324L - LAB. INGENIERIA DE REQUERIMIENTOS DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 120,
            IdSeccion = 89,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 121,
            IdSeccion = 90,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(13, 0),
            HoraFin = new TimeOnly(15, 0),
            IdAula = 5
        },

        // 43. IDS343 - ESTRUCTURAS DE DATOS Y ALGORITMOS I
        new SeccionHorario
        {
            IdSeccionHorario = 122,
            IdSeccion = 91,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(15, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 123,
            IdSeccion = 91,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(15, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 124,
            IdSeccion = 92,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 125,
            IdSeccion = 92,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 10
        },

        // 44. IDS343L - LAB. ESTRUCTURAS DE DATOS Y ALGORITMOS I
        new SeccionHorario
        {
            IdSeccionHorario = 126,
            IdSeccion = 93,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 127,
            IdSeccion = 94,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 5
        },

        // 45. SHI107 - INGLES 05 (AVANZADO I)
        new SeccionHorario
        {
            IdSeccionHorario = 128,
            IdSeccion = 95,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 129,
            IdSeccion = 96,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 6
        },
        #endregion

        #region Trimestre 6

        // 46. CBM203 - ECUACIONES DIFERENCIALES
        new SeccionHorario
        {
            IdSeccionHorario = 130,
            IdSeccion = 97,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 11
        },
        new SeccionHorario
        {
            IdSeccionHorario = 131,
            IdSeccion = 97,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 11
        },
        new SeccionHorario
        {
            IdSeccionHorario = 132,
            IdSeccion = 98,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 13
        },
        new SeccionHorario
        {
            IdSeccionHorario = 133,
            IdSeccion = 98,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 13
        },

        // 47. CSH105 - PROYECTO INTEGRADOR DE ESTUDIOS GENERALES
        new SeccionHorario
        {
            IdSeccionHorario = 134,
            IdSeccion = 99,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 12
        },
        new SeccionHorario
        {
            IdSeccionHorario = 135,
            IdSeccion = 99,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 12
        },
        new SeccionHorario
        {
            IdSeccionHorario = 136,
            IdSeccion = 100,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 18
        },

        // 48. IDS344 - ESTRUCTURAS DE DATOS Y ALGORITMOS II
        new SeccionHorario
        {
            IdSeccionHorario = 137,
            IdSeccion = 101,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 17
        },
        new SeccionHorario
        {
            IdSeccionHorario = 138,
            IdSeccion = 101,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 17
        },
        new SeccionHorario
        {
            IdSeccionHorario = 139,
            IdSeccion = 102,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 14
        },
        new SeccionHorario
        {
            IdSeccionHorario = 140,
            IdSeccion = 102,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 14
        },
        new SeccionHorario
        {
            IdSeccionHorario = 141,
            IdSeccion = 103,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(19, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 19
        },

        // 49. IDS344L - LABORATORIO ESTRUCTURAS DE DATOS Y ALGORITMOS II
        new SeccionHorario
        {
            IdSeccionHorario = 142,
            IdSeccion = 104,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 15
        },
        new SeccionHorario
        {
            IdSeccionHorario = 143,
            IdSeccion = 105,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 15
        },
        new SeccionHorario
        {
            IdSeccionHorario = 144,
            IdSeccion = 106,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 16
        },

        // 50. IEC208 - FUNDAMENTOS ELECTRÓNICA DIGITAL
        new SeccionHorario
        {
            IdSeccionHorario = 145,
            IdSeccion = 107,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 146,
            IdSeccion = 107,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 147,
            IdSeccion = 108,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 148,
            IdSeccion = 108,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(20, 0),
            HoraFin = new TimeOnly(22, 0),
            IdAula = 21
        },

        // 51. IEC208L - LABORATORIO FUNDAMENTOS ELECTRÓNICA DIGITAL
        new SeccionHorario
        {
            IdSeccionHorario = 149,
            IdSeccion = 109,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 16
        },
        new SeccionHorario
        {
            IdSeccionHorario = 150,
            IdSeccion = 110,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(15, 0),
            HoraFin = new TimeOnly(17, 0),
            IdAula = 16
        },

        // 52. INS377 - BASES DE DATOS I
        new SeccionHorario
        {
            IdSeccionHorario = 151,
            IdSeccion = 111,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 152,
            IdSeccion = 111,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 153,
            IdSeccion = 112,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 154,
            IdSeccion = 112,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 155,
            IdSeccion = 113,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 24
        },

        // 53. INS377L - LABORATORIO BASES DE DATOS I
        new SeccionHorario
        {
            IdSeccionHorario = 156,
            IdSeccion = 114,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 157,
            IdSeccion = 115,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 5
        },

        // 54. SHI108 - INGLES 06 (AVANZADO II)
        new SeccionHorario
        {
            IdSeccionHorario = 158,
            IdSeccion = 116,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 159,
            IdSeccion = 116,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 160,
            IdSeccion = 117,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(17, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 161,
            IdSeccion = 117,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(17, 0),
            HoraFin = new TimeOnly(19, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 162,
            IdSeccion = 118,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(13, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 8
        },
        #endregion

        #region Trimestre 7

        // 55. CBM305 - MATEMATICA DISCRETA I
        new SeccionHorario
        {
            IdSeccionHorario = 163,
            IdSeccion = 119,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 164,
            IdSeccion = 119,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 165,
            IdSeccion = 120,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 166,
            IdSeccion = 120,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 56. IDS329 - INGENIERIA DE FACTORES HUMANOS
        new SeccionHorario
        {
            IdSeccionHorario = 167,
            IdSeccion = 121,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 168,
            IdSeccion = 121,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 169,
            IdSeccion = 122,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 17
        },
        new SeccionHorario
        {
            IdSeccionHorario = 170,
            IdSeccion = 122,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 17
        },

        // 57. IDS329L - LABORATORIO INGENIERIA DE FACTORES HUMANOS
        new SeccionHorario
        {
            IdSeccionHorario = 171,
            IdSeccion = 123,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 172,
            IdSeccion = 124,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 5
        },

        // 58. IDS345 - DESARROLLO DE SOFTWARE III
        new SeccionHorario
        {
            IdSeccionHorario = 173,
            IdSeccion = 125,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(11, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 18
        },
        new SeccionHorario
        {
            IdSeccionHorario = 174,
            IdSeccion = 125,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(11, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 18
        },
        new SeccionHorario
        {
            IdSeccionHorario = 175,
            IdSeccion = 126,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 176,
            IdSeccion = 126,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 177,
            IdSeccion = 127,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 20
        },

        // 59. IDS345L - LABORATORIO DE DESARROLLO DE SOFTWARE III
        new SeccionHorario
        {
            IdSeccionHorario = 178,
            IdSeccion = 128,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 179,
            IdSeccion = 129,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 180,
            IdSeccion = 130,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 15
        },

        // 60. IDS346 - MODELOS Y METODOS DE LA INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 181,
            IdSeccion = 131,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 182,
            IdSeccion = 131,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 183,
            IdSeccion = 132,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 22
        },

        // 61. INS380 - BASES DE DATOS II
        new SeccionHorario
        {
            IdSeccionHorario = 184,
            IdSeccion = 133,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 185,
            IdSeccion = 133,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 186,
            IdSeccion = 134,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 187,
            IdSeccion = 134,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 188,
            IdSeccion = 135,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 25
        },

        // 62. INS380L - LABORATORIO DE BASES DE DATOS II
        new SeccionHorario
        {
            IdSeccionHorario = 189,
            IdSeccion = 136,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(9, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 190,
            IdSeccion = 137,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(9, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 191,
            IdSeccion = 138,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(11, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 16
        },
        #endregion

        #region Trimestre 8

        // 63. ICS202 - ALGORITMOS MALICIOSOS
        new SeccionHorario
        {
            IdSeccionHorario = 192,
            IdSeccion = 139,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 193,
            IdSeccion = 139,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 194,
            IdSeccion = 140,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 195,
            IdSeccion = 140,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 2
        },

        // 64. ICS202L - LABORATORIO DE ALGORITMOS MALICIOSOS
        new SeccionHorario
        {
            IdSeccionHorario = 196,
            IdSeccion = 141,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 15
        },
        new SeccionHorario
        {
            IdSeccionHorario = 197,
            IdSeccion = 142,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 16
        },

        // 65. IDS325 - ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 198,
            IdSeccion = 143,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 199,
            IdSeccion = 143,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 200,
            IdSeccion = 144,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 17
        },
        new SeccionHorario
        {
            IdSeccionHorario = 201,
            IdSeccion = 144,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 17
        },
        new SeccionHorario
        {
            IdSeccionHorario = 202,
            IdSeccion = 145,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 18
        },

        // 66. IDS325L - LABORATORIO ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 203,
            IdSeccion = 146,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 204,
            IdSeccion = 147,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 5
        },

        // 67. IDS335 - DISEÑO DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 205,
            IdSeccion = 148,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 206,
            IdSeccion = 148,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 207,
            IdSeccion = 149,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 208,
            IdSeccion = 149,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 20
        },

        // 68. IDS347 - TENDENCIAS EN DESARROLLO DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 209,
            IdSeccion = 150,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 210,
            IdSeccion = 150,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 211,
            IdSeccion = 151,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 212,
            IdSeccion = 151,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 213,
            IdSeccion = 152,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 23
        },

        // 69. IDS347L - LABORATORIO TENDENCIAS EN DESARROLLO DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 214,
            IdSeccion = 153,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 215,
            IdSeccion = 154,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 216,
            IdSeccion = 155,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 15
        },

        // 70. ING214 - ANALISIS DE DATOS EN INGENIERIA
        new SeccionHorario
        {
            IdSeccionHorario = 217,
            IdSeccion = 156,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 218,
            IdSeccion = 156,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 219,
            IdSeccion = 157,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 25
        },
        new SeccionHorario
        {
            IdSeccionHorario = 220,
            IdSeccion = 157,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 25
        },
        new SeccionHorario
        {
            IdSeccionHorario = 221,
            IdSeccion = 158,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 13
        },
        #endregion

        #region Trimestre 9

        // 71. CON213 - FUNDAMENTOS DE CONTABILIDAD
        new SeccionHorario
        {
            IdSeccionHorario = 222,
            IdSeccion = 159,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 223,
            IdSeccion = 159,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 224,
            IdSeccion = 160,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 2
        },
        new SeccionHorario
        {
            IdSeccionHorario = 225,
            IdSeccion = 160,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 2
        },

        // 72. IDS303 - PRACTICA PROFESIONAL DE INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 226,
            IdSeccion = 161,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 227,
            IdSeccion = 162,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 17
        },

        // 73. IDS309 - ARQUITECTURA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 228,
            IdSeccion = 163,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 18
        },
        new SeccionHorario
        {
            IdSeccionHorario = 229,
            IdSeccion = 163,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 18
        },
        new SeccionHorario
        {
            IdSeccionHorario = 230,
            IdSeccion = 164,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 231,
            IdSeccion = 164,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 19
        },
        new SeccionHorario
        {
            IdSeccionHorario = 232,
            IdSeccion = 165,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 20
        },

        // 74. IDS348 - DESARROLLO DE APLICACIONES WEB
        new SeccionHorario
        {
            IdSeccionHorario = 233,
            IdSeccion = 166,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 234,
            IdSeccion = 166,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 235,
            IdSeccion = 167,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 236,
            IdSeccion = 167,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 237,
            IdSeccion = 168,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 23
        },

        // 75. IDS348L - LABORATORIO DESARROLLO DE APLICACIONES WEB
        new SeccionHorario
        {
            IdSeccionHorario = 238,
            IdSeccion = 169,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 239,
            IdSeccion = 170,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 240,
            IdSeccion = 171,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 15
        },

        // 76. ING230 - INGENIERIA ECONOMICA
        new SeccionHorario
        {
            IdSeccionHorario = 241,
            IdSeccion = 172,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 242,
            IdSeccion = 172,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 243,
            IdSeccion = 173,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 25
        },

        // 77. ING231 - EXPERIMENTACION EN INGENIERIA
        new SeccionHorario
        {
            IdSeccionHorario = 244,
            IdSeccion = 174,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 245,
            IdSeccion = 174,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 246,
            IdSeccion = 175,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 7
        },
        new SeccionHorario
        {
            IdSeccionHorario = 247,
            IdSeccion = 175,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 7
        },
        #endregion

        #region Trimestre 10
        // 78. IDS326 - CONSTRUCCION DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 248,
            IdSeccion = 176,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 249,
            IdSeccion = 176,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 250,
            IdSeccion = 177,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 79. IDS326L - LABORATORIO CONSTRUCCION DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 251,
            IdSeccion = 178,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 252,
            IdSeccion = 179,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 5
        },

        // 80. IDS349 - DESARROLLO DE APLICACIONES MOVILES
        new SeccionHorario
        {
            IdSeccionHorario = 253,
            IdSeccion = 180,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 254,
            IdSeccion = 180,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 255,
            IdSeccion = 181,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 11
        },
        new SeccionHorario
        {
            IdSeccionHorario = 256,
            IdSeccion = 182,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 12
        },
        new SeccionHorario
        {
            IdSeccionHorario = 257,
            IdSeccion = 182,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 12
        },

        // 81. IDS349L - LABORATORIO DESARROLLO DE APLICACIONES MOVILES
        new SeccionHorario
        {
            IdSeccionHorario = 258,
            IdSeccion = 183,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 259,
            IdSeccion = 184,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 260,
            IdSeccion = 185,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 15
        },

        // 82. ING235 - FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS
        new SeccionHorario
        {
            IdSeccionHorario = 261,
            IdSeccion = 186,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 262,
            IdSeccion = 186,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 263,
            IdSeccion = 187,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 21
        },

        // 83. ING235L - LABORATORIO FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS
        new SeccionHorario
        {
            IdSeccionHorario = 264,
            IdSeccion = 188,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 6
        },
        new SeccionHorario
        {
            IdSeccionHorario = 265,
            IdSeccion = 189,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(11, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 7
        },

        // 84. INS371 - ARQUITECTURA DEL COMPUTADOR
        new SeccionHorario
        {
            IdSeccionHorario = 266,
            IdSeccion = 190,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 267,
            IdSeccion = 190,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 268,
            IdSeccion = 191,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 23
        },

        // 85. INS371L - LABORATORIO ARQUITECTURA COMPUTADOR
        new SeccionHorario
        {
            IdSeccionHorario = 269,
            IdSeccion = 192,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 270,
            IdSeccion = 193,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 5
        },

        // 86. ISE2E1 - IMPACTO SOCIAL (ELECTIVA)
        new SeccionHorario
        {
            IdSeccionHorario = 271,
            IdSeccion = 194,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 272,
            IdSeccion = 194,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 273,
            IdSeccion = 195,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 25
        },
        #endregion

        #region Trimestre 11
        // 87. ECO322 - ECONOMIA DE EMPRESA
        new SeccionHorario
        {
            IdSeccionHorario = 274,
            IdSeccion = 196,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 275,
            IdSeccion = 196,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 276,
            IdSeccion = 197,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 88. IDS328 - ADMINISTRACION DE CONFIGURACION
        new SeccionHorario
        {
            IdSeccionHorario = 277,
            IdSeccion = 198,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 278,
            IdSeccion = 198,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 279,
            IdSeccion = 199,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 11
        },

        // 89. IDS328L - LABORATORIO DE ADMINISTRACION DE CONFIGURACION
        new SeccionHorario
        {
            IdSeccionHorario = 280,
            IdSeccion = 200,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 281,
            IdSeccion = 201,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 5
        },

        // 90. IDS330 - INTELIGENCIA ARTIFICIAL
        new SeccionHorario
        {
            IdSeccionHorario = 282,
            IdSeccion = 202,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 283,
            IdSeccion = 202,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 284,
            IdSeccion = 203,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(7, 0),
            HoraFin = new TimeOnly(11, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 285,
            IdSeccion = 204,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 286,
            IdSeccion = 204,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 22
        },

        // 91. IDS330L - LABORATORIO INTELIGENCIA ARTIFICIAL
        new SeccionHorario
        {
            IdSeccionHorario = 287,
            IdSeccion = 205,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 288,
            IdSeccion = 206,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(11, 0),
            HoraFin = new TimeOnly(13, 0),
            IdAula = 5
        },
        new SeccionHorario
        {
            IdSeccionHorario = 289,
            IdSeccion = 207,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(18, 0),
            HoraFin = new TimeOnly(20, 0),
            IdAula = 15
        },

        // 92. IDS350 - CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE II
        new SeccionHorario
        {
            IdSeccionHorario = 290,
            IdSeccion = 208,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 291,
            IdSeccion = 209,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 6
        },

        // 93. IDS351 - PRUEBAS DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 292,
            IdSeccion = 210,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 293,
            IdSeccion = 210,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 294,
            IdSeccion = 211,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 11
        },

        // 94. INS373 - SISTEMAS OPERATIVOS
        new SeccionHorario
        {
            IdSeccionHorario = 295,
            IdSeccion = 212,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 296,
            IdSeccion = 212,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },
        new SeccionHorario
        {
            IdSeccionHorario = 297,
            IdSeccion = 213,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 24
        },

        // 95. INS373L - LABORATORIO SISTEMAS OPERATIVOS
        new SeccionHorario
        {
            IdSeccionHorario = 298,
            IdSeccion = 214,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 4
        },
        new SeccionHorario
        {
            IdSeccionHorario = 299,
            IdSeccion = 215,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(12, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 5
        },
        #endregion

        #region Trimestre 12
        // 96. ADM315 - ADMINISTRACION Y GESTION EMPRESARIAL
        new SeccionHorario
        {
            IdSeccionHorario = 300,
            IdSeccion = 216,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 301,
            IdSeccion = 216,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 302,
            IdSeccion = 217,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 97. EEE2X1 - ELECTIVAS DE ESTUDIOS ESPECIALIZADOS I
        new SeccionHorario
        {
            IdSeccionHorario = 303,
            IdSeccion = 218,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 304,
            IdSeccion = 218,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 305,
            IdSeccion = 219,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 4
        },

        // 98. ICS320 - FUNDAMENTOS DE CIBERSEGURIDAD
        new SeccionHorario
        {
            IdSeccionHorario = 306,
            IdSeccion = 220,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 307,
            IdSeccion = 220,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 308,
            IdSeccion = 221,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 11
        },

        // 99. IDS339 - DEVOPS Y DEVSECOPS
        new SeccionHorario
        {
            IdSeccionHorario = 309,
            IdSeccion = 222,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 12
        },
        new SeccionHorario
        {
            IdSeccionHorario = 310,
            IdSeccion = 222,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 12
        },
        new SeccionHorario
        {
            IdSeccionHorario = 311,
            IdSeccion = 223,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 13
        },

        // 100. IDS352 - ANTEPROYECTO DE GRADO
        new SeccionHorario
        {
            IdSeccionHorario = 312,
            IdSeccion = 224,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 313,
            IdSeccion = 224,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 314,
            IdSeccion = 225,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 21
        },

        // 101. IDS353 - PASANTIA PROFESIONAL I
        new SeccionHorario
        {
            IdSeccionHorario = 315,
            IdSeccion = 226,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 316,
            IdSeccion = 227,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },

        // 102. IDS354 - GESTION DE LA INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 317,
            IdSeccion = 228,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 318,
            IdSeccion = 228,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 319,
            IdSeccion = 229,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 25
        },
        #endregion

        #region Trimestre 13
        // 103. EEE2X2 - ELECTIVAS DE ESTUDIOS ESPECIALIZADOS II
        new SeccionHorario
        {
            IdSeccionHorario = 320,
            IdSeccion = 230,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 321,
            IdSeccion = 230,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 322,
            IdSeccion = 231,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 104. EEP3X1 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES I
        new SeccionHorario
        {
            IdSeccionHorario = 323,
            IdSeccion = 232,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 324,
            IdSeccion = 232,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 325,
            IdSeccion = 233,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 4
        },

        // 105. IDS322 - MANTENIMIENTO DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 326,
            IdSeccion = 234,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 327,
            IdSeccion = 234,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 328,
            IdSeccion = 235,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 11
        },

        // 106. IDS355 - PROYECTO DE GRADO
        new SeccionHorario
        {
            IdSeccionHorario = 329,
            IdSeccion = 236,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 330,
            IdSeccion = 237,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 21
        },

        // 107. IDS356 - PASANTIA PROFESIONAL II
        new SeccionHorario
        {
            IdSeccionHorario = 331,
            IdSeccion = 238,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 332,
            IdSeccion = 239,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 23
        },

        // 108. IDS3X5 - CERTIFICACION PROFESIONAL
        new SeccionHorario
        {
            IdSeccionHorario = 333,
            IdSeccion = 240,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 334,
            IdSeccion = 240,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 24
        },
        new SeccionHorario
        {
            IdSeccionHorario = 335,
            IdSeccion = 241,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 25
        },
        #endregion

        #region Trimestre 14
        // 109. EEP3X2 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES II
        new SeccionHorario
        {
            IdSeccionHorario = 336,
            IdSeccion = 242,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 337,
            IdSeccion = 242,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(10, 0),
            IdAula = 1
        },
        new SeccionHorario
        {
            IdSeccionHorario = 338,
            IdSeccion = 243,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 2
        },

        // 110. EEP3X3 - ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES III
        new SeccionHorario
        {
            IdSeccionHorario = 339,
            IdSeccion = 244,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 340,
            IdSeccion = 244,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 3
        },
        new SeccionHorario
        {
            IdSeccionHorario = 341,
            IdSeccion = 245,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(14, 0),
            IdAula = 4
        },

        // 111. IDS334 - SEMINARIO DE TECNOLOGIA E INGENIERIA DE SOFTWARE
        new SeccionHorario
        {
            IdSeccionHorario = 342,
            IdSeccion = 246,
            Dia = DiaSemana.Lunes,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 343,
            IdSeccion = 246,
            Dia = DiaSemana.Miercoles,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 10
        },
        new SeccionHorario
        {
            IdSeccionHorario = 344,
            IdSeccion = 247,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 11
        },

        // 112. IDS357 - PROYECTO FINAL DE GRADO
        new SeccionHorario
        {
            IdSeccionHorario = 345,
            IdSeccion = 248,
            Dia = DiaSemana.Martes,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 346,
            IdSeccion = 248,
            Dia = DiaSemana.Jueves,
            HoraInicio = new TimeOnly(16, 0),
            HoraFin = new TimeOnly(18, 0),
            IdAula = 20
        },
        new SeccionHorario
        {
            IdSeccionHorario = 347,
            IdSeccion = 248,
            Dia = DiaSemana.Viernes,
            HoraInicio = new TimeOnly(10, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 21
        },
        new SeccionHorario
        {
            IdSeccionHorario = 348,
            IdSeccion = 249,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(8, 0),
            HoraFin = new TimeOnly(12, 0),
            IdAula = 22
        },
        new SeccionHorario
        {
            IdSeccionHorario = 349,
            IdSeccion = 249,
            Dia = DiaSemana.Sabado,
            HoraInicio = new TimeOnly(14, 0),
            HoraFin = new TimeOnly(16, 0),
            IdAula = 22
        }
        #endregion
    };

}