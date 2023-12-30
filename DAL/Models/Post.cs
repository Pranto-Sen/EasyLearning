using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
      
        [Required]  
        public DateTime Created { get; set; } = DateTime.Now;

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Community")]
        public int? CommunityId { get; set; }
        public virtual Community Community { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public Post()
        {
            Comments = new List<Comment>();
        }

    }
}
