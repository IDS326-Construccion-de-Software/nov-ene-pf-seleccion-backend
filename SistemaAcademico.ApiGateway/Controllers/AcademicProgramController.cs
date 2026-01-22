using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.AcademicCatalog.Core.DTOs.AcademicProgram;
using SistemaAcademico.AcademicCatalog.Core.Interfaces;
using SistemaAcademico.AcademicProgress.Core.Interfaces;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicProgramController : ControllerBase
    {
        public readonly IAcademicProgramRepository _academicProgramRepository;
        public readonly IAcademicProgressRepository _academicProgressRepository;
        public readonly IMapper _mapper;

        public AcademicProgramController(
            IAcademicProgramRepository academicProgramRepository,
            IAcademicProgressRepository academicProgressRepository,
            IMapper mapper)
        {
            _academicProgramRepository = academicProgramRepository;
            _academicProgressRepository = academicProgressRepository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAcademicsPrograms")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public IActionResult GetAcademicsPrograms()
        {
            var academicsPrograms = _academicProgramRepository.GetAcademicsPrograms();

            var AcademicProgramDto = _mapper.Map<List<AcademicProgramDto>>(academicsPrograms);

            return Ok(AcademicProgramDto);
        }

        [HttpGet("{academicProgramId:int}:", Name = "GetAcademicProgramById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAcademicProgramById(int academicProgramId)
        {
            var academicProgram = _academicProgramRepository.GetAcadmicProgramById(academicProgramId);
            if (academicProgram == null)
            {
                return NotFound($"El AcademicProgram con el id '{academicProgramId}' no existe.");
            }
            var AcademicProgramDto = _mapper.Map<AcademicProgramDto>(academicProgram);

            return Ok(AcademicProgramDto);
        }

        [HttpGet("total-subjects", Name = "GetTotalSubjectsByAcademicProgram")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTotalSubjectsByAcademicProgram([FromQuery] int academicProgramId, [FromQuery] int usuarioId)
        {
            // Verificar si el usuario es estudiante
            var esEstudiante = await _academicProgressRepository.IsEstudianteAsync(usuarioId);
            if (!esEstudiante)
            {
                return StatusCode(StatusCodes.Status403Forbidden, "Solo los estudiantes pueden consultar esta información.");
            }

            var academicProgram = _academicProgramRepository.GetAcadmicProgramById(academicProgramId);
            if (academicProgram == null)
            {
                return NotFound($"El programa académico con el id '{academicProgramId}' no existe.");
            }

            var totalSubjects = _academicProgramRepository.GetTotalSubjectsByAcademicProgram(academicProgramId);

            var response = new TotalSubjectsResponseDto
            {
                TotalAsignaturasPensun = totalSubjects
            };

            return Ok(response);
        }

    }
}
