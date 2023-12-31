using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentPostDTO
    {
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual StudentDTO Student { get; set; }
        public List<PostDTO> Posts { get; set; }

        public StudentPostDTO()
        {
            Posts = new List<PostDTO>();
        }
    }
}
