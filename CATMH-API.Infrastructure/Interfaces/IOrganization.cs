using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATMH_API.Infrastructure.Interfaces
{
    public interface IOrganization
    {
        Task<object> GetOrganizations();
    }
}
