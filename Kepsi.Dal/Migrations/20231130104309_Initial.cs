using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefactoredEmails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "varchar", nullable: false),
                    Topic = table.Column<string>(type: "varchar", nullable: false),
                    Summary = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefactoredEmails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefactoredEmails_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_AddedDate",
                table: "Emails",
                column: "AddedDate");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_Id",
                table: "Emails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefactoredEmails_EmailId",
                table: "RefactoredEmails",
                column: "EmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefactoredEmails_Id",
                table: "RefactoredEmails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefactoredEmails");

            migrationBuilder.DropTable(
                name: "Emails");
        }
    }
}
