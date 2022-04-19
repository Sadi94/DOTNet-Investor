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
    public class CommentService
    {
        public static CommnetModel Get(int id)
        {
            var req = DataAccessFactory.commentdataaccess().Get(id);
            var s = new CommnetModel()
            {
                Id = req.Id,
                Message = req.Message,
                Pid = req.Pid,
                Name = req.Name,

            };
            return s;
        }

        public static List<CommnetModel> Get()
        {
            var reqs = DataAccessFactory.commentdataaccess().Get();
            List<CommnetModel> data = new List<CommnetModel>();
            foreach (var r in reqs)
            {
                data.Add(new CommnetModel() { Id = r.Id,  Message = r.Message, Pid = r.Pid, Name = r.Name});

            }
            return data;
        }

        public static void Add(CommnetModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CommnetModel, Commnet>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Commnet>(p);
            DataAccessFactory.commentdataaccess().Add(data);
        }

        public static void Edit(CommnetModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CommnetModel, Commnet>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Commnet>(p);
            DataAccessFactory.commentdataaccess().Edit(data);
        }

        public static void Delete(CommnetModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CommnetModel, Commnet>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Commnet>(p);
            DataAccessFactory.commentdataaccess().Delete(data);
        }

    }
}

