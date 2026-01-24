using SistemaAcademico.Payment.Core.DTOs;

namespace SistemaAcademico.Payment.Core.Interfaces
{
    public interface IPaymentGatewayService
    {
        string GeneratePaymentHash(PaymentGatewayRequest request);
        // In a real scenario, this would call the external API. 
        // For this task, we might simulate it or just return true if hash matches (conceptually).
        // The user request was mainly about the hash generation.
        bool ValidatePaymentData(PaymentGatewayRequest request); 
    }
}
