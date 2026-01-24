using System.Threading.Tasks;
using SistemaAcademico.Payment.Core.DTOs;

namespace SistemaAcademico.Payment.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<PaymentResultDTO> ProcessPayment(CreatePaymentRequest request);
    }
}
