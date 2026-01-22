using System.Collections.Generic;

namespace SistemaAcademico.AcademicProgress.Core.DTOs
{
    /// <summary>
    /// Representa un reporte de calificaciones para un período específico.
    /// </summary>
    public class GradeReportDto
    {
        public string StudentName { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public List<CourseGradeDto> Courses { get; set; } = new List<CourseGradeDto>();
    }

    /// <summary>
    /// Representa la calificación de una asignatura individual dentro de un reporte.
    /// </summary>
    public class CourseGradeDto
    {
        public string CourseCode { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int Credits { get; set; }
        public int? NumericGrade { get; set; }
        public string? LetterGrade { get; set; }
    }
}