using DapperTesting.DTOs;
using DapperTesting.Interfaces;

namespace DapperTesting.IServices
{
    public interface IDateTestService : ICreateUpdateService<DateTestDTO>, IDeleteService, IReadService<DateTestDTO>, IReadCollectionService<DateTestDTO>
    {
    }
}
