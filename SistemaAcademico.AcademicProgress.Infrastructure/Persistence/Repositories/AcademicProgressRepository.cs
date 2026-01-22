using Microsoft.EntityFrameworkCore;
using SistemaAcademico.AcademicProgress.Core.Entities;
using SistemaAcademico.AcademicProgress.Core.Interfaces;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.Persistence.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicProgress.Infrastructure.Persistence.Repositories
{
    public class AcademicProgressRepository : IAcademicProgressRepository
    {
        private readonly SistemaAcademicoContext _dbContext;

        public AcademicProgressRepository(SistemaAcademicoContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<GradeInfo>> GetGradesForStudentAsync(int estudianteId)
        {
            var studentProgram = await _dbContext.UsuarioProgramaAcademicos
                .FirstOrDefaultAsync(upa => upa.IdUsuario == estudianteId && upa.Estatus == "Activo");

            if (studentProgram == null) return Enumerable.Empty<GradeInfo>();

            var statesToInclude = new[] { HistorialEstatus.Aprobado, HistorialEstatus.Reprobado };

            return await _dbContext.HistorialAcademicos
                .Where(h => h.IdUsuario == estudianteId && h.Calificacion.HasValue && statesToInclude.Contains(h.Estatus))
                .Join(_dbContext.AsignaturaProgramaAcademicos,
                      hist => new { IdAsignatura = hist.IdAsignatura, IdProgramaAcademico = studentProgram.IdProgramaAcademico },
                      apa => new { IdAsignatura = apa.IdAsignatura, IdProgramaAcademico = apa.IdProgramaAcademico },
                      (hist, apa) => new GradeInfo
                      {
                          Nota = (int)hist.Calificacion.Value,
                          Creditos = apa.Creditos,
                          PeriodoAcademico = hist.IdPeriodoNavigation.Codigo
                      })
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<CourseDetailInfo>> GetGradesByPeriodAsync(int studentId, string period, IEnumerable<HistorialEstatus> states)
        {
            var studentProgram = await _dbContext.UsuarioProgramaAcademicos
                .FirstOrDefaultAsync(upa => upa.IdUsuario == studentId && upa.Estatus == "Activo");

            if (studentProgram == null) return Enumerable.Empty<CourseDetailInfo>();

            return await _dbContext.HistorialAcademicos
                .Where(h => h.IdUsuario == studentId && h.IdPeriodoNavigation.Codigo == period && states.Contains(h.Estatus))
                .Join(_dbContext.AsignaturaProgramaAcademicos,
                      hist => new { IdAsignatura = hist.IdAsignatura, IdProgramaAcademico = studentProgram.IdProgramaAcademico },
                      apa => new { IdAsignatura = apa.IdAsignatura, IdProgramaAcademico = apa.IdProgramaAcademico },
                      (hist, apa) => new { hist, apa })
                .Join(_dbContext.Usuarios,
                      joined => joined.hist.IdUsuario,
                      user => user.IdUsuario,
                      (joined, user) => new CourseDetailInfo
                      {
                          CourseCode = joined.hist.IdAsignatura, // Correctly mapped
                          CourseName = joined.hist.IdAsignaturaNavigation.Nombre,
                          Credits = joined.apa.Creditos,
                          FinalGrade = (int?)joined.hist.Calificacion,
                          MidtermGrade = (int?)joined.hist.CalificacionMediotermino,
                          StudentName = user.Nombre + " " + user.Apellido,
                          Status = joined.hist.Estatus
                      })
                .ToListAsync();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<StudentCourseHistoryInfo>> GetAllCompletedCoursesForStudentAsync(int studentId)
        {
            var studentProgram = await _dbContext.UsuarioProgramaAcademicos
                .Include(upa => upa.IdProgramaAcademicoNavigation.IdCarreraNavigation)
                .FirstOrDefaultAsync(upa => upa.IdUsuario == studentId && upa.Estatus == "Activo");

            if (studentProgram?.IdProgramaAcademicoNavigation?.IdCarreraNavigation == null)
            {
                return Enumerable.Empty<StudentCourseHistoryInfo>();
            }

            var statesToInclude = new[] { HistorialEstatus.Aprobado, HistorialEstatus.Reprobado, HistorialEstatus.Retirado, HistorialEstatus.Cursando };

            return await _dbContext.HistorialAcademicos
                .Where(h => h.IdUsuario == studentId && statesToInclude.Contains(h.Estatus))
                .Join(_dbContext.AsignaturaProgramaAcademicos,
                      hist => new { IdAsignatura = hist.IdAsignatura, IdProgramaAcademico = studentProgram.IdProgramaAcademico },
                      apa => new { IdAsignatura = apa.IdAsignatura, IdProgramaAcademico = apa.IdProgramaAcademico },
                      (hist, apa) => new StudentCourseHistoryInfo
                      {
                          StudentId = hist.IdUsuario,
                          StudentName = hist.IdUsuarioNavigation.Nombre + " " + hist.IdUsuarioNavigation.Apellido,
                          ProgramName = $"{studentProgram.IdProgramaAcademicoNavigation.IdCarreraNavigation.Nombre} ({studentProgram.IdProgramaAcademicoNavigation.Periodo})",
                          Period = hist.IdPeriodoNavigation.Codigo,
                          CourseName = hist.IdAsignaturaNavigation.Nombre,
                          CourseCode = hist.IdAsignatura, // This line was missing
                          Credits = apa.Creditos,
                          FinalGrade = (int?)hist.Calificacion,
                          Status = hist.Estatus
                      })
                .ToListAsync();
        }
    }
}