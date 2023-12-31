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
    public class CommentDTO
    {
        public int CommentId { get; set; }

        [Required]
        public string CommentText { get; set; }

        public int StudentId { get; set; }

        public int PostId { get; set; }
    }
}
