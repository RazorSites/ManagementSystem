using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ManagementSystem.Web.Migrations
{
    public partial class AddBuildTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Build_Products_ProductId",
                table: "Build");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Build_BuildId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Build",
                table: "Build");

            migrationBuilder.RenameTable(
                name: "Build",
                newName: "Builds");

            migrationBuilder.RenameIndex(
                name: "IX_Build_ProductId",
                table: "Builds",
                newName: "IX_Builds_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Builds",
                table: "Builds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Builds_Products_ProductId",
                table: "Builds",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Builds_BuildId",
                table: "Report",
                column: "BuildId",
                principalTable: "Builds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Builds_Products_ProductId",
                table: "Builds");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Builds_BuildId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Builds",
                table: "Builds");

            migrationBuilder.RenameTable(
                name: "Builds",
                newName: "Build");

            migrationBuilder.RenameIndex(
                name: "IX_Builds_ProductId",
                table: "Build",
                newName: "IX_Build_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Build",
                table: "Build",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Build_Products_ProductId",
                table: "Build",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Build_BuildId",
                table: "Report",
                column: "BuildId",
                principalTable: "Build",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
