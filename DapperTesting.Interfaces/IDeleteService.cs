using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IDeleteService
    {
        Task Delete(int Id);
    }
}
