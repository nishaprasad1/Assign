global using Microsoft.EntityFrameworkCore;

namespace DemoApp.Admin;
public class AdminDbContext : DbContext
{
    public DbSet<Employee> Employees{ get; set;}
    public DbSet<Department> Departments{ get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DAC38IIT;Database=office");
    }
}