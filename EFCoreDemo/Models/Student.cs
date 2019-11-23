using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
