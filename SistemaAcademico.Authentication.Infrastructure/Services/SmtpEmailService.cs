using Microsoft.Extensions.Configuration;
using SistemaAcademico.Authentication.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.Authentication.Infrastructure.Services
{
    public class SmtpEmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public SmtpEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task EnviarCorreoAsync(string destinatario, string asunto, string cuerpo)
        {
            var smtpSection = _configuration.GetSection("SmtpSettings");

            // Leer configuración
            string server = smtpSection["Server"]!;
            int port = int.Parse(smtpSection["Port"]!);
            string senderEmail = smtpSection["SenderEmail"]!;
            string senderName = smtpSection["SenderName"]!;
            string username = smtpSection["Username"]!;
            string password = smtpSection["Password"]!;

            // Configurar Cliente SMTP
            using var smtpClient = new SmtpClient(server)
            {
                Port = port,
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true, // Gmail y Outlook requieren SSL
            };

            // Configurar Mensaje
            var mailMessage = new MailMessage
            {
                From = new MailAddress(senderEmail, senderName),
                Subject = asunto,
                Body = cuerpo,
                IsBodyHtml = true // para estilos html del correo
            };

            mailMessage.To.Add(destinatario);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                // En Producción: Loggear el error.
                // En Desarrollo: Relanzamos para que veas si la contraseña está mal.
                throw new Exception($"Error enviando correo SMTP: {ex.Message}");
            }
        }
    }
}
