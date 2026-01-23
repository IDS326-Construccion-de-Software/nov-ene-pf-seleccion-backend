using System;
using System.Threading.Tasks;
using SistemaAcademico.Payment.Core.DTOs;
using SistemaAcademico.Payment.Core.Interfaces;
using SistemaAcademico.Persistence.Models;

namespace SistemaAcademico.Payment.Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ICuentaPorPagarRepository _cuentaPorPagarRepository;
        private readonly IFacturaRepository _facturaRepository;
        private readonly IPaymentGatewayService _paymentGatewayService;

        public PaymentService(
            ICuentaPorPagarRepository cuentaPorPagarRepository, 
            IFacturaRepository facturaRepository,
            IPaymentGatewayService paymentGatewayService)
        {
            _cuentaPorPagarRepository = cuentaPorPagarRepository;
            _facturaRepository = facturaRepository;
            _paymentGatewayService = paymentGatewayService;
        }

        public async Task<PaymentResultDTO> ProcessPayment(CreatePaymentRequest request)
        {
            // 1. Validate CuentaPorPagar
            var cuenta = await _cuentaPorPagarRepository.GetById(request.CuentaPorPagarId);
            if (cuenta == null)
                return new PaymentResultDTO { Success = false, Message = "Cuenta por pagar no encontrada." };

            if (cuenta.Pagada || cuenta.CantidadRestante <= 0)
                return new PaymentResultDTO { Success = false, Message = "La cuenta ya está pagada." };

            if (request.Amount <= 0 || request.Amount > cuenta.CantidadRestante)
                return new PaymentResultDTO { Success = false, Message = "Monto inválido." };

            // 2. Gateway Processing
            var gatewayRequest = new PaymentGatewayRequest
            {
                CardNumber = request.CardNumber,
                CardHolderName = request.CardHolderName,
                Cvv = request.Cvv,
                ExpMonth = request.ExpMonth,
                ExpYear = request.ExpYear,
                Amount = request.Amount,
                Tax = 0 // Assuming tax is 0 or included for this basic logic, user didn't specify tax logic, but gateway needs it.
            };

            // Validate data
            if (!_paymentGatewayService.ValidatePaymentData(gatewayRequest))
                 return new PaymentResultDTO { Success = false, Message = "Datos de tarjeta inválidos o expirados." };

            // Generate Hash (Conceptually sending to gateway)
            string hash = _paymentGatewayService.GeneratePaymentHash(gatewayRequest);
            // In a real app, we would send 'hash' + data to the external API here.
            
            // 3. Update internal state
            // Calculate new remaining
            cuenta.CantidadRestante -= request.Amount;
            if (cuenta.CantidadRestante < 0.01m)
            {
                cuenta.CantidadRestante = 0;
                cuenta.Pagada = true;
            }

            // Create Invoice (Factura)
            var factura = new Factura
            {
                Fecha = DateTime.Now,
                FechaVencimiento = DateTime.Now, // Paid immediately
                NumeroComprobante = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(), // Simulation
                Estatus = "Pagada",
                Subtotal = request.Amount,
                Descuento = 0,
                MontoTotal = request.Amount,
                IdCuentaPorPagar = cuenta.Id
            };
            
            // Add detail
            factura.DetalleFacturas.Add(new DetalleFactura
            {
                Concepto = $"Pago de {cuenta.Tipo}",
                Monto = request.Amount,
                Subtotal = request.Amount,
                Descuento = 0,
                MontoTotal = request.Amount
            });

            // Save changes
            await _facturaRepository.Create(factura);
            await _cuentaPorPagarRepository.Update(cuenta);

            return new PaymentResultDTO 
            { 
                Success = true, 
                Message = "Pago realizado correctamente.",
                FacturaId = factura.IdFactura
            };
        }
    }
}
