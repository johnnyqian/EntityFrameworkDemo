using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main()
        {
            using (var context = new EFDemoContext())
            {
                context.Database.Log = log => Debug.WriteLine(log);

                var student = context.Student.Find(1);
                var course = context.Course.Find(1);
                //var course = context.Student
                //    .Where(s => s.Id == 1)
                //    .SelectMany(s => s.Courses.Where(c => c.Id == 1))
                //    .SingleOrDefault();

                if (course != null)
                {
                    // student.Courses.Remove(course);

                    //context.Database.ExecuteSqlCommand("DELETE [dbo].[StudentCourse] WHERE StudentId = @p0 AND CourseId = @p1",
                    //    new SqlParameter("@p0", 1),
                    //    new SqlParameter("@p1", 1));

                    //((IObjectContextAdapter)context)
                    //    .ObjectContext
                    //    .ObjectStateManager
                    //    .ChangeRelationshipState(student, course, s => s.Courses, EntityState.Deleted);

                    // context.SaveChanges();
                }

                var studentCourse = context.StudentCourse.Find(1, 1);
                context.StudentCourse.Remove(studentCourse);
                context.SaveChanges();
            }

            Console.WriteLine("Done.");
        }
    }
}
