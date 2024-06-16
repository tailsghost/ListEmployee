namespace ListEmployee.Interface;

public interface IService
{
    Task GetPersonAsync();
    Task<int?> GetStatisticsStatusAsync(int filterId, DateTime fromDate, DateTime toDate);
    Task GetComboBoxAsync(string sqlExpression);
}