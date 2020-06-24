using Microsoft.Extensions.Configuration;

namespace TestingProject.DbServices
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
