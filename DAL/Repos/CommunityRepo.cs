using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommunityRepo : Repo, IRepo<Community, int, bool>
    {
        public bool Create(Community obj)
        {
            db.Communities.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Communities.Remove(ex); 
            return db.SaveChanges() > 0;
        }

        public List<Community> Read()
        {
            return db.Communities.ToList();
        }

        public Community Read(int id)
        {
            return db.Communities.Find(id);
        }

        public bool Update(Community obj)
        {
            var ex = Read(obj.CommunityId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
