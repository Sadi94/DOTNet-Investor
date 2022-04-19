using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PostRepo : IRepository<Post, int>
    {
        private InvestrositeEntities db;
        public PostRepo(InvestrositeEntities db)
        {
            this.db = db;
        }
        public Post Get(int id)
        {
            return db.Posts.FirstOrDefault(x => x.Id == id);
        }
        public List<Post> Get()
        {
            return db.Posts.ToList();
        }
        public bool Add(Post obj)
        {
            db.Posts.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
        public void Delete(Post e)
        {
            var n = db.Posts.FirstOrDefault(ef => ef.Id == e.Id);
            db.Posts.Remove(n);
            db.SaveChanges();

        }
        public bool Edit(Post e)
        {
            var n = db.Posts.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
            if (db.SaveChanges() != 0) return true;
            return false;
        }

    }
}

