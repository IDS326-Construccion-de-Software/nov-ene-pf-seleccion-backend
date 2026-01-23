using SistemaAcademico.AcademicProgress.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaAcademico.Persistence.Data;

namespace SistemaAcademico.AcademicProgress.Core.Interfaces
{
    /// <summary>
    /// Define el contrato para el repositorio que obtiene los datos de progreso académico.
    /// </summary>
    public interface IAcademicProgressRepository
    {
        /// <summary>
        /// Obtiene todas las calificaciones de un estudiante que son válidas para el cálculo de índices.
        /// </summary>
        /// <param name="estudianteId">El ID del estudiante.</param>
        /// <returns>Una lista de objetos GradeInfo que contienen los datos de calificación y créditos.</returns>
        Task<IEnumerable<GradeInfo>> GetGradesForStudentAsync(int estudianteId);

        /// <summary>
        /// Obtiene la información detallada de las asignaturas y calificaciones de un estudiante para un período y estados específicos.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <param name="period">El período académico en formato "YYYY-Q#".</param>
        /// <param name="states">La lista de estados de la selección a incluir (ej. "Aprobando", "Cursando").</param>
        /// <returns>Una lista de objetos con la información detallada de las calificaciones.</returns>
        Task<IEnumerable<CourseDetailInfo>> GetGradesByPeriodAsync(int studentId, string period, IEnumerable<HistorialEstatus> states);

        /// <summary>
        /// Obtiene toda la información de los cursos completados por un estudiante.
        /// </summary>
        /// <param name="studentId">El ID del estudiante.</param>
        /// <returns>Una lista de objetos con la información del historial.</returns>
        Task<IEnumerable<StudentCourseHistoryInfo>> GetAllCompletedCoursesForStudentAsync(int studentId);

        /// <summary>
        /// Obtiene el total de asignaturas cursadas con estado Aprobado para un usuario.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario.</param>
        /// <returns>El total de asignaturas aprobadas.</returns>
        Task<int> GetTotalAsignaturasCursadasAsync(int usuarioId);

        /// <summary>
        /// Obtiene el total de asignaturas pendientes por tomar en el programa académico del usuario.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario.</param>
        /// <returns>El total de asignaturas pendientes.</returns>
        Task<int> GetTotalAsignaturasPendientesAsync(int usuarioId);

        /// <summary>
        /// Obtiene el trimestre actual de un estudiante.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario.</param>
        /// <returns>El trimestre actual o null si no es estudiante o no existe.</returns>
        Task<int?> GetTrimestreActualAsync(int usuarioId);

        /// <summary>
        /// Obtiene la permanencia de un estudiante.
        /// </summary>
        /// <param name="usuarioId">El ID del usuario.</param>
        /// <returns>La permanencia o null si no es estudiante o no existe.</returns>
        Task<int?> GetPermanenciaEstudianteAsync(int usuarioId);

        /// <summary>
        /// Verifica si un usuario tiene el rol de Estudiante (RolId = 2).
        /// </summary>
        /// <param name="usuarioId">El ID del usuario.</param>
        /// <returns>True si es estudiante, false en caso contrario.</returns>
        Task<bool> IsEstudianteAsync(int usuarioId);
    }
}