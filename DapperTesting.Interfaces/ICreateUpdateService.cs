using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface ICreateUpdateService<T>
    {
        Task<int> Create(T model);
        Task<int> Update(T model);
    }
}
