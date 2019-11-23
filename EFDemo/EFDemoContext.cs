using EFDemo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EFDemo
{
    public class EFDemoContext: DbContext
    {
        public EFDemoContext() : base("EFDemo") { }

        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Student>()
            //            .HasMany(s => s.Courses)
            //            .WithMany(c => c.Students)
            //            .Map(cs =>
            //            {
            //                cs.MapLeftKey("StudentId");
            //                cs.MapRightKey("CourseId");
            //                cs.ToTable("StudentCourse");
            //            });

            modelBuilder.Entity<Student>()
                .HasMany(s => s.StudentCourse)
                .WithRequired(j => j.Student)
                .HasForeignKey(j => j.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(s => s.StudentCourse)
                .WithRequired(j => j.Course)
                .HasForeignKey(j => j.CourseId);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(j => new { j.StudentId, j.CourseId });
        }
    }
}
