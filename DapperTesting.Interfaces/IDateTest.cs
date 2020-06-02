using DapperTesting.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IDateTest
    {
        Task AddDate(DateTestDTO DTO);
        Task<IEnumerable<DateTestDTO>> GetDate();
        Task EditDate(DateTestDTO DTO);
        Task DeleteDate(int Id);
    }
}
