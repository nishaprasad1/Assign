using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Admin;

[Table("emp")]
public class Employee
{
    [Column("eid")]
    public string Id{ get; set;}
    public string ename{ get; set;}
    public decimal sal{ get; set;}
    [Column("deptno")]
    public int DepartmentId { get; set;}
    public int age{ get; set;}

}