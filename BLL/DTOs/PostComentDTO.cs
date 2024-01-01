using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PostComentDTO:PostDTO
    {
        public List<CommentDTO> Comments { get; set; }

        public PostComentDTO()
        {
            Comments = new List<CommentDTO>();
        }
    }
}
