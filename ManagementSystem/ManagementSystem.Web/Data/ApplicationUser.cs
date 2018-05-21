using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Web.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required, DataType(DataType.CreditCard)]
        public string IdentityCard { get; set; }

        public bool IsLady { get; set; }

        public string Address { get; set; }

        [Range(1900, 3000)]
        public int? YearOfBirth { get; set; }

        [Required]
        public decimal BaseSalary { get; set; }

        [ForeignKey("JobPosition")]
        public Guid? JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }

        public ICollection<Announcement> Announcements { get; set; }
        public ICollection<Complaint> Complaints { get; set; }
        public ICollection<TeamEnrollment> TeamEnrollments { get; set; }
        public ICollection<AllowanceSalary> AllowanceSalaries { get; set; } 
    }
}
