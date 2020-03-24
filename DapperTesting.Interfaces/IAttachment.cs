using DapperTesting.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DapperTesting.Interfaces
{
    public interface IAttachment
    {
        Task AddAttachment(AttachmentDTO attachment);
    }
}
