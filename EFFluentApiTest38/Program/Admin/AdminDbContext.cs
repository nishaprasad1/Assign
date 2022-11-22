global using Microsoft.EntityFrameworkCore;

namespace Admin;
public class AdminDbContext : DbContext
{
    public DbSet<Employee> Employees{ get; set;}
    public DbSet<Department> Departments{ get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\DAC38IIT;Database=office");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
             .ToTable("dept")
             .Property(e => e.Id)
             .HasColumnName("deptno");
        modelBuilder.Entity<Employee>()
             .ToTable("emp")
             .Property(e => e.Id)
             .HasColumnName("eid");
        modelBuilder.Entity<Employee>()
             .Property(e => e.DepartmentId)
             .HasColumnName("deptno");    

    }
}