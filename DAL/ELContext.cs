using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ELContext:DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Teacher> Teachers { get; set; }
        public DbSet <Course> Courses { get; set; }
        public DbSet <Assignment> Assignments { get; set; }

        public DbSet <Enroll> Enrolls { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Community> Communities { get; set; }

        public DbSet<Post> Posts { get; set; } 
        public DbSet<CommunityStudent> CommunityStudents { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

    }
}
