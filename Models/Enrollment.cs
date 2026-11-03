using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE03.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollDate { get; set; }
        public decimal Progress { get; set; }
        public Status Status { get; set; }
        public decimal FinalGrade { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}