using System;

namespace SistemaAcademico.Payment.Core.DTOs
{
    public class CuentaPorPagarDTO
    {
        public int Id { get; set; }
        public decimal CantidadTotal { get; set; }
        public decimal CantidadRestante { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public DateTime FechaVencimiento { get; set; }
    }

    public class PaymentGatewayRequest
    {
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string Cvv { get; set; } = string.Empty;
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public decimal Amount { get; set; }
        public decimal Tax { get; set; }
    }

    public class CreatePaymentRequest
    {
        public int StudentId { get; set; }
        public int CuentaPorPagarId { get; set; }
        public decimal Amount { get; set; }
        // Card details for gateway
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string Cvv { get; set; } = string.Empty;
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
    }

    public class PaymentResultDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int? FacturaId { get; set; }
    }
}
