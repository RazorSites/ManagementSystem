using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementSystem.Web.Migrations
{
    public partial class FixRAllowanceSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllowanceSalaries_Salaries_SalaryId",
                table: "AllowanceSalaries");

            migrationBuilder.RenameColumn(
                name: "SalaryId",
                table: "AllowanceSalaries",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AllowanceSalaries_SalaryId",
                table: "AllowanceSalaries",
                newName: "IX_AllowanceSalaries_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllowanceSalaries_AspNetUsers_ApplicationUserId",
                table: "AllowanceSalaries",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AllowanceSalaries_AspNetUsers_ApplicationUserId",
                table: "AllowanceSalaries");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "AllowanceSalaries",
                newName: "SalaryId");

            migrationBuilder.RenameIndex(
                name: "IX_AllowanceSalaries_ApplicationUserId",
                table: "AllowanceSalaries",
                newName: "IX_AllowanceSalaries_SalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AllowanceSalaries_Salaries_SalaryId",
                table: "AllowanceSalaries",
                column: "SalaryId",
                principalTable: "Salaries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
