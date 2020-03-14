using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperTesting.DTOs;

namespace DapperTesting.Interfaces
{
    public interface ICar
    {
        Task<IEnumerable<CarDTO>> GetCars();
        Task AddCar(CarDTO CarServices);
        Task EditCar(CarDTO CarServices);
        Task DeleteCar(int CarId);
    }
}
