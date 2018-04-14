using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class PaymentMilestone
    {
        public Guid Id { get; set; }
        public DateTime Milestone { get; set; }
        public float Percent { get; set; }

        [ForeignKey("ProjectBudget")]
        public Guid ProjectBudgetId { get; set; }
        public ProjectBudget ProjectBudget { get; set; }
    }
}