using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AssignmentRepo : Repo, IRepo<Assignment, int, bool>
    {
        public bool Create(Assignment obj)
        {
            db.Assignments.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
           var ex = Read(id);
            db.Assignments.Remove(ex);
            return db.SaveChanges()>0;
        }

        public List<Assignment> Read()
        {
            return db.Assignments.ToList();
        }

        public Assignment Read(int id)
        {
            return db.Assignments.Find(id);
        }

        public bool Update(Assignment obj)
        {
           var ex = Read(obj.AssignmentId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
