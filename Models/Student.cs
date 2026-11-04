using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE03.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public ICollection<Enrollment> Enrollments { get; set; }
        public DateTime DOB { get; set; }
    }
}