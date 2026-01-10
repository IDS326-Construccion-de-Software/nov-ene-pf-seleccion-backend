using System.Collections.Generic;

namespace SistemaAcademico.AcademicProgress.Core.DTOs
{
    /// <summary>
    /// DTO principal para el reporte de historial académico.
    /// </summary>
    public class AcademicHistoryDto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public List<TrimesterHistoryDto> Trimesters { get; set; } = new List<TrimesterHistoryDto>();
    }

    /// <summary>
    /// Representa el historial de un trimestre específico.
    /// </summary>
    public class TrimesterHistoryDto
    {
        public string Period { get; set; } = string.Empty;
        public decimal TrimesterIndex { get; set; }
        public decimal CumulativeIndex { get; set; }
        public List<CourseHistoryDto> Courses { get; set; } = new List<CourseHistoryDto>();
    }

    /// <summary>
    /// Representa una asignatura cursada dentro de un trimestre.
    /// </summary>
    public class CourseHistoryDto
    {
        public string CourseName { get; set; } = string.Empty;
        public int Credits { get; set; }
        public string LetterGrade { get; set; } = string.Empty;
    }
}