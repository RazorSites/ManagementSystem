using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Web.Data
{
    public class JobDescription
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string WorkingAddress { get; set; }
        public string Requirement { get; set; }
        public string Benefit { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime Deadline { get; set; }
    }
}