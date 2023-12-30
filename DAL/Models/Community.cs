﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Community
    {
        [Key]
        public int CommunityId { get; set; }
        [Required] 
        public string Name { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public Community()
        {
            Students = new List<Student>();
            Posts = new List<Post>();
        }


    }
}