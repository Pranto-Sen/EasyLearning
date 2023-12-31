using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentCourseDTO
    {

        //public int StudentCourseId { get; set; }

        //[ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual StudentDTO Student { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public virtual CourseDTO Course { get; set; }


        //public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        //public List<StudentCourse> StudentCourses { get; set; }
        //public int StudentCourseId { get; set; }


        //public int? StudentId { get; set; }


        //public int? CourseId { get; set; }
        //public List<StudentCourse> StudentCourses { get; set; }

        //public StudentCourseDTO()
        //{
        //    StudentCourses = new List<StudentCourse>();
        //    StudentCourses = new List<StudentCourse>();


        //}
    }
}
