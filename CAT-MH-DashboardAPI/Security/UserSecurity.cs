using CAT_MH_DashboardAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CAT_MH_DashboardAPI.Security
{
    public class UserSecurity:IDisposable
    {
        public async static Task<CredentailManager> ValidateUser(string username,string password)
        {
            return await Task.Run(()=>new CredentailManager() { username="Ashish",email="ashish.joshi@gksil.com",role="Admin" });
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}