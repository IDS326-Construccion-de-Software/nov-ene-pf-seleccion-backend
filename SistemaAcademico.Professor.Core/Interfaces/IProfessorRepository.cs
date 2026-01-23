using SistemaAcademico.Professor.Core.DTOs;

namespace SistemaAcademico.Professor.Core.Interfaces;

public interface IProfessorRepository
{
    Task<IEnumerable<ProfessorSectionDto>> GetProfessorSectionsForLatestPeriodAsync(int professorUserId);
    Task<IEnumerable<SectionStudentDto>> GetSectionStudentsAsync(int professorUserId, int sectionId);

    Task PublishFinalGradesAsync(int professorUserId, int sectionId, IReadOnlyList<(int studentId, decimal grade)> grades);
    Task PublishMidtermGradesAsync(int professorUserId, int sectionId, IReadOnlyList<(int studentId, decimal grade)> grades);

}
