using Microsoft.Data.SqlClient;

namespace ListEmployee.Interface
{
    public interface IApplicationContext
    {
        Task<SqlConnection> ConnectionAsync();
    }
}