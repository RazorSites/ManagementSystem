using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementSystem.Web.Data
{
    public class Report
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreated { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; }

        #region Navigation Properties

        [ForeignKey("Build")]
        public Guid BuildId { get; set; }
        public Build Build { get; set; }

        #endregion
    }
}