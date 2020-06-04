using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTesting.IServices
{
    public interface ICarService : ICreateUpdateService<CarDTO>, IDeleteService, IReadService<CarDTO>, IReadCollectionService<CarDTO>
    {
        Task<CarDTO> GetCar(int Id);
        Task<IEnumerable<CarDTO>> GetCars();
        Task AddCar(CarDTO CarServices);
        Task EditCar(CarDTO CarServices);
        Task DeleteCar(int Id);
    }
}
