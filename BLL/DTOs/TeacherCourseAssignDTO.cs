using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeacherCourseAssignDTO:TeacherDTO
    {
        public List<CourseAssignmentDTO> Courses { get; set; }

        public TeacherCourseAssignDTO()
        {
            Courses = new List<CourseAssignmentDTO>();
        }

        
    }
}
