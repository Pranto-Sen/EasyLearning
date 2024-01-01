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

        public static IRepo<Community, int, bool> CommunityData()
        {
            return new CommunityRepo();
        }

        public static IRepo2<Student, int, bool> StudentData()
        {
            return new StudentRepo();
        }

        public static IRepo4<Enroll, int, bool> EnrollData()
        {
            return new EnrollRepo();
        }
        public static IRepo3<Post, int, bool> PostData()
        {
            return new PostRepo();
        }

        public static IRepo<Comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }
    }
}
