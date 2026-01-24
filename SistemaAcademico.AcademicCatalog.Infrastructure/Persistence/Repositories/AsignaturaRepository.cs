using Microsoft.EntityFrameworkCore;
using SistemaAcademico.AcademicCatalog.Core.Entities;
using SistemaAcademico.AcademicCatalog.Core.Interfaces;
using SistemaAcademico.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico.AcademicCatalog.Infrastructure.Persistence.Repositories
{
    public class AcademicCatalogRepository : IAcademicCatalogRepository
    {
        private readonly SistemaAcademicoContext _context;

        public AcademicCatalogRepository(SistemaAcademicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AsignaturaPensumE>> GetAsignaturasByPensumIdAsync(int pensumId)
        {
            var listaResultado = new List<AsignaturaPensumE>();

            var connection = _context.Database.GetDbConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                SELECT 
                    ap.Id_Asignatura, 
                    ap.Id_ProgramaAcademico, 
                    ap.PreRequisitos, 
                    ap.Corequisito, 
                    ap.Creditos,
                    a.Nombre as NombreAsignatura
                FROM Asignatura_ProgramaAcademico ap
                INNER JOIN Asignatura a ON ap.Id_Asignatura = a.Asignatura_ID
                WHERE ap.Id_ProgramaAcademico = @pensumId";

                    var param = command.CreateParameter();
                    param.ParameterName = "@pensumId";
                    param.Value = pensumId;
                    command.Parameters.Add(param);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var entidad = new AsignaturaPensumE
                            {
                                IdAsignatura = reader["Id_Asignatura"].ToString(),
                                IdProgramaAcademico = Convert.ToInt32(reader["Id_ProgramaAcademico"]),
                                PreRequisitos = reader["PreRequisitos"] == DBNull.Value ? "" : reader["PreRequisitos"].ToString(),
                                Corequisito = reader["Corequisito"] == DBNull.Value ? "N/A" : reader["Corequisito"].ToString(),
                                Creditos = Convert.ToInt32(reader["Creditos"]),

                                Asignatura = new AsignaturaE
                                {
                                    Id = reader["Id_Asignatura"].ToString(),
                                    Nombre = reader["NombreAsignatura"] == DBNull.Value ? "Sin Nombre" : reader["NombreAsignatura"].ToString()
                                }
                            };

                            listaResultado.Add(entidad);
                        }
                    }
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    await connection.CloseAsync();
            }

            return listaResultado;
        }
    }
}
