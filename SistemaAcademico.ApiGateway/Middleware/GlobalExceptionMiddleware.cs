using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SistemaAcademico.Authentication.Core.Exceptions;
using System.Net;

namespace SistemaAcademico.ApiGateway.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error detectado por el Middleware Global");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = HttpStatusCode.InternalServerError;
            var message = "Ocurrió un error inesperado.";

            // Mapeo exhaustivo de excepciones
            switch (exception)
            {
                case PasswordChangeRequiredException:
                    statusCode = HttpStatusCode.Forbidden;
                    message = "Cambio de contraseña requerido.";
                    break;

                case AccountBlockedException:
                    statusCode = HttpStatusCode.Forbidden;
                    message = exception.Message;
                    break;

                case UnauthorizedAccessException:
                    statusCode = HttpStatusCode.Unauthorized;
                    message = "Credenciales Inválidas";
                    break;

                case KeyNotFoundException: // Para buscar IDs que no existen
                    statusCode = HttpStatusCode.NotFound;
                    message = "El recurso solicitado no existe.";
                    break;

                case ArgumentException or InvalidOperationException:
                    // Esto captura los errores que antes caían en BadRequest
                    statusCode = HttpStatusCode.BadRequest;
                    message = exception.Message;
                    break;
                case DbUpdateException dbEx:
                    if (dbEx.InnerException is MySqlException mysqlEx && mysqlEx.Number == 1062)
                    {
                        statusCode = HttpStatusCode.BadRequest;
                        message = "Ya existe un registro con estos datos (Correo o ID duplicado).";
                    }
                    else
                    {
                        statusCode = HttpStatusCode.InternalServerError;
                        message = "Error al persistir los datos en la base de datos.";
                    }
                    break;
                case UserAlreadyExistsException:
                    statusCode = HttpStatusCode.BadRequest;
                    message = exception.Message;
                    break;

            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var response = new
            {
                status = context.Response.StatusCode,
                error = message,
            };

            return context.Response.WriteAsync(
                JsonConvert.SerializeObject(response, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                })
            );
        }
    }
}
