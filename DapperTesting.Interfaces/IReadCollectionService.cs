using System.Collections.Generic;
using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IReadCollectionService<T>
    {
        Task<IEnumerable<T>> Get();
    }
}
