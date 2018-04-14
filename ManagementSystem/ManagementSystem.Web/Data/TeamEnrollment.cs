using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class TeamEnrollment
    {
        public Guid Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
    }
}