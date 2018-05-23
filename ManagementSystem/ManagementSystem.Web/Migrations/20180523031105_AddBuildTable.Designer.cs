﻿// <auto-generated />
using ManagementSystem.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ManagementSystem.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180523031105_AddBuildTable")]
    partial class AddBuildTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManagementSystem.Web.Data.Allowance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Allowwances");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.AllowanceSalary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AllowanceId");

                    b.Property<int>("Count");

                    b.Property<DateTime>("ReceivedDay");

                    b.Property<Guid>("SalaryId");

                    b.HasKey("Id");

                    b.HasIndex("AllowanceId");

                    b.HasIndex("SalaryId");

                    b.ToTable("AllowanceSalaries");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApplicationUserId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<Guid>("JobPositionId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("JobPositionId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Build", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Name");

                    b.Property<Guid>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Complaint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApplicationUserId");

                    b.Property<string>("Content");

                    b.Property<bool>("IsAnonymous");

                    b.Property<bool>("IsReviewed");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.JobDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Benefit");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description");

                    b.Property<string>("Requirement");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("WorkingAddress");

                    b.HasKey("Id");

                    b.ToTable("JobDescriptions");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.JobPosition", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("JobPositions");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.OperationCost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("OperationCosts");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.PaymentMilestone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Milestone");

                    b.Property<float>("Percent");

                    b.Property<Guid>("ProjectBudgetId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectBudgetId");

                    b.ToTable("PaymentMilestones");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.ProductEnrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ProductId");

                    b.Property<Guid>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TeamId");

                    b.ToTable("ProductEnrollment");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.ProjectBudget", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.HasKey("Id");

                    b.ToTable("ProjectBudgets");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BuildId");

                    b.Property<DateTime>("DateOfCreated");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Salary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApplicationUserId");

                    b.Property<decimal>("BaseSalary");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.TeamEnrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApplicationUserId");

                    b.Property<Guid>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamEnrollment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.AllowanceSalary", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.Allowance", "Allowance")
                        .WithMany("AllowanceSalaries")
                        .HasForeignKey("AllowanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManagementSystem.Web.Data.Salary", "Salary")
                        .WithMany("AllowanceSalaries")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Announcement", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Announcements")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.ApplicationUser", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.JobPosition", "JobPosition")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("JobPositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Build", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.Product", "Product")
                        .WithMany("Builds")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Complaint", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("Complaints")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.PaymentMilestone", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ProjectBudget", "ProjectBudget")
                        .WithMany("PaymentMilestones")
                        .HasForeignKey("ProjectBudgetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.ProductEnrollment", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.Product", "Product")
                        .WithMany("ProductEnrollments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManagementSystem.Web.Data.Team", "Team")
                        .WithMany("ProductEnrollments")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Report", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.Build", "Build")
                        .WithMany("Reports")
                        .HasForeignKey("BuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.Salary", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser", "ApplicationUser")
                        .WithOne("Salary")
                        .HasForeignKey("ManagementSystem.Web.Data.Salary", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagementSystem.Web.Data.TeamEnrollment", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("TeamEnrollments")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManagementSystem.Web.Data.Team", "Team")
                        .WithMany("TeamEnrollments")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("ManagementSystem.Web.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
