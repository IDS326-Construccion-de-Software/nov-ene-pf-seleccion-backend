using SistemaAcademico.Professor.Core.DTOs;
using SistemaAcademico.Professor.Core.Interfaces;

namespace SistemaAcademico.Professor.Core.Services;

public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _repo;

    public ProfessorService(IProfessorRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<ProfessorSectionDto>> GetMySectionsForLatestPeriodAsync(int professorUserId)
    {
        if (professorUserId <= 0) throw new ArgumentException("Profesor inválido.", nameof(professorUserId));
        return await _repo.GetProfessorSectionsForLatestPeriodAsync(professorUserId);
    }

    public async Task<IEnumerable<SectionStudentDto>> GetStudentsInMySectionAsync(int professorUserId, int sectionId)
    {
        if (professorUserId <= 0) throw new ArgumentException("Profesor inválido.", nameof(professorUserId));
        if (sectionId <= 0) throw new ArgumentException("Sección inválida.", nameof(sectionId));
        return await _repo.GetSectionStudentsAsync(professorUserId, sectionId);
    }

    public async Task PublishFinalGradesAsync(int professorUserId, int sectionId, PublishFinalGradesRequest request)
    {
        if (professorUserId <= 0) throw new ArgumentException("Profesor inválido.", nameof(professorUserId));
        if (sectionId <= 0) throw new ArgumentException("Sección inválida.", nameof(sectionId));
        if (request?.Grades == null || request.Grades.Count == 0) throw new ArgumentException("Debe enviar al menos una calificación.");

        foreach (var g in request.Grades)
        {
            if (g.StudentId <= 0) throw new ArgumentException("StudentId inválido.");
            if (g.Grade < 0 || g.Grade > 100) throw new ArgumentException($"Nota fuera de rango (0..100) para StudentId {g.StudentId}.");
        }

        var tuples = request.Grades.Select(x => (x.StudentId, x.Grade)).ToList();
        await _repo.PublishFinalGradesAsync(professorUserId, sectionId, tuples);
    }

    public async Task PublishMidtermGradesAsync(int professorUserId, int sectionId, PublishMidtermGradesRequest request)
    {
        if (professorUserId <= 0) throw new ArgumentException("Profesor inválido.", nameof(professorUserId));
        if (sectionId <= 0) throw new ArgumentException("Sección inválida.", nameof(sectionId));
        if (request?.Grades == null || request.Grades.Count == 0) throw new ArgumentException("Debe enviar al menos una calificación.");

        foreach (var g in request.Grades)
        {
            if (g.StudentId <= 0) throw new ArgumentException("StudentId inválido.");
            if (g.Grade < 0 || g.Grade > 100) throw new ArgumentException($"Nota fuera de rango (0..100) para StudentId {g.StudentId}.");
        }

        var tuples = request.Grades.Select(x => (x.StudentId, x.Grade)).ToList();
        await _repo.PublishMidtermGradesAsync(professorUserId, sectionId, tuples);
    }

}
