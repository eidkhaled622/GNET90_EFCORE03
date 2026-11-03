using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GNET90_EFCORE03.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Desc { get; set; }
        public int? ParentID { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> SubCategory { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}