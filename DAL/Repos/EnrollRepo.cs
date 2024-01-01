using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EnrollRepo : Repo, IRepo4<Enroll, int, bool>
    {
        public bool Create(Enroll obj)
        {
            db.Enrolls.Add(obj);

            var community = db.Communities.Where(e=>e.CourseId == obj.CourseId).FirstOrDefault();

            if (community != null)

            {
                var cs = new CommunityStudent()
                {
                    CommunityId = community.CommunityId,
                    StudentId = obj.StudentId
                };
                db.CommunityStudents.Add(cs);
                
            }
            var sc = new StudentCourse()
            {
                StudentId = obj.StudentId,
                CourseId = obj.CourseId
            };
            db.StudentCourses.Add(sc);

            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Enroll> Filter(DateTime date)

        {
            //int count = db.Enrolls.Where(e => e.EnrollTime.Month == date.Month).Count();
            return db.Enrolls.Where(e=> e.EnrollTime.Month== date.Month).ToList();
        }

        public List<Enroll> Read()
        {
            throw new NotImplementedException();
        }

        public Enroll Read(int id)
        {
            return db.Enrolls.Find(id);
        }

        public bool Update(Enroll obj)
        {
            throw new NotImplementedException();
        }
    }
}
