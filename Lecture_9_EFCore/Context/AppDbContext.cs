using Lecture_9_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lecture_9_EFCore.Context;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString =
            "Server=DESKTOP-I3HCTTD;Database=kutaisi;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True;";
        optionsBuilder.UseSqlServer(
            connectionString);
    }
}