using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Web.Data
{
    public class Team
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        #region Navigation Properties

        public ICollection<ProductEnrollment> ProductEnrollments { get; set; }

        public ICollection<TeamEnrollment> TeamEnrollments { get; set; }

        #endregion
    }
}
