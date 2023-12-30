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
    public class CommunityDTO
    {
        public int CommunityId { get; set; }
        [Required]
        public string Name { get; set; }
        public int CourseId { get; set; }
    }
}
