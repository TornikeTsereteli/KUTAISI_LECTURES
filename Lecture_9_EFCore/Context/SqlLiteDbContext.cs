using Lecture_9_EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lecture_9_EFCore.Context;

public class SqlLiteDbContext : DbContext
{
    
    public DbSet<Person> Persons { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Data Source=C:\\Users\\WERO\\RiderProjects\\KUTAISI_LECTURES\\Lecture_9_EFCore\\db.sqlite";
        optionsBuilder.UseSqlite(connectionString);
    }
}