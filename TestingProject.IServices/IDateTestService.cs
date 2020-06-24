using TestingProject.DTOs;
using TestingProject.Interfaces;

namespace TestingProject.IServices
{
    public interface IDateTestService : ICreateUpdateService<DateTestDTO>, IDeleteService, IReadService<DateTestDTO>, IReadCollectionService<DateTestDTO>
    {
    }
}
