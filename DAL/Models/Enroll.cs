﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Enroll
    {
        [Key]
        public int EnrollId { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        public virtual Course Course { get; set; }

        public DateTime EnrollTime { get; set; } = DateTime.Now;

        public int PaymentAmount { get; set; }

        public string TnxId { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 8);

    }
}
