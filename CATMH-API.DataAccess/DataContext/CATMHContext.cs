using CATMH_API.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATMH_API.DataAccess.DataContext
{
    public class CATMHContext:DbContext
    {
        public CATMHContext() : base("CATMHContext")
        { }
        public virtual DbSet<Organization> Organization { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
