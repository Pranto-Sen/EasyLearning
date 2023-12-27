using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Teacher,int,bool> TeacherData()
        {
            return new TeacherRepo();
        }
        public static IRepo<Course, int, bool> CourseData()
        {
            return new CourseRepo();
        }
        public static IRepo<Assignment, int, bool> AssignmentData()
        {
            return new AssignmentRepo();
        }
    }
}
