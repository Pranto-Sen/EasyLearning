using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PostDTO
    {
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        //public virtual Student Student { get; set; }

        [ForeignKey("Community")]
        public int? CommunityId { get; set; }
        //public virtual Community Community { get; set; }
    }
}
