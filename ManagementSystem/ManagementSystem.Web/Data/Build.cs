using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class Build
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        #region Navigation Properties

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public ICollection<Report> Reports { get; set; }

        #endregion
    }
}