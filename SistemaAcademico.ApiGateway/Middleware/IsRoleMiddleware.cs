using System.Security.Claims;

namespace SistemaAcademico.ApiGateway.Middleware
{
    public class IsRoleMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _role;

        public IsRoleMiddleware(RequestDelegate next, string role)
        {
            _next = next;
            _role = role;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api/auth"))
            {
                await _next(context);
                return;
            }

            var userRole = context.User?.FindFirst(ClaimTypes.Role)?.Value;

            if (userRole == null || userRole != _role)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Acceso denegado: rol no autorizado");
                return;
            }

            await _next(context);
        }
    }
}
