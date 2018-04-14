using System;
using System.Collections.Generic;

namespace ManagementSystem.Web.Data
{
    public class Allowance
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public ICollection<AllowanceSalary> AllowanceSalaries { get; set; }
    }
}