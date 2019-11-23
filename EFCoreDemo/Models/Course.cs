using System.Collections.Generic;

namespace EFCoreDemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
