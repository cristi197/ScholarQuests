using HighSchoolQuiz.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HighSchoolQuiz.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } 
    public DbSet<HighSchool> HighSchools { get; set; } 
    public DbSet<Class> Classes { get; set; } 
    public DbSet<Homework> Homeworks { get; set; } 
    public DbSet<Suggestion> Suggestions { get; set; } 
    public DbSet<HomeworkProblem> HomeworkProblems { get; set; } 
    public DbSet<Problem> Problems { get; set; } 
    public DbSet<Solution> Solutions { get; set; } 
    public DbSet<Notification> Notifications { get; set; } 
    public DbSet<ProblemTest> ProblemTests { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                  .ValueGeneratedOnAdd();
            entity.HasIndex(u => u.Email)
                  .IsUnique();
            entity.Property(e=>e.Role)
                  .HasConversion<string>(); // Store enum as string
        });

        modelBuilder.Entity<HighSchool>()
            .ToTable("HighSchools")
            .HasMany(s => s.Classes)
            .WithOne(c => c.HighSchool)
            .HasForeignKey(c => c.HighSchoolId);

        modelBuilder.Entity<Class>()
            .ToTable("Classes")
            .HasIndex(c => new { c.Name, c.HighSchoolId })
            .IsUnique();

        modelBuilder.Entity<Homework>()
            .ToTable("Homeworks");

        modelBuilder.Entity<Suggestion>()
            .ToTable("Suggestions")
            .Property(s => s.Type)
            .HasConversion<string>(); // Store enum as string

        modelBuilder.Entity<HomeworkProblem>()
            .ToTable("HomeworkProblems");

        modelBuilder.Entity<Problem>(entity =>
        {
            entity.ToTable("Problems");

            entity.Property(p => p.Status)
                  .HasConversion<string>(); // Store enum as string

            entity.Property(p => p.Difficulty)
                  .HasConversion<string>(); // Store enum as string

            entity.HasMany(p => p.Tests)
                  .WithOne(t => t.Problem)
                  .HasForeignKey(t => t.ProblemId);
        });

        modelBuilder.Entity<ProblemTest>().ToTable("ProblemTests");

        modelBuilder.Entity<Notification>()
            .ToTable("Notifications")
            .Property(n => n.Type)
            .HasConversion<string>();

        modelBuilder.Entity<HomeworkProblem>(entity =>
        {
            entity.ToTable("HomeworkProblems");
            entity.HasKey(hp => new { hp.HomeworkId, hp.ProblemId });

            entity.HasOne(hp => hp.Homework)
                  .WithMany(h => h.HomeworkProblems)
                  .HasForeignKey(hp => hp.HomeworkId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(hp => hp.Problem)
                  .WithMany(p => p.HomeworkProblems)
                  .HasForeignKey(hp => hp.ProblemId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Solution>(entity =>
        {
            entity.HasKey(s => new { s.ProblemId, s.StudentId });
            entity.HasOne(s => s.Problem)
                  .WithMany(p => p.Solutions)
                  .HasForeignKey(s => s.ProblemId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(s => s.Student)
                  .WithMany(u => u.Solutions)
                  .HasForeignKey(s => s.StudentId)
                  .OnDelete(DeleteBehavior.Restrict);

        });
    }
}
