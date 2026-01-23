namespace SistemaAcademico.Professor.Core.DTOs;

public class ProfessorSectionDto
{
    public int SectionId { get; set; }
    public string PeriodCode { get; set; } = string.Empty;

    public string CourseCode { get; set; } = string.Empty;
    public string CourseName { get; set; } = string.Empty;

    public string SectionNumber { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public int AvailableSeats { get; set; }

    public string Status { get; set; } = string.Empty;
    public string Modality { get; set; } = string.Empty;
}
