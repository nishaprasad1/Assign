using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Admin;
[Table ("dept")]
public class Department
{
    [Column("deptno")]
    public int Id {get; set;}
    public string dname {get; set;}
    public string loc {get; set;}
    public List<Employee> Employees { get; set;}

}