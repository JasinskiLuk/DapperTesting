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
        public Task<int> AddCar(CarDTO CarServices)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteCar(int CarId, CarDTO CarServices)
        {
            throw new System.NotImplementedException();
        }

        public Task EditCar(CarDTO CarServices)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<CarDTO>> GetCars()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.QueryAsync<CarDTO>("SELECT * FROM cars");
        }

        public async Task<CarDTO> GetOneCar(int CarId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            var sql = @"SELECT id, name, price FROM cars WHERE id = @Id";
            var car = await conn.QueryFirstOrDefaultAsync<CarDTO>(sql, new { Id = CarId });
            return car ?? new NullCarDTO();
        }
    }
}
