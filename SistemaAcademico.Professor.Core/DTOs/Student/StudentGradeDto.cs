using System.ComponentModel.DataAnnotations;

namespace SistemaAcademico.Professor.Core.DTOs
{

    public class StudentGradeDto
    {
        public int StudentId { get; set; }
        public decimal Grade { get; set; }
    }
}
