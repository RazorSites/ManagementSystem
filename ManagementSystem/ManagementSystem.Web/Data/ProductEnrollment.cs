using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class ProductEnrollment
    {
        public Guid Id { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Team")]
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
    }
}