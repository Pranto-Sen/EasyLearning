using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AssignmentDTO
    {
        public int AssignmentId { get; set; }

        [Required]
        public string AssignmentName { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int Mark { get; set; }
    }
}
