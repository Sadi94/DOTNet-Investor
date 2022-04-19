using BLL;
using BLL.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace InvestroSite.Controllers
{
    public class PostController : ApiController
    {
        [Route("api/Post/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = PostService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [Route("api/Post/PostList/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var ens = PostService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, ens);
        }
        [Route("api/Post/CreatePost")]
        [HttpPost]
        public void AddPost(PostModel n)
        {
            PostService.Add(n);
        }

        [Route("api/Post/EditPost/{id}")]
        [HttpPost]
        public void EditPost(PostModel n)
        {
            PostService.Edit(n);
        }

        [Route("api/Post/PostDelete/")]
        [HttpPost]
        public void DeletePost(PostModel n)
        {
            PostService.Delete(n);
        }

    }
}


