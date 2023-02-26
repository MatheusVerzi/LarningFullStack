using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LarningFullStackData.Migrations
{
    public partial class InsertingdefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("39e46af9-e154-48ec-823a-f16554f5fb8f"), " userdefault@larningFullStack.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e46af9-e154-48ec-823a-f16554f5fb8f"));
        }
    }
}
