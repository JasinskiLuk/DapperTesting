using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.IServices;

namespace TestingProject.DbServices
{
    public class DbAttachmentServices : DbBaseService, IAttachmentService
    {
        public DbAttachmentServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> Create(AttachmentDTO DTO)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            return await conn.ExecuteScalarAsync<int>(@"INSERT INTO [testing].[Attachments](
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
                                                        new { DTO.FileName, DTO.OriginalFileName, DTO.FilePath, DTO.DateAdded });
        }

        public Task<int> Update(AttachmentDTO model)
        {
            throw new System.NotImplementedException();
        }
    }
}
