using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, int, bool>
    {
        public bool Create(Course obj)
        {
            db.Courses.Add(obj);
            var community = new Community()
            {
                Name = obj.CourseName,
                CourseId = obj.CourseId,
            };
            db.Communities.Add(community);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Courses.Remove(ex);
            return db.SaveChanges()>0;
        }

        public List<Course> Read()
        {
           return db.Courses.ToList();
        }

        public Course Read(int id)
        {
            return db.Courses.Find(id);

        }

        public bool Update(Course obj)
        {
           var ex = Read(obj.CourseId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
