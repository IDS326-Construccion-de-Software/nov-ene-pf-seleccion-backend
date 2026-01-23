namespace SistemaAcademico.Professor.Core.DTOs;

public class SectionStudentDto
{
    public int StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string InstitutionalEmail { get; set; } = string.Empty;

    public string SelectionStatus { get; set; } = string.Empty;

    public decimal? FinalGrade { get; set; }
    public decimal? MidtermGrade { get; set; }
}
