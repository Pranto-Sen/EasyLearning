using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : Repo, IRepo<Post, int, bool>
    {
        public bool Create(Post obj)
        {
            db.Posts.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var ex = Read(id); 
            db.Posts.Remove(ex); 
            return db.SaveChanges()>0;
        }

        public List<Post> Read()
        {
            return db.Posts.ToList();
        }

        public Post Read(int id)
        {
           return db.Posts.Find(id);
        }

        public bool Update(Post obj)
        {
           var ex = Read(obj.PostId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
