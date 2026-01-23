using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Persistence.Models;
using Microsoft.AspNetCore.Authorization;
using SistemaAcademico.Retirement.Core.DTOs;
using SistemaAcademico.Retirement.Core.Interfaces;
using SistemaAcademico.Retirement.Core.Services;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estudiante")]
    public class RetirementController : ControllerBase
    {
        private readonly SistemaAcademicoContext _context;

        public RetirementController(SistemaAcademicoContext context)
        {
            _context = context;
        }
        [HttpPut]
        public async Task<string> Retirar([FromBody] SeleccionRetirementDTO slrDTO)
        {
            var resp = await new SeleccionRetirementService(_context).Retirar(slrDTO);
            return resp;
        }
    }
}
