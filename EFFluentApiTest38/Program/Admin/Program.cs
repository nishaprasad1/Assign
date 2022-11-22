using Admin;

var db = new AdminDbContext();

if(args.Length == 0)
{
    foreach( var Department in db.Departments)
        Console.WriteLine("{0, -6}{1, 12}{2, 8}", Department.Id, Department.dname, Department.loc);
}

else
{
    int dno = int.Parse(args[0]);
    var department = db.Departments
                .Where(e => e.Id == dno)
                .Include(p => p.Employees)
                .FirstOrDefault();
    if(department != null)
    {
        foreach(var employee in department.Employees)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",employee.Id, employee.ename, employee.sal, employee.age);
    }
}
