using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Professor.Core.DTOs;
using SistemaAcademico.Professor.Core.Interfaces;
using System.Security.Claims;

namespace SistemaAcademico.ApiGateway.Controllers;

[Route("api/professor")]
[ApiController]
[Authorize(Roles = "Profesor")]
public class ProfessorController : ControllerBase
{
    private readonly IProfessorService _professorService;

    public ProfessorController(IProfessorService professorService)
    {
        _professorService = professorService;
    }

    [HttpGet("sections/current")]
    public async Task<IActionResult> GetMySectionsForLatestPeriod()
    {
        var professorId = GetUserIdOrThrow();
        var sections = await _professorService.GetMySectionsForLatestPeriodAsync(professorId);
        return Ok(sections);
    }

    [HttpGet("sections/{sectionId:int}/students")]
    public async Task<IActionResult> GetStudentsInSection([FromRoute] int sectionId)
    {
        var professorId = GetUserIdOrThrow();
        var students = await _professorService.GetStudentsInMySectionAsync(professorId, sectionId);
        return Ok(students);
    }

    [HttpPost("sections/{sectionId:int}/final-grades")]
    public async Task<IActionResult> PublishFinalGrades([FromRoute] int sectionId, [FromBody] PublishFinalGradesRequest request)
    {
        var professorId = GetUserIdOrThrow();
        await _professorService.PublishFinalGradesAsync(professorId, sectionId, request);

        return Ok(new
        {
            message = "Calificaciones finales publicadas correctamente.",
            sectionId
        });
    }

    [HttpPost("sections/{sectionId:int}/midterm-grades")]
    public async Task<IActionResult> PublishMidtermGrades([FromRoute] int sectionId, [FromBody] PublishMidtermGradesRequest request)
    {
        var professorId = GetUserIdOrThrow();
        await _professorService.PublishMidtermGradesAsync(professorId, sectionId, request);

        return Ok(new
        {
            message = "Calificaciones de medio término publicadas correctamente.",
            sectionId
        });
    }


    private int GetUserIdOrThrow()
    {
        var claim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (claim == null || !int.TryParse(claim.Value, out var userId))
        {
            throw new UnauthorizedAccessException("No se pudo identificar al usuario.");
        }
        return userId;
    }
}
