using AutoMapper;
using BLL.BusinessEntity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaymentService
    {
        public static PaymentModel Get(int id)
        {
            var req = DataAccessFactory.paymentdataaccess().Get(id);
            var s = new PaymentModel()
            {
                Id = req.Id,
                Amount = req.Amount,
                Eid = req.Eid,
                Iid = req.Iid,

            };
            return s;
        }

        public static List<PaymentModel> Get()
        {
            var reqs = DataAccessFactory.paymentdataaccess().Get();
            List<PaymentModel> data = new List<PaymentModel>();
            foreach (var r in reqs)
            {
                data.Add(new PaymentModel() { Id = r.Id, Amount = r.Amount, Eid = r.Eid, Iid = r.Iid });
            }
            return data;
        }

        public static void Add(PaymentModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentModel, Payment>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Payment>(p);
            DataAccessFactory.paymentdataaccess().Add(data);
        }

        public static void Edit(Payment p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentModel, Payment>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Payment>(p);
            DataAccessFactory.paymentdataaccess().Edit(data);
        }

        public static void Delete(Payment p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentModel, Payment>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Payment>(p);
            DataAccessFactory.paymentdataaccess().Delete(data);
        }
    }
}
