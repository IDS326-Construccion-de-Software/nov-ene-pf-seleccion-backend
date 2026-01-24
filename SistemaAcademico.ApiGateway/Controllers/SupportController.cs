using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SistemaAcademico.Modules.Support.Core.DTOs;
using SistemaAcademico.Modules.Support.Core.Interfaces;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupportController : ControllerBase
    {
        private readonly ISupportService _service;

        public SupportController(ISupportService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupportTicket(
            [FromQuery] string userId,
            [FromBody] CreateSupportTicketDto request)
        {
            if (string.IsNullOrEmpty(userId)) return BadRequest("User ID required");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var ticketId = await _service.CreateTicketAsync(userId, request);
                return Ok(new { message = "Success", ticketId = ticketId });
            }
            catch (Exception ex)
            {
                var error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return BadRequest($"Database Error: {error}");
            }
        }
    }
}