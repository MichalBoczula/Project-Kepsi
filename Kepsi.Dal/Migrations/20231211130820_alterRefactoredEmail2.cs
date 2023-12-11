using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class alterRefactoredEmail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RefactoredConversationId",
                table: "RefactoredEmail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 8, 20, 346, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 8, 20, 346, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 8, 20, 346, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 8, 20, 346, DateTimeKind.Local).AddTicks(9982));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RefactoredConversationId",
                table: "RefactoredEmail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
