using DapperTesting.DTOs;
using DapperTesting.Interfaces;

namespace DapperTesting.IServices
{
    public interface ICarService : ICreateUpdateService<CarDTO>, IDeleteService, IReadService<CarDTO>, IReadCollectionService<CarDTO>
    {
    }
}
