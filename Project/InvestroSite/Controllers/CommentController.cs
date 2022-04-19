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
    public class CommentController : ApiController
    {
        [Route("api/Comment/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = CommentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [Route("api/Comment/CommentList/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var ens = CommentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, ens);
        }
        [Route("api/Comment/CreateComment")]
        [HttpPost]
        public void AddComment(CommnetModel n)
        {
            CommentService.Add(n);
        }

        [Route("api/Comment/EditComment/{id}")]
        [HttpPost]
        public void EditComment(CommnetModel n)
        {
            CommentService.Edit(n);
        }

        [Route("api/Comment/CommentDel")]
        [HttpPost]
        public void DeleteComment(CommnetModel n)
        {
            CommentService.Delete(n);
        }

    }
}
