using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EnrollDTO
    {
        public int EnrollId { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        //public virtual Student Student { get; set; }

        [ForeignKey("Course")]
        public int? CourseId { get; set; }
        //public virtual Course Course { get; set; }

        public int PaymentAmount { get; set; }
    }
}
