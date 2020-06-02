using DapperTesting.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface ICar
    {
        Task<CarDTO> GetCar(int Id);
        Task<IEnumerable<CarDTO>> GetCars();
        Task AddCar(CarDTO CarServices);
        Task EditCar(CarDTO CarServices);
        Task DeleteCar(int Id);
    }
}
