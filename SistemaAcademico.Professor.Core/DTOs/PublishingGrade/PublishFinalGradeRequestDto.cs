namespace SistemaAcademico.Professor.Core.DTOs;

public class PublishFinalGradesRequest
{
    public List<FinalGradeItemDto> Grades { get; set; } = new();
}

public class FinalGradeItemDto
{
    public int StudentId { get; set; }
    public decimal Grade { get; set; }
}
