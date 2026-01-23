using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Payment.Core.DTOs;
using SistemaAcademico.Payment.Core.Interfaces;

namespace SistemaAcademico.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly ICuentaPorPagarRepository _cuentaPorPagarRepository;

        public PaymentController(IPaymentService paymentService, ICuentaPorPagarRepository cuentaPorPagarRepository)
        {
            _paymentService = paymentService;
            _cuentaPorPagarRepository = cuentaPorPagarRepository;
        }

        [HttpGet("pending/{studentId}")]
        public async Task<IActionResult> GetPendingPayments(int studentId)
        {
            var pending = await _cuentaPorPagarRepository.GetPendingByStudentId(studentId);
            return Ok(pending);
        }

        [HttpPost("pay")]
        public async Task<IActionResult> ProcessPayment([FromBody] CreatePaymentRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _paymentService.ProcessPayment(request);

            if (!result.Success)
                return BadRequest(new { Message = result.Message });

            return Ok(result);
        }
    }
}
