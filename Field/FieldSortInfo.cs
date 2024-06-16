namespace ListEmployee.Field;

public struct FieldSortInfo
{
    public FieldSortInfo(string display, string name)
    {
        this.display = display;
        this.name = name;
    }

    public string display { get; }

    public string name { get; }

    public static IReadOnlyList<FieldSortInfo> FieldsMenuSort { get; } = Array.AsReadOnly(new FieldSortInfo[]
    {
            new FieldSortInfo("ФИО", "last_name"),
            new FieldSortInfo("Статус", "status"),
            new FieldSortInfo("Отделение", "deps"),
            new FieldSortInfo("Должность", "posts"),
            new FieldSortInfo("Дата приема", "date_employ"),
            new FieldSortInfo("Дата увольнения", "date_uneploy")
    });

    public static IReadOnlyList<FieldSortInfo> FieldsMenuSortType { get; } = Array.AsReadOnly(new FieldSortInfo[]
    {
            new FieldSortInfo("Сортировка по возрастанию", "ASC"),
            new FieldSortInfo("Сортировка по убыванию", "DESC")
    });
}
