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
    public class PaymentController : ApiController
    {
        [Route("api/Payment/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = PaymentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [Route("api/Payment/PaymentList/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var ens = PaymentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, ens);
        }
        [Route("api/Payment/ForPost/{id}")]
        [HttpPost]
        public void AddPayment(PaymentModel n)
        {
            PaymentService.Add(n);
        }

    }
}
