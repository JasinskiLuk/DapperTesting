using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTesting.IServices
{
    public interface IDateTestService : ICreateUpdateService<DateTestDTO>, IDeleteService, IReadService<DateTestDTO>, IReadCollectionService<DateTestDTO>
    {
        Task AddDate(DateTestDTO DTO);
        Task<IEnumerable<DateTestDTO>> GetDate();
        Task EditDate(DateTestDTO DTO);
        Task DeleteDate(int Id);
    }
}
