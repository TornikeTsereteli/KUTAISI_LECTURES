using Lecture11_EFCORE_Migrations.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lecture11_EFCORE_Migrations.Context;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        var connectionString = "Server=localhost,1433;Database=University;User Id=sa;Password=toko2003!;TrustServerCertificate=True;Encrypt=True;";

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>().HasKey(c => c.Id);
        modelBuilder.Entity<Teacher>().HasKey(t => t.Id);
        modelBuilder.Entity<Student>().HasKey(s => s.Id);

        modelBuilder.Entity<Student>().Property(s => s.FullName).HasMaxLength(100);
        
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new {e.StudentId, e.CourseId});
        
        
        modelBuilder.Entity<Course>()
            .HasOne(c=>c.Teacher)
            .WithMany(t => t.Courses)
            .HasForeignKey(c=>c.TeacherId);
        
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.StudentId);
        
        
        modelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(s => s.Enrollments)
            .HasForeignKey(e => e.CourseId);
        
    }
}
