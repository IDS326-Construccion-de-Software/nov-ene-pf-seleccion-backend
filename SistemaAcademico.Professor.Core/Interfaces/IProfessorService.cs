using SistemaAcademico.Professor.Core.DTOs;

namespace SistemaAcademico.Professor.Core.Interfaces;

public interface IProfessorService
{
    /// Retorna las secciones del profesor autenticado para el último período configurado.
    Task<IEnumerable<ProfessorSectionDto>> GetMySectionsForLatestPeriodAsync(int professorUserId);

    /// Lista estudiantes matriculados en una sección (solo si la sección pertenece al profesor)
    Task<IEnumerable<SectionStudentDto>> GetStudentsInMySectionAsync(int professorUserId, int sectionId);

    /// Publica calificaciones finales en batch para una sección del profesor. (Si estan dentro de la fecha limite)
    Task PublishFinalGradesAsync(int professorUserId, int sectionId, PublishFinalGradesRequest request);
    
    /// Publica calificaciones de medio en batch para una sección del profesor. (Si estan dentro de la fecha limite)
    Task PublishMidtermGradesAsync(int professorUserId, int sectionId, PublishMidtermGradesRequest request);

}
