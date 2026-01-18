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
        private readonly string _dbName = Guid.NewGuid().ToString();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptors = services.Where(
                    d => d.ServiceType == typeof(DbContextOptions<SistemaAcademicoContext>) ||
                         d.ServiceType.FullName.Contains("DbContextOptions")).ToList();

                foreach (var descriptor in descriptors)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<SistemaAcademicoContext>(options =>
                {
                    options.UseInMemoryDatabase(_dbName);
                    options.ConfigureWarnings(x => x.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.InMemoryEventId.TransactionIgnoredWarning));
                });

                var sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<SistemaAcademicoContext>();

                    db.Database.EnsureCreated();

                    if (!db.Usuarios.Any())
                    {
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

                        var adminRole = db.Rols.FirstOrDefault(r => r.Descripcion == "Administrador");
                        if (adminRole == null)
                        {
                            adminRole = new Rol { Descripcion = "Administrador" };
                            db.Rols.Add(adminRole);
                            db.SaveChanges();
                        }

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

            builder.UseEnvironment("Testing");
        }
    }
}