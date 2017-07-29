using CarParkApp.WebApp.Models;
using CarParkApp.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; 
namespace CarParkApp.WebApp.Controllers
{
    [RoutePrefix("api/tests")]
    public class TestController : ApiController
    {
        private TestRepository testRepository;

        public TestController()
        {
            this.testRepository = new TestRepository();
        }

        [HttpGet, Route("gettests")]
        public HttpResponseMessage GetAllTests()
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, testRepository.GetAllTests());
            resp.Headers.Add("Access-Control-Allow-Origin", "*");
            return resp;
        }
    }
}
