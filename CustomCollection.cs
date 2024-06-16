using ListEmployee.Data;
using ListEmployee.Interface;

namespace ListEmployee;

public class CustomCollection : ICustomCollection
{
    public Dictionary<string, object> Sort { get; } = new();

    public Dictionary<string, object> Statistics { get; } = new();
}
