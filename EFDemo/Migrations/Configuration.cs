namespace EFDemo.Migrations
{
    using EFDemo.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.EFDemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EFDemo.EFDemoContext";
        }

        protected override void Seed(EFDemo.EFDemoContext context)
        {
            //var course = new Course
            //{
            //    Id = 1,
            //    CourseName = "CS",
            //    Description = "Computer Science"
            //};
            //context.Course.Add(course);

            //var student = new Student
            //{
            //    Id = 1,
            //    Name = "Johnny"
            //};
            //student.Courses.Add(course);

            //context.Student.Add(student);
        }
    }
}
