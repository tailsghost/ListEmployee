using System.ComponentModel;

namespace ListEmployee.Field;

public struct FieldFilter
{
    public FieldFilter(int id, string text)
    {
        this.text = text;
        this.id = id;
    }

    public string text { get;}
    public int id { get; } = 0;

    public static IList<FieldFilter> FieldsFilterStatus { get;} = new BindingList<FieldFilter>() {
        new FieldFilter(0, "Не выбрано")
    };

    public static IList<FieldFilter> FieldsFilterPosition { get;} = new BindingList<FieldFilter>() {
        new FieldFilter(0, "Не выбрано")
    };

    public static IList<FieldFilter> FieldsFilterDepartment { get;} = new BindingList<FieldFilter>() {
        new FieldFilter(0, "Не выбрано")
    };
}
