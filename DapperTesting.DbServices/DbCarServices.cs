using Dapper;
using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperTesting.DbServices
{
    public class DbCarServices : DbBaseService, ICar
    {
        public DbCarServices(IConfiguration configuration) : base(configuration)
        {
        }
        public async Task AddCar(CarDTO CarServices)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.QueryAsync(@"INSERT INTO [testing].[Cars]([Name], [Price], [DateId])
                                    VALUES(@Name, @Price, @DateId)",
                new { CarServices.Name, CarServices.Price, CarServices.DateId });
        }

        public async Task DeleteCar(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.ExecuteAsync(@"DELETE FROM [Cars] WHERE [Id] = @Id", new { Id });
        }

        public async Task EditCar(CarDTO CarServices)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            await conn.QueryAsync(@"UPDATE [testing].[Cars]
                                    SET [Name] = @Name,
                                        [Price] = @Price,
                                        [DateId] = @DateId
                                    WHERE [Id] = @Id",
                                    new { CarServices.Id, CarServices.Name, CarServices.Price, CarServices.DateId });
        }

        public async Task<CarDTO> GetCar(int Id)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.QueryFirstOrDefaultAsync<CarDTO>(@"SELECT [Id], [Name], [Price], [DateId]
                                                                 FROM [testing].[Cars]
                                                                 WHERE [Id] = @Id",
                                                                 new { Id });
        }

        public async Task<IEnumerable<CarDTO>> GetCars()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.QueryAsync<CarDTO>(@"SELECT [Id], [Name], [Price], [DateId]
                                                   FROM [testing].[Cars]");
        }
    }
}
