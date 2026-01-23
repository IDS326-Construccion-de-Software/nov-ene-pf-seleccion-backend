using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.Professor.Core.DTOs;
using SistemaAcademico.Professor.Core.Interfaces;

namespace SistemaAcademico.Professor.Infrastructure.Persistence.Repositories;

public class ProfessorRepository : IProfessorRepository
{
    private readonly SistemaAcademicoContext _db;

    public ProfessorRepository(SistemaAcademicoContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<ProfessorSectionDto>> GetProfessorSectionsForLatestPeriodAsync(int professorUserId)
    {
        var latestPeriod = await _db.PeriodoConfigs
            .AsNoTracking()
            .OrderByDescending(p => p.Id)
            .FirstOrDefaultAsync();

        if (latestPeriod == null)
        {
            return Enumerable.Empty<ProfessorSectionDto>();
        }

        var query =
            from s in _db.Seccions.AsNoTracking()
            join a in _db.Asignaturas.AsNoTracking() on s.IdAsignatura equals a.AsignaturaId
            where s.IdProfesor == professorUserId
                  && s.PeriodoAcademico == latestPeriod.Codigo
            select new ProfessorSectionDto
            {
                SectionId = s.SeccionId,
                PeriodCode = s.PeriodoAcademico,
                CourseCode = a.AsignaturaId,
                CourseName = a.Nombre,
                SectionNumber = s.NumeroSeccion,
                Capacity = s.Cupo,
                AvailableSeats = s.CupoDisponible,
                Status = s.Estatus.ToString(),
                Modality = s.Modalidad.ToString()
            };

        return await query.ToListAsync();
    }

    public async Task<IEnumerable<SectionStudentDto>> GetSectionStudentsAsync(int professorUserId, int sectionId)
    {
        var section = await _db.Seccions
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.SeccionId == sectionId);

        if (section == null)
        {
            throw new KeyNotFoundException("La sección no existe.");
        }

        if (section.IdProfesor != professorUserId)
        {
            throw new UnauthorizedAccessException("No tienes acceso a esta sección.");
        }

        // Tomamos IdPeriodo desde Seleccion (fuente de matrícula/periodo real) y le hacemos LEFT JOIN a HistorialAcademico para traer notas si existen.
        var query =
            from sel in _db.Seleccions.AsNoTracking()
            join u in _db.Usuarios.AsNoTracking() on sel.IdUsuario equals u.IdUsuario

            join h in _db.HistorialAcademicos.AsNoTracking()
                on new { sel.IdUsuario, IdAsignatura = section.IdAsignatura, sel.IdPeriodo }
                equals new { h.IdUsuario, h.IdAsignatura, h.IdPeriodo }
                into hJoin
            from h in hJoin.DefaultIfEmpty()

            where sel.IdSeccion == sectionId
                  && sel.Activa == true
            select new SectionStudentDto
            {
                StudentId = u.IdUsuario,
                FullName = u.Nombre + " " + u.Apellido,
                InstitutionalEmail = u.CorreoInstitucional,
                SelectionStatus = sel.EstatusAcademico.ToString(),

                FinalGrade = h != null ? h.Calificacion : null,
                MidtermGrade = h != null ? h.CalificacionMediotermino : null
            };

        return await query.ToListAsync();
    }

    public async Task PublishFinalGradesAsync(int professorUserId, int sectionId, IReadOnlyList<(int studentId, decimal grade)> grades)
    {
        var section = await _db.Seccions
            .FirstOrDefaultAsync(s => s.SeccionId == sectionId);

        if (section == null)
        {
            throw new KeyNotFoundException("La sección no existe.");
        }

        if (section.IdProfesor != professorUserId)
        {
            throw new UnauthorizedAccessException("No tienes acceso a esta sección.");
        }

        // Encontrar el período por el código en Seccion.PeriodoAcademico
        var period = await _db.PeriodoConfigs
            .FirstOrDefaultAsync(p => p.Codigo == section.PeriodoAcademico);

        if (period == null)
        {
            throw new InvalidOperationException("No se encontró el período asociado a la sección.");
        }

        // Validación de fecha límite de publicación final
        var now = DateTime.Now;
        if (now > period.FechaLimitePublicacionFinal)
        {
            throw new InvalidOperationException("La fecha límite para publicar calificaciones finales ya expiró.");
        }

        // Selecciones reales (para validar pertenencia de estudiantes + obtener IdPeriodo de cada matrícula)
        var selectionsInSection = await _db.Seleccions
            .Where(s => s.IdSeccion == sectionId && s.Activa == true)
            .ToListAsync();

        if (selectionsInSection.Count == 0)
        {
            throw new InvalidOperationException("No hay estudiantes matriculados en esta sección.");
        }

        var selectionByStudent = selectionsInSection.ToDictionary(x => x.IdUsuario, x => x);

        // Validación: solo estudiantes pertenecientes a la sección
        var invalidStudents = grades
            .Where(g => !selectionByStudent.ContainsKey(g.studentId))
            .Select(g => g.studentId)
            .Distinct()
            .ToList();

        if (invalidStudents.Count > 0)
        {
            throw new InvalidOperationException($"Estudiantes no pertenecen a la sección: {string.Join(", ", invalidStudents)}");
        }

        foreach (var (studentId, grade) in grades)
        {
            var sel = selectionByStudent[studentId];

            // Si el estudiante está retirado, lo registramos como Retirado y no forzamos nota.
            var isWithdrawn = sel.EstatusAcademico == SeleccionEstatus.Retirado;

            var historial = await _db.HistorialAcademicos
                .FirstOrDefaultAsync(h =>
                    h.IdUsuario == studentId &&
                    h.IdAsignatura == section.IdAsignatura &&
                    h.IdPeriodo == sel.IdPeriodo);

            if (historial == null)
            {
                historial = new HistorialAcademico
                {
                    IdUsuario = studentId,
                    IdAsignatura = section.IdAsignatura,
                    IdPeriodo = sel.IdPeriodo,
                    FechaRegistro = DateTime.Now,
                };

                _db.HistorialAcademicos.Add(historial);
            }

            historial.Calificacion = isWithdrawn ? null : grade;
            historial.Estatus = isWithdrawn
                ? HistorialEstatus.Retirado
                : (grade >= 70 ? HistorialEstatus.Aprobado : HistorialEstatus.Reprobado);

            historial.FechaRegistro = DateTime.Now;

            // “Publicado”: en tu modelo no existe un enum "Publicado".
            // Usamos SeleccionEstatus.Procesado como equivalente (publicado/procesado por profesor).
            if (!isWithdrawn)
            {
                sel.EstatusAcademico = SeleccionEstatus.Procesado;
            }
        }

        await _db.SaveChangesAsync();
    }

    public async Task PublishMidtermGradesAsync(int professorUserId, int sectionId, IReadOnlyList<(int studentId, decimal grade)> grades)
    {
        var section = await _db.Seccions
            .FirstOrDefaultAsync(s => s.SeccionId == sectionId);

        if (section == null)
            throw new KeyNotFoundException("La sección no existe.");

        if (section.IdProfesor != professorUserId)
            throw new UnauthorizedAccessException("No tienes acceso a esta sección.");

        var period = await _db.PeriodoConfigs
            .FirstOrDefaultAsync(p => p.Codigo == section.PeriodoAcademico);

        if (period == null)
            throw new InvalidOperationException("No se encontró el período asociado a la sección.");

        // Validación de fecha límite de publicación de MEDIO TÉRMINO
        var now = DateTime.Now;
        if (now > period.FechaLimitePublicacionMedioTermino)
            throw new InvalidOperationException("La fecha límite para publicar calificaciones de medio término ya expiró.");

        var selectionsInSection = await _db.Seleccions
            .Where(s => s.IdSeccion == sectionId && s.Activa == true)
            .ToListAsync();

        if (selectionsInSection.Count == 0)
            throw new InvalidOperationException("No hay estudiantes matriculados en esta sección.");

        var selectionByStudent = selectionsInSection.ToDictionary(x => x.IdUsuario, x => x);

        // Validación: solo estudiantes pertenecientes a la sección
        var invalidStudents = grades
            .Where(g => !selectionByStudent.ContainsKey(g.studentId))
            .Select(g => g.studentId)
            .Distinct()
            .ToList();

        if (invalidStudents.Count > 0)
            throw new InvalidOperationException($"Estudiantes no pertenecen a la sección: {string.Join(", ", invalidStudents)}");

        foreach (var (studentId, grade) in grades)
        {
            var sel = selectionByStudent[studentId];

            var isWithdrawn = sel.EstatusAcademico == SeleccionEstatus.Retirado;

            var historial = await _db.HistorialAcademicos
                .FirstOrDefaultAsync(h =>
                    h.IdUsuario == studentId &&
                    h.IdAsignatura == section.IdAsignatura &&
                    h.IdPeriodo == sel.IdPeriodo);

            if (historial == null)
            {
                historial = new HistorialAcademico
                {
                    IdUsuario = studentId,
                    IdAsignatura = section.IdAsignatura,
                    IdPeriodo = sel.IdPeriodo,
                    FechaRegistro = DateTime.Now,
                };

                _db.HistorialAcademicos.Add(historial);
            }

            historial.CalificacionMediotermino = isWithdrawn ? null : grade;


            if (isWithdrawn)
            {
                historial.Estatus = HistorialEstatus.Retirado;
            }

            historial.FechaRegistro = DateTime.Now;

        }

        await _db.SaveChangesAsync();
    }

}
