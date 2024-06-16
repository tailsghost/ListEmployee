using System.ComponentModel;

namespace ListEmployee.Field;

public struct FieldPerson
{
    public FieldPerson(int id, string fullname, string status, string department, string post, DateTime? employ, DateTime? uneploy)
    {
        Id = id;
        FullName = fullname;
        Status = status;
        Department = department;
        Post = post;
        Employ = employ;
        Uneploy = uneploy;
    }

    public int Id { get;}

    public string FullName { get; }

    public string Status { get; }

    public string Department { get; }

    public string Post { get; }

    public DateTime? Employ {  get; }

    public DateTime? Uneploy { get; }

    public static IList<FieldPerson> FieldsPerson { get;} = new BindingList<FieldPerson>() {};
}
