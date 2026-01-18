using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaAcademico.Tests.Integration
{
    public class SecurityWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // 1. ELIMINACIÓN AGRESIVA de cualquier rastro de DbContext (MySQL)
                var descriptors = services.Where(
                    d => d.ServiceType == typeof(DbContextOptions<SistemaAcademicoContext>) ||
                         d.ServiceType.FullName.Contains("DbContextOptions")).ToList();

                foreach (var descriptor in descriptors)
                {
                    services.Remove(descriptor);
                }

                // 2. AGREGAR BASE DE DATOS EN MEMORIA
                services.AddDbContext<SistemaAcademicoContext>(options =>
                {
                    options.UseInMemoryDatabase("SecurityTestDb");
                    // Esto evita que EF Core intente usar comportamientos específicos de MySQL
                    options.ConfigureWarnings(x => x.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning));
                });

                // 3. SEEDING (Insertar datos mínimos para que no falle el login)
                var sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<SistemaAcademicoContext>();
                    db.Database.EnsureDeleted(); // Limpiamos para evitar conflictos
                    db.Database.EnsureCreated();

                    // AGREGAR ESTO:
                    if (!db.Usuarios.Any())
                    {
                        // 1. Crear el Usuario
                        var testUser = new Usuario
                        {
                            CorreoInstitucional = "admin@test.com",
                            ClaveHash = BCrypt.Net.BCrypt.HashPassword("Admin123!"),
                            CambioClaveSolicitado = false,
                            Nombre = "Admin",
                            Apellido = "Test",
                            CorreoPersonal = "admin@test.com",
                            Direccion = "N/A",
                            Nacionalidad = "N/A",
                            Telefono = "0000000000"
                        };
                        db.Usuarios.Add(testUser);
                        db.SaveChanges();

                        // 2. Crear el Rol (Administrador)
                        // Nota: Si ya tienes roles en tu tabla, asegúrate que el ID o Nombre coincida
                        var adminRole = db.Rols.FirstOrDefault(r => r.Descripcion == "Administrador");
                        if (adminRole == null)
                        {
                            adminRole = new Rol { Descripcion = "Administrador" };
                            db.Rols.Add(adminRole);
                            db.SaveChanges(); 
                        }

                        // 3. Crear la relación UsuarioRol ACTIVA
                        db.UsuarioRols.Add(new UsuarioRol
                        {
                            IdUsuario = testUser.IdUsuario,
                            IdRol = adminRole.RolId,   
                            Estatus = "Activo"
                        });

                        db.SaveChanges();
                    }
                }
            });

            builder.UseEnvironment("Testing"); // Forzamos entorno Testing
        }
    }
}