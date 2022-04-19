using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Database;
using DAL.Repo;



namespace DAL
{
    public class DataAccessFactory
    {

        static InvestrositeEntities db = new InvestrositeEntities();
        public static IRepository<Investor,int> InvestorDataAccess()
        {
            return new InvestorRepo(db);
        }


        public static Ilogin logindataAccess()
        {
            return new loginRepo(db);
        }
        public static IRepository<Payment, int> paymentdataaccess()
        {
            return new PaymentRepo(db);
        }
        public static IRepository<Commnet, int> commentdataaccess()
        {
            return new CommentRepo(db);
        }
        public static IRepository<Post, int> postDataAccess()
        {
            return new PostRepo(db);
        }
    }
}
