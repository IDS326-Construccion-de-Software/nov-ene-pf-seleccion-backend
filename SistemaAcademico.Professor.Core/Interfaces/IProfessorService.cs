using SistemaAcademico.Professor.Core.DTOs;

namespace SistemaAcademico.Professor.Core.Interfaces;

/// <summary>
/// Contrato de funcionalidades del profesor: secciones, estudiantes, publicación de notas.
/// </summary>
public interface IProfessorService
{
    /// <summary>Retorna las secciones del profesor autenticado para el último período configurado.</summary>
    Task<IEnumerable<ProfessorSectionDto>> GetMySectionsForLatestPeriodAsync(int professorUserId);

    /// <summary>Lista estudiantes matriculados en una sección (solo si la sección pertenece al profesor).</summary>
    Task<IEnumerable<SectionStudentDto>> GetStudentsInMySectionAsync(int professorUserId, int sectionId);

    /// <summary>Publica calificaciones finales en batch para una sección del profesor.</summary>
    Task PublishFinalGradesAsync(int professorUserId, int sectionId, PublishFinalGradesRequest request);
}
