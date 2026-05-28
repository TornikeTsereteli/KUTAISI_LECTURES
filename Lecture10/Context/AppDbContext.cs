using Lecture10.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lecture10.Context;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost,1433;Database=kutaisi;User Id=sa;Password=toko2003!;TrustServerCertificate=True;Encrypt=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}