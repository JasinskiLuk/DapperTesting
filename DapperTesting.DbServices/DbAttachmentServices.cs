using Dapper;
using DapperTesting.DTOs;
using DapperTesting.IServices;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DapperTesting.DbServices
{
    public class DbAttachmentServices : DbBaseService, IAttachmentService
    {
        public DbAttachmentServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> AddAttachment(AttachmentDTO attachment)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            int ID = await conn.ExecuteScalarAsync<int>(@"INSERT INTO [testing].[Attachments](
                                                            [FileName], 
                                                            [OriginalFileName], 
                                                            [FilePath], 
                                                            [DateAdded])
                                                        VALUES(
                                                            @FileName, 
                                                            @OriginalFileName, 
                                                            @FilePath, 
                                                            @DateAdded)
                                                        SELECT SCOPE_IDENTITY()",
                new { attachment.FileName, attachment.OriginalFileName, attachment.FilePath, attachment.DateAdded });
            return ID;
        }

        public Task<int> Create(AttachmentDTO model)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<AttachmentDTO> Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<AttachmentDTO>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Update(AttachmentDTO model)
        {
            throw new System.NotImplementedException();
        }
    }
}
