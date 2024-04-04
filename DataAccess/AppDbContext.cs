using Microsoft.EntityFrameworkCore;
using StudentExamRegistration.DataAccess.Entities;

namespace StudentExamRegistration.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Lesson>? Lessons { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Exam>? Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lesson>().HasKey(l => l.LessonId);
            modelBuilder.Entity<Student>().HasKey(s => s.StudentId);
            modelBuilder.Entity<Exam>().HasKey(e => e.ExamId);

            modelBuilder.Entity<Lesson>()
                .HasMany(l => l.Exams)
                .WithOne(e => e.Lesson)
                .HasForeignKey(e => e.LessonId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Exams)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);
        }
    }
}
