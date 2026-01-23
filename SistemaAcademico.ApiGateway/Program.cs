using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SistemaAcademico.AcademicCatalog.Core.Interfaces;
using SistemaAcademico.AcademicCatalog.Infrastructure.Persistence.Repositories;
using SistemaAcademico.AcademicProgress.Core.Interfaces;
using SistemaAcademico.AcademicProgress.Core.Services;
using SistemaAcademico.AcademicProgress.Infrastructure.Persistence.Repositories;
using SistemaAcademico.ApiGateway.Extensions;
using SistemaAcademico.Persistence.Data;
using SistemaAcademico.Persistence.Models;
using SistemaAcademico.SelecctionAndPreselecction.Core.Interfaces;
using SistemaAcademico.SelecctionAndPreselecction.Core.Services;
using SistemaAcademico.SelecctionAndPreselecction.Infrastructure.Persistence.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// ===============================
// DATABASE
// ===============================
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<SistemaAcademicoContext>(options =>
    options.UseMySql(connectionString, serverVersion)
           .UseSeeding((context, _) =>
           {
               var appContext = (SistemaAcademicoContext)context;
               DataSeeder.SeedData(appContext);
           })
);

// ===============================
// REPOSITORIES
// ===============================
builder.Services.AddScoped<IAcademicAreaRepository, AcademicAreaRepository>();
builder.Services.AddScoped<ISubjectsRepository, SubjectRepository>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();
builder.Services.AddScoped<IPeriodoConfigRepository, PeriodoConfigRepository>();
builder.Services.AddScoped<IPreseleccionRepository, PreseleccionRepository>();
builder.Services.AddScoped<ISeleccionRepository, SeleccionRepository>();
builder.Services.AddScoped<ICareerRepository, CareerRepository>();
builder.Services.AddScoped<IAcademicProgramRepository, AcademicProgramRepository>();

// ===============================
// AUTOMAPPER
// ===============================
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// ===============================
// SERVICES
// ===============================
builder.Services.AddScoped<IAcademicProgressService, AcademicProgressService>();
builder.Services.AddScoped<IAcademicProgressRepository, AcademicProgressRepository>();
builder.Services.AddScoped<IPeriodoConfigService, PeriodoConfigService>();
builder.Services.AddScoped<IPreseleccionService, PreseleccionService>();
builder.Services.AddScoped<ISeleccionService, SeleccionService>();

// ===============================
// JWT CONFIGURATION (CORRECTO)
// ===============================
var jwtSettings = builder.Configuration.GetSection("JwtSettings");

var secretKey = Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
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

builder.Services.AddAuthorization();

// ===============================
// CORS
// ===============================
var allowedOrigins = builder.Configuration
    .GetSection("CorsSettings:AllowedOrigins")
    .Get<string[]>() ?? new[] { "http://localhost:5173" };

builder.Services.AddCors(options =>
{
    options.AddPolicy("OnSightLensPolicy", policy =>
        policy.WithOrigins(allowedOrigins)
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials()
    );
});

// ===============================
// CONTROLLERS & SWAGGER
// ===============================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Sistema Academico API",
        Version = "v1"
    });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Escriba: Bearer {su token}",
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
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new List<string>()
        }
    });
});

// ===============================
// BUILD
// ===============================
var app = builder.Build();

// ===============================
// PIPELINE (ORDEN PROFESIONAL)
// ===============================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("OnSightLensPolicy");

app.UseAuthentication();   // JWT valida token
app.UseAuthorization();    // roles y policies
app.UseIsRole("estudiante"); // AUTH-09

app.MapControllers();
app.Run();
