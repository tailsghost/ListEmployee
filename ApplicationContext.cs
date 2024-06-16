using ListEmployee.Interface;
using Microsoft.Data.SqlClient;

namespace ListEmployee;

public class ApplicationContext : IApplicationContext
{
    private string connectionString = new ConnectionSettings().ConnectionString;

    private SqlConnection connection;


    public async Task<SqlConnection> ConnectionAsync()
    {
        connection = new SqlConnection(connectionString);

        await connection.OpenAsync();

        return connection;
    }
}
