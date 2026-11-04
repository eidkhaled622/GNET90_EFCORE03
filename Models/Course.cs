using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE03.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CourseLevel Level { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsPublished { get; set; }
    }
}