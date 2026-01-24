using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.AcademicCatalog.Core.Interfaces;
using SistemaAcademico.AcademicCatalog.Core.Services;
using SistemaAcademico.AcademicCatalog.Infrastructure.Persistence.Repositories;
using SistemaAcademico.AcademicProgress.Core.Interfaces;
using SistemaAcademico.AcademicProgress.Core.Services;
using SistemaAcademico.AcademicProgress.Infrastructure.Persistence.Repositories;
using SistemaAcademico.ApiGateway.Middleware;
using SistemaAcademico.Authentication.Infrastructure;
using System.Threading.RateLimiting;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;
using SistemaAcademico.SelecctionAndPreselecction.Infrastructure.Persistence.Repositories;
using SistemaAcademico.Professor.Core.Interfaces;
using SistemaAcademico.Professor.Core.Services;
using SistemaAcademico.Professor.Infrastructure.Persistence.Repositories;
using SistemaAcademico.SelecctionAndPreselecction.Core.Services;
using SistemaAcademico.Payment.Core.Interfaces;
using SistemaAcademico.Payment.Infrastructure.Repositories;
using SistemaAcademico.Payment.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);


//Sistema Academico DB Context
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


ServerVersion serverVersion;
if (builder.Environment.IsEnvironment("Testing"))
{
    serverVersion = new MySqlServerVersion(new Version(8, 0, 31)); // Versión genérica para tests
}
else
{
    serverVersion = ServerVersion.AutoDetect(connectionString);
}

builder.Services.AddDbContext<SistemaAcademicoContext>(options =>
{
    options.UseMySql(connectionString, serverVersion);
});

// Data Seeding
//builder.Services.AddDbContext<SistemaAcademicoContext>(options =>
//  options.UseMySql(connectionString, serverVersion)
//  .UseSeeding((context, _) =>
//  {
//    var appContext = (SistemaAcademicoContext)context;
//    DataSeeder.SeedData(appContext);
//  })
//);

// Repositories
builder.Services.AddScoped<IAcademicAreaRepository, AcademicAreaRepository>();
builder.Services.AddScoped<ISubjectsRepository, SubjectRepository>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();
builder.Services.AddScoped<IPeriodoConfigRepository, PeriodoConfigRepository>();
builder.Services.AddScoped<IPreseleccionRepository, PreseleccionRepository>();
builder.Services.AddScoped<ISeleccionRepository, SeleccionRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<IAcademicCatalogRepository, AcademicCatalogRepository>();
builder.Services.AddScoped<IAcademicCatalogService, AcademicCatalogService>();


// AutoMappers
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.AddServerHeader = false;

    // Límite global de 1MB por petición
    serverOptions.Limits.MaxRequestBodySize = 1 * 1024 * 1024;
});


// Configurar Rate Limiting
builder.Services.AddRateLimiter(options =>
{
    // Si alguien abusa, devolvemos 429 (Too Many Requests)
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

    // Política Global: Máximo 100 peticiones cada 1 minuto por cada IP
    options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext =>
        RateLimitPartition.GetFixedWindowLimiter(
            partitionKey: httpContext.Connection.RemoteIpAddress?.ToString() ?? httpContext.Request.Headers.Host.ToString(),
            factory: partition => new FixedWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 100,
                QueueLimit = 0,
                Window = TimeSpan.FromMinutes(1)
            }));
});

// Add services to the container.

builder.Services.AddAuthenticationModule();

// Register the services for the AcademicProgress module
builder.Services.AddScoped<IAcademicProgressService, AcademicProgressService>();
builder.Services.AddScoped<IAcademicProgressRepository, AcademicProgressRepository>();
builder.Services.AddScoped<IPeriodoConfigService, PeriodoConfigService>();
builder.Services.AddScoped<IPreseleccionService, PreseleccionService>();
builder.Services.AddScoped<ISeleccionService, SeleccionService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();

// Register Payment Module Services
builder.Services.AddScoped<ICuentaPorPagarRepository, CuentaPorPagarRepository>();
builder.Services.AddScoped<IFacturaRepository, FacturaRepository>();
builder.Services.AddScoped<IPaymentGatewayService, PaymentGatewayService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();



var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(secretKey),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddScoped<ICareerRepository, CareerRepository>();
builder.Services.AddScoped<IAcademicProgramRepository, AcademicProgramRepository>();

// Configuración de CORS
var allowedOrigins = builder.Configuration.GetSection("CorsSettings:AllowedOrigins").Get<string[]>()
                     ?? new[] { "http://localhost:5173" };

builder.Services.AddCors(options =>
{
    options.AddPolicy("OnSightLensPolicy",
        policy => policy.WithOrigins(allowedOrigins)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .SetIsOriginAllowedToAllowWildcardSubdomains());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Configuraci�n de Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sistema Academico API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new List<string>()
        }
    });
});

var app = builder.Build();

app.UseMiddleware<GlobalExceptionMiddleware>();
app.UseMiddleware<SecurityHeadersMiddleware>();
app.UseRateLimiter();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sistema Academico V1");
        // c.RoutePrefix = string.Empty; // Si descomentas esto, Swagger sale en la raíz
    });
}

app.UseCors("OnSightLensPolicy");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();


public partial class Program { }
