using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Infrastructure;

public class DapperContext : IDisposable
{
    private readonly IConfiguration _configuration;
    public IDbConnection Connection { get; }
    public IDbTransaction Transaction { get; set; }

    public DapperContext()
    {
        Connection = new SqlConnection(_configuration.GetConnectionString("SqlConnection"));
        Connection.Open();
    }

    public void Dispose() =>
        Connection?.Dispose();

}
