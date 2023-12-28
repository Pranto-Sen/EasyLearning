using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public Course() {
            Assignments = new List<Assignment>();
        }

    }
}
