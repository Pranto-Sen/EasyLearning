using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseAssignmentDTO:CourseDTO
    {
        public List<AssignmentDTO> Assignments { get; set; }

        public CourseAssignmentDTO()
        {
            Assignments = new List<AssignmentDTO>();
        }
    }
}
