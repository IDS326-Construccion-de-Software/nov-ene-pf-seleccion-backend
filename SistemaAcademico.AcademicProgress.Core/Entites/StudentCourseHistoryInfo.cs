namespace SistemaAcademico.AcademicProgress.Core.Entities
{
    /// <summary>
    /// Proyección de datos para el historial académico. No es una entidad de BD.
    /// </summary>
    public class StudentCourseHistoryInfo
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string ProgramName { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public int Credits { get; set; }
        public int? FinalGrade { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}