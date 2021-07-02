using CAT_MH_DashboardAPI.Models;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CAT_MH_DashboardAPI.Security
{
    public class CustomAuthServiceProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            await Task.Run(()=>context.Validated());
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var user = await UserSecurity.ValidateUser(context.UserName,context.Password);
            if (user==null)
            {
                context.SetError("invalid_grant","Provided username and password is incorrect.");
                return;
            }

            var identity= new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Role, user.role));
            identity.AddClaim(new Claim(ClaimTypes.Name, user.username));
            identity.AddClaim(new Claim("Email", user.email));
            context.Validated(identity);
        }
    }
}