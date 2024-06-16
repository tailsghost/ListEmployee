namespace ListEmployee.Data;

public partial class Person
{
    public int Id { get; set; }

    public string FullName { get; set; }

    public DateTime? DateEmploy { get; set; }

    public DateTime? DateUneploy { get; set; }

    public string Deps { get; set; }

    public string Status { get; set; }

    public string Post { get; set; }
}
