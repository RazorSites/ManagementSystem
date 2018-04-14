using System;
using System.Collections.Generic;

namespace ManagementSystem.Web.Data
{
    public class ProjectBudget
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }

        public ICollection<PaymentMilestone> PaymentMilestones { get; set; }
    }
}