using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class AllowanceSalary
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        public DateTime ReceivedDay { get; set; }

        [ForeignKey("Salary")]
        public Guid SalaryId { get; set; }
        public Salary Salary { get; set; }

        [ForeignKey("Allowance")]
        public Guid AllowanceId { get; set; }
        public Allowance Allowance { get; set; }
    }
}