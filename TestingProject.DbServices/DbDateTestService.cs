using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.DbServices
{
    public class DbDateTestService : DbBaseService, IDateTestService
    {
        public DbDateTestService(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> Create(DateTestDTO DTO)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.ExecuteScalarAsync<int>(@"INSERT INTO [testing].[DateTest]([Date1], [DateTime1], [DateTime2])
                                                        VALUES(@Date1, @DateTime1, @DateTime2)",
                                                        new { DTO.Date1, DTO.DateTime1, DTO.DateTime2 });
        }

        public async Task<int> Update(DateTestDTO DTO)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.ExecuteScalarAsync<int>(@"UPDATE [testing].[DateTest]
                                                        SET [Date1] = @Date1,
                                                            [DateTime1] = @DateTime1,
                                                            [DateTime2] = @DateTime2
                                                        WHERE [Id] = @Id",
                                                        new { DTO.Id, DTO.Date1, DTO.DateTime1, DTO.DateTime2 });
        }

        public async Task Delete(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.ExecuteAsync(@"DELETE FROM [testing].[DateTest]
                                      WHERE [Id] = @Id",
                                      new { Id });
        }

        public async Task<DateTestDTO> Get(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            var model = await conn.QueryFirstOrDefaultAsync<DateTestDTO>(@"SELECT [Id], [Date1], [DateTime1], [DateTime2]
                                                                           FROM [testing].[DateTest]
                                                                           WHERE [Id] = @Id",
                                                                           new { Id });
            return model ?? new NullDateTestDTO();
        }

        public async Task<IEnumerable<DateTestDTO>> Get()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.QueryAsync<DateTestDTO>(@"SELECT [Id], [Date1], [DateTime1], [DateTime2]
                                                        FROM [testing].[DateTest]");
        }

        public async Task<bool> CheckIfExists(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.ExecuteScalarAsync<bool>(@"SELECT COUNT(1)
                                                         FROM [testing].[DateTest]
                                                         WHERE [Id] = @Id",
                                                         new { Id });
        }
    }
}
