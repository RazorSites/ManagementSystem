using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Web.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        public Salary Salary { get; set; }

        [ForeignKey("JobPosition")]
        public Guid JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }

        public ICollection<Announcement> Announcements { get; set; }
        public ICollection<Complaint> Complaints { get; set; }

        public ICollection<TeamEnrollment> TeamEnrollments { get; set; }

    }
}
