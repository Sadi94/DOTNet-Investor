using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class loginRepo : Ilogin 
    {
        private InvestrositeEntities db;
        public loginRepo(InvestrositeEntities db)
        {
            this.db = db;
        }
        //static InvestrositeEntities db = new InvestrositeEntities();
        public bool Login(Investor e)
        {
            var n = db.Investors.FirstOrDefault(en => en.Email == e.Email && en.Password == e.Password);
            if (n != null) return true;
            return false;
        }
    }
}
