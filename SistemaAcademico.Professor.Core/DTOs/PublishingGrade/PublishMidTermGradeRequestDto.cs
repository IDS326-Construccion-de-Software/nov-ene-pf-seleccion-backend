namespace SistemaAcademico.Professor.Core.DTOs;

public class PublishMidtermGradesRequest
{
    public List<MidtermGradeItemDto> Grades { get; set; } = new();
}

public class MidtermGradeItemDto
{
    public int StudentId { get; set; }
    public decimal Grade { get; set; }
}
