using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LexisDeedTrackerDataAccess.Database
{
    public class DBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("LexisConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}
