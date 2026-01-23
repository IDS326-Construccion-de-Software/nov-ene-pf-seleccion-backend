using SistemaAcademico.ApiGateway.Middleware;

namespace SistemaAcademico.ApiGateway.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseIsRole(this IApplicationBuilder app, string role)
        {
            return app.UseMiddleware<IsRoleMiddleware>(role);
        }
    }

}
