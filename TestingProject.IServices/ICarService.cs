using TestingProject.DTOs;
using TestingProject.Interfaces;

namespace TestingProject.IServices
{
    public interface ICarService : ICreateUpdateService<CarDTO>, IDeleteService, IReadService<CarDTO>, IReadCollectionService<CarDTO>
    {
    }
}
