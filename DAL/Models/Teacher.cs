using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Join Date is required")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Required(ErrorMessage = "TeachingExperience is required")]
        public string TeachingExperience { get; set; }

        [Required(ErrorMessage = "TeachingDomain is required")]
        public string TeachingDomain { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public Teacher() { 
            Courses = new List<Course>();
            Assignments = new List<Assignment>();
        }
    }
}
