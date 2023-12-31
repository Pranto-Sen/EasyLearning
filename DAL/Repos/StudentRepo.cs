using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StudentRepo : Repo,IRepo2<Student,int,bool>
    {
        public bool Create(Student obj)
        {
           db.Students.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Students.Remove(ex);
            return db.SaveChanges()>0;
        }

        public List<Student> Read()
        {
           return db.Students.ToList();
        }

        public Student Read(int id)
        {
            return db.Students.Find(id);
            
        }

        //public List<Student> GetCourse(int id)
        //{
        //    return db.Students.Where(e=> e.StudentId == id).ToList();
        //}

        public bool Update(Student obj)
        {
            var ex = Read(obj.StudentId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges()>0;
        }

        public List<StudentCourse> GetCourse(int id)
        {
            return db.StudentCourses.Where(e => e.StudentId == id).ToList();
        }

        public List<Assignment> GetCoursewithAssignment(int id)
        {
            List<Assignment> assignment = new List<Assignment>();
            var courselist = db.StudentCourses.Where(e => e.StudentId == id).ToList();
            foreach (var course in courselist)
            {
                List<Assignment> assign = db.Assignments.Where(e => e.CourseId == course.CourseId).ToList();
                foreach(var a in assign)
                {
                    assignment.Add(a);
                }
                
            }
            return assignment;
        }
    }
}
