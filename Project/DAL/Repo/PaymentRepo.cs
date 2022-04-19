using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class PaymentRepo : IRepository<Payment, int>
    {
        private InvestrositeEntities db;
        public PaymentRepo(InvestrositeEntities db)
        {
            this.db = db;
        }
        public Payment Get(int id)
        {
            return db.Payments.FirstOrDefault(x => x.Id == id);
        }
        public List<Payment> Get()
        {
            return db.Payments.ToList();
        }
        public bool Add(Payment obj)
        {
            db.Payments.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
        public void Delete(Payment e)
        {
            var n = db.Payments.FirstOrDefault(ef => ef.Id == e.Id);
            db.Payments.Remove(n);
            db.SaveChanges();

        }
        public bool Edit(Payment e)
        {
            var n = db.Payments.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
            if (db.SaveChanges() != 0) return true;
            return false;
        }

    }
}
