using System;

namespace ManagementSystem.Web.Data
{
    public class OperationCost
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }
    }
}