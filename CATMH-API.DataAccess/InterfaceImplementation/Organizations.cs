using CATMH_API.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATMH_API.DataAccess.InterfaceImplementation
{
    public class Organizations : IOrganization
    {
        public Task<object> GetOrganizations()
        {
            throw new NotImplementedException();
        }
    }
}
