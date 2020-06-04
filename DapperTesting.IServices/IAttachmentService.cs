using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using System.Threading.Tasks;

namespace DapperTesting.IServices
{
    public interface IAttachmentService : ICreateUpdateService<AttachmentDTO>, IDeleteService, IReadService<AttachmentDTO>, IReadCollectionService<AttachmentDTO>
    {
        Task<int> AddAttachment(AttachmentDTO attachment);
    }
}
