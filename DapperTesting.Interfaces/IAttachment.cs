using DapperTesting.DTOs;
using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IAttachment
    {
        Task<int> AddAttachment(AttachmentDTO attachment);
    }
}
