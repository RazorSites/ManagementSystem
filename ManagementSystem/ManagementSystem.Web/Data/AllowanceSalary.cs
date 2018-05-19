using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class AllowanceSalary
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        public DateTime ReceivedDay { get; set; }

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Allowance")]
        public Guid AllowanceId { get; set; }
        public Allowance Allowance { get; set; }
    }
}