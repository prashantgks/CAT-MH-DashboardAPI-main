using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CAT_MH_DashboardAPI.Controllers
{
    public class ItemLevelController : ApiController
    {
        // GET: ItemLevel
        public HttpResponseMessage Get()
        {
            try
            {
                var message = Request.CreateResponse(HttpStatusCode.OK,"data");
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
            
        }
    }
}