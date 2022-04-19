using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;


namespace DAL.Repo
{
    public class InvestorRepo : IRepository<Investor, int>
    {
        private InvestrositeEntities db;
        public InvestorRepo(InvestrositeEntities db)
        {
            this.db = db;
        }
        public Investor Get(int id)
        {
            return db.Investors.FirstOrDefault(x => x.Id == id);
        }
        public List<Investor> Get()
        {
            return db.Investors.ToList();
        }
        public bool Add(Investor obj)
        {
            db.Investors.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
        public void Delete(Investor e)
        {
            var n = db.Investors.FirstOrDefault(ef => ef.Id == e.Id);
            db.Investors.Remove(n);
            db.SaveChanges();

        }
       
        public bool Edit(Investor e)
        {
            var n = db.Investors.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
            if (db.SaveChanges() != 0) return true;
            return false;
        }

    }
}
