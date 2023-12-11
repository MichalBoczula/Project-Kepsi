using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class alterRefactoredEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "RefactoredEmail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "RefactoredEmail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 13, 9, 25, 528, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 13, 9, 25, 528, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 13, 9, 25, 528, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 13, 9, 25, 528, DateTimeKind.Local).AddTicks(2959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "RefactoredEmail");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "RefactoredEmail");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 11, 26, 37, 256, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 11, 26, 37, 256, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 11, 26, 37, 256, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 11, 26, 37, 256, DateTimeKind.Local).AddTicks(4492));
        }
    }
}
