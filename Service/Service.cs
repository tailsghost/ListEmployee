using ListEmployee.Field;
using ListEmployee.Interface;
using ListEmployee.ServiceHelper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ListEmployee.MyService;

public class Service : IService
{
    private IApplicationContext _context;

    private ICustomCollection _collection { get; }

    public Service(ICustomCollection collection, IApplicationContext context)
    {
        _collection = collection;
        _context = context;
    }

    public async Task GetPersonAsync()
    {

        using var context = await _context.ConnectionAsync();

        var command = _collection.Sort.SqlParams("getPersonalSort", context);

        SqlDataReader reader = await command.ExecuteReaderAsync();

        reader.GetPersonalHandler();


        return;
    }

    public async Task GetComboBoxAsync(string sqlExpression)
    {
        using var context = await _context.ConnectionAsync();

        SqlCommand command = new SqlCommand(sqlExpression, context);

        command.CommandType = CommandType.StoredProcedure;

        SqlDataReader reader = await command.ExecuteReaderAsync();

        await reader.GetComboHandler(sqlExpression, _context);

        return;
    }

    public async Task<int?> GetStatisticsStatusAsync(int filterId, DateTime fromDate, DateTime toDate)
    {
        using var context = await _context.ConnectionAsync();

        _collection.Statistics["@Status"] = filterId;

        _collection.Statistics["@FromDate"] = fromDate;

        _collection.Statistics["@ToDate"] = toDate;

        var command = _collection.Statistics.SqlParams("getStatistics", context);

        using (SqlDataReader reader = await command.ExecuteReaderAsync())
        {
            await reader.GetStatisticHandler(_collection);
        };

        SqlDataReader reader1 = await command.ExecuteReaderAsync();

        int? result = await reader1.GetStatisticCountHandler(filterId, _context);

        return result;
    }
}