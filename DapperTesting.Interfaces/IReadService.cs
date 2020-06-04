using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IReadService<T>
    {
        Task<T> Get(int Id);
    }
}
