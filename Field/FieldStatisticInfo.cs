using System.ComponentModel;

namespace ListEmployee.Field;

public struct FieldStatisticGroup
{
    public FieldStatisticGroup(object date, int count)
    {
        Date = date;
        Count = count;
    }

    public object Date { get;}

    public int Count { get;}

    public static IList<FieldStatisticGroup> FieldsStatisticGroup { get;} = new BindingList<FieldStatisticGroup>() {};

}
