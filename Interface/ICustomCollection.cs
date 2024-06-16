using ListEmployee.Data;

namespace ListEmployee.Interface;

public interface ICustomCollection
{
    Dictionary<string, object> Sort { get;}

    Dictionary<string, object> Statistics { get;}
}