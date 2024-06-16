using ListEmployee.Field;
using ListEmployee.Interface;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ListEmployee.ServiceHelper;

public static class HelperExtension
{

    public static async void GetPersonalHandler(this SqlDataReader reader)
    {
        try
        {
            FieldPerson.FieldsPerson.Clear();

            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    DateTime? Employ = (reader.GetValue(2) == DBNull.Value) ? null : reader.GetDateTime(2);
                    DateTime? Uneploy = (reader.GetValue(3) == DBNull.Value) ? null : reader.GetDateTime(3);

                    FieldPerson.FieldsPerson.Add(new FieldPerson(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(5),
                    reader.GetString(4),
                    reader.GetString(6),
                    Employ,
                    Uneploy
                    ));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка получения записи с БД. {ex.Message}");
        }
    }


    public static async Task GetStatisticHandler(this SqlDataReader reader, ICustomCollection _collection)
    {

        FieldStatisticGroup.FieldsStatisticGroup.Clear();

        try
        {
            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    FieldStatisticGroup.FieldsStatisticGroup.Add(new FieldStatisticGroup(reader.GetValue(0) == DBNull.Value ? "Без даты" : reader.GetValue(0), reader.GetInt32(1)));
                };
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public static async Task<int?> GetStatisticCountHandler(this SqlDataReader reader, int filterId, IApplicationContext _context)
    {
        int? result = null;
        if (filterId > 0)
        {
            using var context = await _context.ConnectionAsync();
            Dictionary<string, int> statistic = new();

            statistic.Add("@Status", filterId);
            var command = statistic.SqlParams("getStatisticsStatus", context);

            try
            {

                SqlDataReader reader1 = await command.ExecuteReaderAsync();
                if (reader1.HasRows)
                {
                    await reader1.ReadAsync();

                    if (reader1.GetValue(1) != DBNull.Value)
                    {
                        result = reader1.GetInt32(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        return result;
    }

    public static async Task GetComboHandler(this SqlDataReader reader, string sqlExpression, IApplicationContext _context)
    {
        try
        {
            if (reader.HasRows)
                while (await reader.ReadAsync())
                {
                    if (sqlExpression == "GetStatus")
                        FieldFilter.FieldsFilterStatus.Add(new FieldFilter(reader.GetInt32(0), reader.GetString(1)));
                    else if (sqlExpression == "GetPosition")
                        FieldFilter.FieldsFilterPosition.Add(new FieldFilter(reader.GetInt32(0), reader.GetString(1)));
                    else if (sqlExpression == "GetDepartment")
                        FieldFilter.FieldsFilterDepartment.Add(new FieldFilter(reader.GetInt32(0), reader.GetString(1)));
                }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public static SqlCommand SqlParams<T>(this Dictionary<string, T> parametr, string sqlExpression, SqlConnection context)
    {
        SqlCommand command = new SqlCommand(sqlExpression, context);

        command.CommandType = CommandType.StoredProcedure;

        foreach (KeyValuePair<string, T> kvp in parametr)
        {
            SqlParameter param = new SqlParameter()
            {
                ParameterName = kvp.Key,
                Value = kvp.Value
            };

            command.Parameters.Add(param);
        }

        return command;
    }

}

