using Dapper;
using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperTesting.DbServices
{
    public class DbDateTestService : DbBaseService, IDateTest
    {
        public DbDateTestService(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task AddDate(DateTestDTO DTO)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.QueryAsync(@"INSERT INTO [testing].[DateTest]([Date1], [DateTime1], [DateTime2])
                                    VALUES(@Date1, @DateTime1, @DateTime2)",
                                        new { DTO.Date1, DTO.DateTime1, DTO.DateTime2 });
        }

        public async Task EditDate(DateTestDTO DTO)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.QueryAsync(@"UPDATE [testing].[DateTest]
                                    SET [Date1] = @Date1,
                                        [DateTime1] = @DateTime1,
                                        [DateTime2] = @DateTime2
                                    WHERE [Id] = @Id",
                                    new { DTO.Id, DTO.Date1, DTO.DateTime1, DTO.DateTime2 });
        }

        public async Task<IEnumerable<DateTestDTO>> GetDate()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            var model = await conn.QueryAsync<DateTestDTO>(@"SELECT [Id], [Date1], [DateTime1], [DateTime2]
                                                             FROM [testing].[DateTest]");
            return model;
        }

        public async Task DeleteDate(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.ExecuteAsync(@"DELETE FROM [testing].[DateTest]
                                      WHERE [Id] = @Id",
                                      new { Id });
        }
    }
}
