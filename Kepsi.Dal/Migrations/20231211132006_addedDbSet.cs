using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class addedDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmail_Emails_EmailId",
                table: "RefactoredEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmail_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefactoredEmail",
                table: "RefactoredEmail");

            migrationBuilder.RenameTable(
                name: "RefactoredEmail",
                newName: "RefactoredEmails");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmail_RefactoredConversationId",
                table: "RefactoredEmails",
                newName: "IX_RefactoredEmails_RefactoredConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmail_Id",
                table: "RefactoredEmails",
                newName: "IX_RefactoredEmails_Id");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmail_EmailId",
                table: "RefactoredEmails",
                newName: "IX_RefactoredEmails_EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefactoredEmails",
                table: "RefactoredEmails",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 20, 6, 535, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 20, 6, 535, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 20, 6, 535, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 20, 6, 535, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredEmails_Emails_EmailId",
                table: "RefactoredEmails",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredEmails_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmails",
                column: "RefactoredConversationId",
                principalTable: "RefactoredConversation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmails_Emails_EmailId",
                table: "RefactoredEmails");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmails_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefactoredEmails",
                table: "RefactoredEmails");

            migrationBuilder.RenameTable(
                name: "RefactoredEmails",
                newName: "RefactoredEmail");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmails_RefactoredConversationId",
                table: "RefactoredEmail",
                newName: "IX_RefactoredEmail_RefactoredConversationId");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmails_Id",
                table: "RefactoredEmail",
                newName: "IX_RefactoredEmail_Id");

            migrationBuilder.RenameIndex(
                name: "IX_RefactoredEmails_EmailId",
                table: "RefactoredEmail",
                newName: "IX_RefactoredEmail_EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefactoredEmail",
                table: "RefactoredEmail",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 18, 12, 84, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 18, 12, 84, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 18, 12, 84, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 11, 14, 18, 12, 84, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredEmail_Emails_EmailId",
                table: "RefactoredEmail",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredEmail_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmail",
                column: "RefactoredConversationId",
                principalTable: "RefactoredConversation",
                principalColumn: "Id");
        }
    }
}
