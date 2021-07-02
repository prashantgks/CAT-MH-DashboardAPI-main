using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATMH_API.Infrastructure.Entities
{
    [Table("Organization")]
    public class Organization
    {
        [Key]
        public string PKID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZIP { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Credits { get; set; }
        public string WarningLevel { get; set; }
        public string SubjectLabel { get; set; }
        public string Created { get; set; }
        public string Expires { get; set; }
        public string CostPerCredit { get; set; }
        public string MinOrder { get; set; }
    }
}
