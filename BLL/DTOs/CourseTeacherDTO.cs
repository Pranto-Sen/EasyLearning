using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseTeacherDTO:CourseDTO
    {
        public TeacherDTO Teacher { get; set; }

        public CourseTeacherDTO()
        {
            Teacher = new TeacherDTO();
        }
    }
}
