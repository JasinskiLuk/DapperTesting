using DapperTesting.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
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
