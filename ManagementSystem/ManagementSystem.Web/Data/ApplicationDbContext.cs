using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ManagementSystem.Web.Data;

namespace ManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        #region Finance
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Allowance> Allowwances { get; set; }
        public DbSet<AllowanceSalary> AllowanceSalaries { get; set; }
        public DbSet<ProjectBudget> ProjectBudgets { get; set; }
        public DbSet<PaymentMilestone> PaymentMilestones { get; set; }
        public DbSet<OperationCost> OperationCosts { get; set; }
        #endregion


        #region HR
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        #endregion

        #region Product Management
        public DbSet<Product> Products { get; set; }
        public DbSet<Build> Builds { get; set; }
        #endregion
    }
}
