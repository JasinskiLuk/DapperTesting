using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.DbServices
{
    public class DbParameterService : DbBaseService, IParameterService
    {
        public DbParameterService(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IEnumerable<ParameterDTO>> Get()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.QueryAsync<ParameterDTO>(@"SELECT [Id], [Name], [Value]
                                                         FROM [testing].[Parameters]");
        }
    }
}
