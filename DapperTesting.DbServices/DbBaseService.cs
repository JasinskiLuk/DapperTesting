using Microsoft.Extensions.Configuration;

namespace DapperTesting.DbServices
{
    public class DbBaseService
    {
        private protected readonly string _connectionString;
        public DbBaseService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("TestingConnection");
        }
    }
}
