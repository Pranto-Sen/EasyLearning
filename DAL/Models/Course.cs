using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public Course() { 
            Teachers = new List<Teacher>();
            Assignments = new List<Assignment>();
        }

    }
}
