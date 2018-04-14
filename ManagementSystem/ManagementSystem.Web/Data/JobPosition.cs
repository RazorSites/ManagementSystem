using System;
using System.Collections.Generic;

namespace ManagementSystem.Web.Data
{
    public class JobPosition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}