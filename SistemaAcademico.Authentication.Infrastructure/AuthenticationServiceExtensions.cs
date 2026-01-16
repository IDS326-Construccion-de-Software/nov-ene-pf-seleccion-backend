using Microsoft.Extensions.DependencyInjection;
using SistemaAcademico.Authentication.Core.Interfaces;
using SistemaAcademico.Authentication.Core.Services;
using SistemaAcademico.Authentication.Infrastructure.Repositories;
using SistemaAcademico.Authentication.Infrastructure.Services;

namespace SistemaAcademico.Authentication.Infrastructure
{
    public static class AuthenticationServiceExtensions
    {
        public static IServiceCollection AddAuthenticationModule(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ITokenService, JwtTokenService>();
            services.AddSingleton<ILoginThrottlingService, MemoryLoginThrottlingService>();
            services.AddSingleton<IOtpService, OtpService>();
            //services.AddScoped<IEmailService, MockEmailService>();
            services.AddScoped<IEmailService, SmtpEmailService>();

            return services;
        }
    }
}
