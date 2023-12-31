using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CommunityStudent
    {
        [Key] 
        public int CommunityStudentId { get; set; }

        [ForeignKey("Community")]
        public int CommunityId { get; set; }

        public virtual Community Community { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
