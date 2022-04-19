using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CommentRepo : IRepository<Commnet, int>
    {
        private InvestrositeEntities db;
        public CommentRepo(InvestrositeEntities db)
        {
            this.db = db;
        }
        public Commnet Get(int id)
        {
            return db.Commnets.FirstOrDefault(x => x.Id == id);
        }
        public List<Commnet> Get()
        {
            return db.Commnets.ToList();
        }
        public bool Add(Commnet obj)
        {
            db.Commnets.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
        public void Delete(Commnet e)
        {
            var n = db.Commnets.FirstOrDefault(ef => ef.Id == e.Id);
            db.Commnets.Remove(n);
            db.SaveChanges();

        }
        public bool Edit(Commnet e)
        {
            var n = db.Commnets.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
            if (db.SaveChanges() != 0) return true;
            return false;
        }

    }
}
