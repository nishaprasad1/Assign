namespace Admin;
public class Department
{
    public int Id {get; set;}
    public string dname {get; set;}
    public string loc {get; set;}
    public List<Employee> Employees { get; set;}

}