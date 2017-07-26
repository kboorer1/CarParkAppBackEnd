using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarParkApp.WebApp.Controllers
{

  //  [ApiAuthenticationFilter]
  //  [RoutePrefix("api/v0/carparks")]
    public class CarParkController :ApiController  // AuthedApiController
    {
     /*   public CarParkController(IService service) : base(service)
        {

        }

        [HttpGet, Route()]
        public HttpResponseMessage Get([FromUri]CarParkRequest query)
        {
            var requestQuery = query ?? new CarParkRequest();
            var resp = Request.CreateResponse(HttpStatusCode.OK, service.CarPark.Get(Identity.Session, requestQuery));
            resp.Headers.Add(Constants.PAGE_HEADER, requestQuery.Page.ToString());
            resp.Headers.Add(Constants.PER_PAGE_HEADER, requestQuery.PerPage.ToString());
            return resp;
        } */
    } 
}