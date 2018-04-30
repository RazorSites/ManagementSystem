using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Web.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        #region Navigation Properties

        public ICollection<ProductEnrollment> ProductEnrollments { get; set; }

        public ICollection<Build> Builds { get; set; }

        #endregion
    }
}
