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
    public class PostService
    {
        public static PostModel Get(int id)
        {
            var req = DataAccessFactory.postDataAccess().Get(id);
            var s = new PostModel()
            {
                Id = req.Id,
                Description = req.Description,
                eid = req.eid,
                Name = req.Name
            };
            return s;
        }

        public static List<PostModel> Get()
        {
            var reqs = DataAccessFactory.postDataAccess().Get();
            List<PostModel> data = new List<PostModel>();
            foreach (var r in reqs)
            {
                data.Add(new PostModel() 
                { Id = r.Id, Description = r.Description, eid = r.eid, Name = r.Name, });

            }
            return data;
        }

        public static void Add(PostModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PostModel, Post>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Post>(p);
            DataAccessFactory.postDataAccess().Add(data);
        }

        public static void Edit(PostModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PostModel, Post>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Post>(p);
            DataAccessFactory.postDataAccess().Edit(data);
        }

        public static void Delete(PostModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PostModel, Post>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Post>(p);
            DataAccessFactory.postDataAccess().Delete(data);
        }
    }
}
