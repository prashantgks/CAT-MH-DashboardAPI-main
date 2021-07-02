using CATMH_API.DataAccess.InterfaceImplementation;
using CATMH_API.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CAT_MH_DashboardAPI.Controllers
{
    public class OrganizationController : ApiController
    {
        private readonly IOrganization _iOrganization;

        public OrganizationController(IOrganization organization)
        {
            _iOrganization = organization;
        }
        public OrganizationController()
        {
            _iOrganization = new Organizations();
        }
        // GET: Organization
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [Route("api/getOrganizations")]
        [HttpGet]
        public HttpResponseMessage GetOrganizations()
        {
            try
            {
                var result = _iOrganization.GetOrganizations();
                var message = Request.CreateResponse(HttpStatusCode.OK, result);
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }
    }
}