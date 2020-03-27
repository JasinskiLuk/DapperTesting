using Dapper;
using DapperTesting.DTOs;
using DapperTesting.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DapperTesting.DbServices
{
    public class DbAttachmentServices : DbBaseService, IAttachment
    {
        public DbAttachmentServices(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> AddAttachment(AttachmentDTO attachment)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            var i = await conn.ExecuteScalarAsync<int>(@"INSERT INTO [Attachments](
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
            return i;
        }
    }
}
