using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class Salary
    {
        public Guid Id { get; set; }
        public decimal BaseSalary { get; set; }

        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<AllowanceSalary> AllowanceSalaries { get; set; }
    }
}