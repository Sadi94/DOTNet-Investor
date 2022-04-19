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
    public class InvestorController : ApiController
    {
        [Route("api/Investor/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = InvestorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [Route("api/Investor/InvestorList/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var ens = InvestorService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, ens);
        }
        [Route("api/Investor/CreateInvestor")]
        [HttpPost]
        public void AddInvestor(InvestorModel n)
        {
            InvestorService.Add(n);
        }

        [Route("api/Investor/EditInvestor/{id}")]
        [HttpPost]
        public void EditInvestor(InvestorModel n)
        {
            InvestorService.Edit(n);
        }
        [Route("api/Investor/login")]
        [HttpPost]
        public void Login(InvestorModel n)
        {
            InvestorService.Login(n);
        }

        [Route("api/Investor/InvestorDel/")]
        [HttpPost]
        public void DeleteAdmin(InvestorModel n)
        {
            InvestorService.Delete(n);
        }

    }
}
