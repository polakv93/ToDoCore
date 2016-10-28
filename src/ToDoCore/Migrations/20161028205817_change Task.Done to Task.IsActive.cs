using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoCore.Migrations
{
    public partial class changeTaskDonetoTaskIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Tasks");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tasks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tasks");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Tasks",
                nullable: false,
                defaultValue: false);
        }
    }
}
