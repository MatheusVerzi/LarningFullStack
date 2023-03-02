using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LarningFullStackData.Migrations
{
    public partial class GlobalConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e46af9-e154-48ec-823a-f16554f5fb8f"),
                column: "DateCreated",
                value: new DateTime(2023, 3, 1, 22, 18, 4, 277, DateTimeKind.Local).AddTicks(9988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39e46af9-e154-48ec-823a-f16554f5fb8f"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 26, 20, 45, 54, 891, DateTimeKind.Local).AddTicks(1594));
        }
    }
}
