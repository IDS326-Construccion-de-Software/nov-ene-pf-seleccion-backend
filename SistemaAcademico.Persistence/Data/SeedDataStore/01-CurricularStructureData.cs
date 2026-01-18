using System;
using System.Collections.Generic;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Persistence.Data;

public static class CurricularStructureData
{
    public static List<AreaAcademica> GetAreaAcademicas() => new()
    {
        new AreaAcademica { AreaAcademicaId = "ADM", AreaAcademicaNombre = "Administración" },
        new AreaAcademica { AreaAcademicaId = "AHC", AreaAcademicaNombre = "Comunicación y Lengua" },
        new AreaAcademica { AreaAcademicaId = "AHO", AreaAcademicaNombre = "Orientación" },
        new AreaAcademica { AreaAcademicaId = "AHQ", AreaAcademicaNombre = "Investigación Científica" },
        new AreaAcademica { AreaAcademicaId = "CBA", AreaAcademicaNombre = "Medio Ambiente" },
        new AreaAcademica { AreaAcademicaId = "CBF", AreaAcademicaNombre = "Física" },
        new AreaAcademica { AreaAcademicaId = "CBM", AreaAcademicaNombre = "Matemáticas Básicas" },
        new AreaAcademica { AreaAcademicaId = "CON", AreaAcademicaNombre = "Contabilidad" },
        new AreaAcademica { AreaAcademicaId = "CSH", AreaAcademicaNombre = "Ciencias Sociales y Humanidades" },
        new AreaAcademica { AreaAcademicaId = "EAA", AreaAcademicaNombre = "Electivas de Áreas Académicas" },
        new AreaAcademica { AreaAcademicaId = "ECO", AreaAcademicaNombre = "Economía" },
        new AreaAcademica { AreaAcademicaId = "EEE", AreaAcademicaNombre = "Electivas Especializadas" },
        new AreaAcademica { AreaAcademicaId = "EFP", AreaAcademicaNombre = "Electivas Profesionalizantes" },
        new AreaAcademica { AreaAcademicaId = "ICS", AreaAcademicaNombre = "Ciberseguridad" },
        new AreaAcademica { AreaAcademicaId = "IDS", AreaAcademicaNombre = "Ingeniería de Software" },
        new AreaAcademica { AreaAcademicaId = "IEC", AreaAcademicaNombre = "Electrónica" },
        new AreaAcademica { AreaAcademicaId = "ING", AreaAcademicaNombre = "Ingeniería" },
        new AreaAcademica { AreaAcademicaId = "INS", AreaAcademicaNombre = "Computación y Sistemas" },
        new AreaAcademica { AreaAcademicaId = "ISE", AreaAcademicaNombre = "Innovación Social" },
        new AreaAcademica { AreaAcademicaId = "SHI", AreaAcademicaNombre = "Inglés" }
    };

    public static List<Carrera> GetCarreras() => new()
    {
        new Carrera
        {
            CarreraId = 1,
            Nombre = "Ingenieria de Software",
            Nomenclatura = "IDS",
            IdAreaAcademica = "ING"
        }
    };

    public static List<Asignatura> GetAsignaturas() => new()
    {   
        #region Trimestre 1
        new Asignatura
        {
            AsignaturaId = "AHC109",
            Nombre = "REDACCION",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "AHC"
        },
        new Asignatura
        {
            AsignaturaId = "AHO102",
            Nombre = "ORIENTACION ACADEMICA E INSTITUCIONAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "AHO"
        },
        new Asignatura
        {
            AsignaturaId = "CBA1X3",
            Nombre = "VIDA EN EL MEDIO AMBIENTE (ELECTIVAS)",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "CBA"
        },
        new Asignatura
        {
            AsignaturaId = "CBM101",
            Nombre = "ALGEBRA Y GEOMETRIA ANALITICA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "CSH112",
            Nombre = "CIUDADANIA Y ETICA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CSH"
        },
        new Asignatura
        {
            AsignaturaId = "EAA1X1",
            Nombre = "ELECTIVAS DE AREAS ACADEMICAS I",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EAA"
        },
        new Asignatura
        {
            AsignaturaId = "EAA1X2",
            Nombre = "ELECTIVAS DE AREAS ACADEMICAS II",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EAA"
        },
        new Asignatura
        {
            AsignaturaId = "EAA1X3",
            Nombre = "ELECTIVAS DE AREAS ACADEMICAS III",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EAA"
        },
        new Asignatura
        {
            AsignaturaId = "IDS207",
            Nombre = "INTRODUCCION A LA INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "SHI103",
            Nombre = "INGLES 01 (BASICO I)",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 2
        
        new Asignatura
        {
            AsignaturaId = "AHC110",
            Nombre = "ARGUMENTACIÓN LINGÜÍSTICA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "AHC"
        },
        new Asignatura
        {
            AsignaturaId = "CBM102",
            Nombre = "CALCULO DIFERENCIAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "CSS102",
            Nombre = "SER HUMANO Y SOCIEDAD: TEMAS SOCIALES CONTEMPORANEOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CSH"
        },
        new Asignatura
        {
            AsignaturaId = "EAA1X4",
            Nombre = "ELECTIVAS DE AREAS ACADEMICAS IV",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EAA"
        },
        new Asignatura
        {
            AsignaturaId = "IDS323",
            Nombre = "TECNICAS FUNDAMENTALES DE INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS323L",
            Nombre = "LABORATORIO TECNICAS FUNDAMENTALES DE INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "ING102",
            Nombre = "INTRODUCCION A LA PROGRAMACION",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "ING102L",
            Nombre = "LABORATORIO DE INTRODUCCION A LA PROGRAMACION",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "SHI104",
            Nombre = "INGLES 02 (BASICO II) (3)",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 3
        new Asignatura
        {
            AsignaturaId = "CBF210",
            Nombre = "FISICA MECANICA I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBF"
        },
        new Asignatura
        {
            AsignaturaId = "CBF210L",
            Nombre = "LABORATORIO DE FISICA MECANICA I",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "CBF"
        },
        new Asignatura
        {
            AsignaturaId = "CBM201",
            Nombre = "CALCULO INTEGRAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "IDS202",
            Nombre = "TECNOLOGIA DE OBJETOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS202L",
            Nombre = "LABORATORIO TECNOLOGIA DE OBJETOS",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS340",
            Nombre = "DESARROLLO DE SOFTWARE I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS340L",
            Nombre = "LABORATORIO DE DESARROLLO DE SOFTWARE I",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "ING228",
            Nombre = "HOJA DE CALCULO PARA INGENIEROS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "SHI105",
            Nombre = "INGLES 03 (INTERMEDIO I)",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 4
        new Asignatura
        {
            AsignaturaId = "AHQ101",
            Nombre = "QUEHACER CIENTIFICO",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "AHQ"
        },
        new Asignatura
        {
            AsignaturaId = "CBF211",
            Nombre = "FISICA MECANICA II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBF"
        },
        new Asignatura
        {
            AsignaturaId = "CBF211L",
            Nombre = "LABORATORIO DE FISICA MECANICA II",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "CBF"
        },
        new Asignatura
        {
            AsignaturaId = "CBM202",
            Nombre = "CALCULO VECTORIAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "CSH113",
            Nombre = "PENSAMIENTO CREATIVO",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CSH"
        },
        new Asignatura
        {
            AsignaturaId = "IDS341",
            Nombre = "DESARROLLO DE SOFTWARE II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS341L",
            Nombre = "LABORATORIO DE DESARROLLO DE SOFTWARE II",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS342",
            Nombre = "CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "SHI106",
            Nombre = "INGLES 04 (INTERMEDIO II)",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 5
        new Asignatura
        {
            AsignaturaId = "CBM208",
            Nombre = "ALGEBRA LINEAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "IDS208",
            Nombre = "TEAM BUILDING",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS311",
            Nombre = "PROCESO DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS324",
            Nombre = "INGENIERIA DE REQUERIMIENTOS DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS324L",
            Nombre = "LABORATORIO INGENIERIA DE REQUERIMIENTOS DE SOFT",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS343",
            Nombre = "ESTRUCTURAS DE DATOS Y ALGORITMOS I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS343L",
            Nombre = "LABORATORIO ESTRUCTURAS DE DATOS Y ALGORITMOS I",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "SHI107",
            Nombre = "INGLES 05 (AVANZADO I)",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 6
        new Asignatura
        {
            AsignaturaId = "CBM203",
            Nombre = "ECUACIONES DIFERENCIALES",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "CSH105",
            Nombre = "PROYECTO INTEGRADOR DE ESTUDIOS GENERALES",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CSH"
        },
        new Asignatura
        {
            AsignaturaId = "IDS344",
            Nombre = "ESTRUCTURAS DE DATOS Y ALGORITMOS II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS344L",
            Nombre = "LABORATORIO ESTRUCTURAS DE DATOS Y ALGORITMOS II",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IEC208",
            Nombre = "FUNDAMENTOS ELECTRÓNICA DIGITAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IEC"
        },
        new Asignatura
        {
            AsignaturaId = "IEC208L",
            Nombre = "LABORATORIO FUNDAMENTOS ELECTRÓNICA DIGITAL",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IEC"
        },
        new Asignatura
        {
            AsignaturaId = "INS377",
            Nombre = "BASES DE DATOS I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "INS377L",
            Nombre = "LABORATORIO BASES DE DATOS I",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "SHI108",
            Nombre = "INGLES 06 (AVANZADO II)",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "SHI"
        },
        #endregion
        #region Trimestre 7
        new Asignatura
        {
            AsignaturaId = "CBM305",
            Nombre = "MATEMATICA DISCRETA I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CBM"
        },
        new Asignatura
        {
            AsignaturaId = "IDS329",
            Nombre = "INGENIERIA DE FACTORES HUMANOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS329L",
            Nombre = "LABORATORIO INGENIERIA DE FACTORES HUMANOS",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS345",
            Nombre = "DESARROLLO DE SOFTWARE III",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS345L",
            Nombre = "LABORATORIO DE DESARROLLO DE SOFTWARE III",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS346",
            Nombre = "MODELOS Y METODOS DE LA INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "INS380",
            Nombre = "BASES DE DATOS II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "INS380L",
            Nombre = "LABORATORIO DE BASES DE DATOS II",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "INS"
        },
        #endregion
        #region Trimestre 8
        new Asignatura
        {
            AsignaturaId = "ICS202",
            Nombre = "ALGORITMOS MALICIOSOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ICS"
        },
        new Asignatura
        {
            AsignaturaId = "ICS202L",
            Nombre = "LABORATORIO DE ALGORITMOS MALICIOSOS",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "ICS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS325",
            Nombre = "ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS325L",
            Nombre = "LABORATORIO ASEGURAMIENTO DE LA CALIDAD DEL SOFTWARE",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS335",
            Nombre = "DISEÑO DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS347",
            Nombre = "TENDENCIAS EN DESARROLLO DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS347L",
            Nombre = "LABORATORIO TENDENCIAS EN DESARROLLO DE SOFTWARE",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "ING214",
            Nombre = "ANALISIS DE DATOS EN INGENIERIA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        #endregion
        #region Trimestre 9
        // Trimestre 9
        new Asignatura
        {
            AsignaturaId = "CON213",
            Nombre = "FUNDAMENTOS DE CONTABILIDAD",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "CON"
        },
        new Asignatura
        {
            AsignaturaId = "IDS303",
            Nombre = "PRACTICA PROFESIONAL DE INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS309",
            Nombre = "ARQUITECTURA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS348",
            Nombre = "DESARROLLO DE APLICACIONES WEB",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS348L",
            Nombre = "LABORATORIO DESARROLLO DE APLICACIONES WEB",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "ING230",
            Nombre = "INGENIERIA ECONOMICA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "ING231",
            Nombre = "EXPERIMENTACION EN INGENIERIA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        #endregion
        #region Trimestre 10
        // Trimestre 10
        new Asignatura
        {
            AsignaturaId = "IDS326",
            Nombre = "CONSTRUCCION DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS326L",
            Nombre = "LABORATORIO CONSTRUCCION DE SOFTWARE",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS349",
            Nombre = "DESARROLLO DE APLICACIONES MOVILES",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS349L",
            Nombre = "LABORATORIO DESARROLLO DE APLICACIONES MOVILES",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "ING235",
            Nombre = "FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "ING235L",
            Nombre = "LABORATORIO FORMULACION Y GESTION DE PROYECTOS TECNOLOGICOS",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "ING"
        },
        new Asignatura
        {
            AsignaturaId = "INS371",
            Nombre = "ARQUITECTURA DEL COMPUTADOR",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "INS371L",
            Nombre = "LABORATORIO ARQUITECTURA COMPUTADOR",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "ISE2E1",
            Nombre = "IMPACTO SOCIAL (ELECTIVA)",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "ISE"
        },
        #endregion
        #region Trimestre 11
        new Asignatura
        {
            AsignaturaId = "ECO322",
            Nombre = "ECONOMIA DE EMPRESA",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ECO"
        },
        new Asignatura
        {
            AsignaturaId = "IDS328",
            Nombre = "ADMINISTRACION DE CONFIGURACION",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS328L",
            Nombre = "LABORATORIO DE ADMINISTRACION DE CONFIGURACION",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS330",
            Nombre = "INTELIGENCIA ARTIFICIAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS330L",
            Nombre = "LABORATORIO INTELIGENCIA ARTIFICIAL",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS350",
            Nombre = "CONSEJERIA PROFESIONAL INGENIERIA DE SOFTWARE II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS351",
            Nombre = "PRUEBAS DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "INS373",
            Nombre = "SISTEMAS OPERATIVOS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "INS"
        },
        new Asignatura
        {
            AsignaturaId = "INS373L",
            Nombre = "LABORATORIO SISTEMAS OPERATIVOS",
            Tipo = TipoAsignatura.Laboratorio,
            IdAreaAcademica = "INS"
        },
        #endregion
        #region Trimestre 12
        new Asignatura
        {
            AsignaturaId = "ADM315",
            Nombre = "ADMINISTRACION Y GESTION EMPRESARIAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ADM"
        },
        new Asignatura
        {
            AsignaturaId = "EEE2X1",
            Nombre = "ELECTIVAS DE ESTUDIOS ESPECIALIZADOS I",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EEE"
        },
        new Asignatura
        {
            AsignaturaId = "ICS320",
            Nombre = "FUNDAMENTOS DE CIBERSEGURIDAD",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "ICS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS339",
            Nombre = "DEVOPS Y DEVSECOPS",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS352",
            Nombre = "ANTEPROYECTO DE GRADO",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS353",
            Nombre = "PASANTIA PROFESIONAL I",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS354",
            Nombre = "GESTION DE LA INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        #endregion
        #region Trimestre 13
        // Trimestre 13
        new Asignatura
        {
            AsignaturaId = "EEE2X2",
            Nombre = "ELECTIVAS DE ESTUDIOS ESPECIALIZADOS II",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EEE"
        },
        new Asignatura
        {
            AsignaturaId = "EEP3X1",
            Nombre = "ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES I",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EFP"
        },
        new Asignatura
        {
            AsignaturaId = "IDS322",
            Nombre = "MANTENIMIENTO DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS355",
            Nombre = "PROYECTO DE GRADO",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS356",
            Nombre = "PASANTIA PROFESIONAL II",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS3X5",
            Nombre = "CERTIFICACION PROFESIONAL",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        #endregion
        #region Trimestre 14
        new Asignatura
        {
            AsignaturaId = "EEP3X2",
            Nombre = "ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES II",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EFP"
        },
        new Asignatura
        {
            AsignaturaId = "EEP3X3",
            Nombre = "ELECTIVAS DE ESTUDIOS PROFESIONALIZANTES III",
            Tipo = TipoAsignatura.Electiva,
            IdAreaAcademica = "EFP"
        },
        new Asignatura
        {
            AsignaturaId = "IDS334",
            Nombre = "SEMINARIO DE TECNOLOGIA E INGENIERIA DE SOFTWARE",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        new Asignatura
        {
            AsignaturaId = "IDS357",
            Nombre = "PROYECTO FINAL DE GRADO",
            Tipo = TipoAsignatura.Teoría,
            IdAreaAcademica = "IDS"
        },
        #endregion
    };

    public static List<ProgramaAcademico> GetProgramaAcademicos() => new()
    {
        new ProgramaAcademico
        {
            ProgramaAcademicoId = 1,
            Periodo = "2020",
            Estatus = EstatusPrograma.Activo,
            TotalCreditos = 279,
            TrimestresMaximos = 24,
            IdCarrera = 1,
        }
    };

    public static List<AsignaturaProgramaAcademico> GetAsignaturaProgramaAcademicos() => new()
    {
        #region Trimestre 1
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "AHC109",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "AHO102", "CBA1X3" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "AHO102",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBA1X3",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM101",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 5,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CSH112",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EAA1X1",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EAA1X2",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EAA1X3",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS207",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI103",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 1
        },
        #endregion
        #region Trimestre 2
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "AHC110",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "AHC109" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM102",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM101" },
            Corequisito = null,
            Creditos = 5,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CSS102",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> (),
            Corequisito = null,
            Creditos = 2,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EAA1X4",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> (),
            Corequisito = null,
            Creditos = 2,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS323",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS207" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS323L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS207" },
            Corequisito = "IDS323",
            Creditos = 4,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING102",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM101" },
            Corequisito = null,
            Creditos = 2,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING102L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM101" },
            Corequisito = "ING102",
            Creditos = 0,
            Periodo = 2
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI104",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "SHI103" },
            Corequisito = null,
            Creditos = 0,
            Periodo = 2
        },
        #endregion
        #region Trimestre 3
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBF210",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM102" },
            Corequisito = "CBM201",
            Creditos = 4,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBF210L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM102", },
            Corequisito = "CBF210",
            Creditos = 1,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM201",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM102" },
            Corequisito = null,
            Creditos = 5,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS202",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING102", "ING102L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS202L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING102", "ING102L" },
            Corequisito = "IDS202",
            Creditos = 1,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS340",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> (),
            Corequisito = null,
            Creditos = 3,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS340L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING102", "ING102L" },
            Corequisito = "IDS340",
            Creditos = 1,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING228",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING102", "ING102L" },
            Corequisito = null,
            Creditos = 1,
            Periodo = 3
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI105",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "SHI104" },
            Corequisito = null,
            Creditos = 0,
            Periodo = 3
        },
        #endregion
        #region Trimestre 4
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "AHQ101",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBF211",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBF210", "CBM201", "CBF210L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBF211L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBF210", "CBM201", "CBF210L" },
            Corequisito = "CBF211",
            Creditos = 1,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM202",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM201" },
            Corequisito = null,
            Creditos = 5,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CSH113",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS341",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS340", "IDS340L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS341L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS340", "IDS340L" },
            Corequisito = "IDS341",
            Creditos = 1,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS342",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 4
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI106",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "SHI105" },
            Corequisito = null,
            Creditos = 0,
            Periodo = 4
        },
        #endregion
        #region Trimestre 5
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM208",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM202" },
            Corequisito = null,
            Creditos = 5,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS208",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS311",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS323", "IDS323L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS324",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS202", "IDS202L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS324L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS202", "IDS202L" },
            Corequisito = "IDS324",
            Creditos = 1,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS343",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS340", "IDS340L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS343L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS340", "IDS340L" },
            Corequisito = "IDS343",
            Creditos = 1,
            Periodo = 5
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI107",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "SHI106" },
            Corequisito = null,
            Creditos = 0,
            Periodo = 5
        },
        #endregion
        #region Trimestre 6
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM203",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM208" },
            Corequisito = null,
            Creditos = 5,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CSH105",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS344",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS343", "IDS343L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS344L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS343", "IDS343L" },
            Corequisito = "IDS344",
            Creditos = 1,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IEC208",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBF211", "CBF211L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IEC208L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBF211", "CBF211L" },
            Corequisito = "IEC208",
            Creditos = 1,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS377",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS324L", "IDS343", "IDS343L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS377L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS343", "IDS324L", "IDS343L" },
            Corequisito = "INS377",
            Creditos = 1,
            Periodo = 6
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "SHI108",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "SHI107" },
            Corequisito = null,
            Creditos = 0,
            Periodo = 6
        },
        #endregion
        #region Trimestre 7
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CBM305",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "CBM203" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS329",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS324L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS329L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS324L" },
            Corequisito = "IDS329",
            Creditos = 1,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS345",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS341", "IDS341L", "INS377", "INS377L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS345L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS341", "IDS341L", "INS377", "INS377L" },
            Corequisito = "IDS345",
            Creditos = 1,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS346",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS202", "IDS202L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS380",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS377", "INS377L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 7
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS380L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS377", "INS377L" },
            Corequisito = "INS380",
            Creditos = 1,
            Periodo = 7
        },
        #endregion
        #region Trimestre 8
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ICS202",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ICS202L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null, // Vacío en la imagen
            Creditos = 1,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS325",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS324L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS325L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS324", "IDS324L" },
            Corequisito = "IDS325",
            Creditos = 1,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS335",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS329", "IDS329L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS347",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS345", "IDS345L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS347L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS345", "IDS345L" },
            Corequisito = null, // Vacío en la imagen
            Creditos = 1,
            Periodo = 8
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING214",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 8
        },
        #endregion
        #region Trimestre 9
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "CON213",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS303",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS309",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS335" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS348",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS345", "IDS345L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS348L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS345", "IDS345L" },
            Corequisito = "IDS348",
            Creditos = 1,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING230",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 9
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING231",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "AHQ101", "ING214" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 9
        },
        #endregion
        #region Trimestre 10
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS326",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS309" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS326L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS309" },
            Corequisito = "IDS326",
            Creditos = 1,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS349",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS348", "IDS348L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS349L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS348", "IDS348L" },
            Corequisito = "IDS349",
            Creditos = 1,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING235",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING230", "ING231" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ING235L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING230", "ING231" },
            Corequisito = "ING235",
            Creditos = 1,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS371",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IEC208", "IEC208L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS371L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IEC208", "IEC208L" },
            Corequisito = "INS371",
            Creditos = 1,
            Periodo = 10
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ISE2E1",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 10
        },
        #endregion
        #region Trimestre 11
        // Trimestre 11
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ECO322",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ING230" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS328",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS326", "IDS326L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS328L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS326", "IDS326L" },
            Corequisito = "IDS328",
            Creditos = 1,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS330",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS326", "IDS326L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS330L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS326", "IDS326L" },
            Corequisito = "IDS330",
            Creditos = 1,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS350",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS351",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS325", "IDS325L", "IDS326", "IDS326L" },
            Corequisito = null,
            Creditos = 2,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS373",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS371", "INS371L" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 11
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "INS373L",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS371", "INS371L" },
            Corequisito = "INS373",
            Creditos = 1,
            Periodo = 11
        },
        #endregion
        #region Trimestre 12
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ADM315",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "ECO322" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EEE2X1",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "ICS320",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS371", "INS371L" },
            Corequisito = null,
            Creditos = 2,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS339",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "INS373", "INS373L" },
            Corequisito = null,
            Creditos = 3,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS352",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> 
            { 
                "IDS309", "INS371", "INS371L", "IDS325", "IDS325L", 
                "IDS326", "IDS326L", "ING235", "ING235L" 
            },
            Corequisito = null,
            Creditos = 4,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS353",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 12
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS354",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 3,
            Periodo = 12
        },
        #endregion
        #region Trimestre 13
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EEE2X2",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 2,
            Periodo = 13
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EEP3X1",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 13
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS322",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS326", "IDS326L", "IDS352" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 13
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS355",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS352" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 13
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS356",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS353" },
            Corequisito = null,
            Creditos = 2,
            Periodo = 13
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS3X5",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 13
        },
        #endregion
        #region Trimestre 14
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EEP3X2",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 14
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "EEP3X3",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 0,
            Periodo = 14
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS334",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string>(),
            Corequisito = null,
            Creditos = 4,
            Periodo = 14
        },
        new AsignaturaProgramaAcademico
        {
            IdAsignatura = "IDS357",
            IdProgramaAcademico = 1,
            PreRequisitos = new List<string> { "IDS355" },
            Corequisito = null,
            Creditos = 4,
            Periodo = 14
        },
        #endregion
    };

}