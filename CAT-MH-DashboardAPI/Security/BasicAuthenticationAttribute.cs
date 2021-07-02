using CAT_MH_DashboardAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CAT_MH_DashboardAPI.Security
{
    public class BasicAuthenticationAttribute:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request
                                        .CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodeAuthToken=Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string[] credArray=decodeAuthToken.Split(':');
                string username = credArray[0];
                string password = credArray[1];

                //if (UserSecurity.ValidateUser(new CredentailManager() { username=username,password=password }))
                //{
                //    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("username"), null);
                //}
                //else
                //{
                //    actionContext.Response = actionContext.Request
                //                            .CreateResponse(HttpStatusCode.Unauthorized);
                //}
            }
            base.OnAuthorization(actionContext);
        }
    }
}