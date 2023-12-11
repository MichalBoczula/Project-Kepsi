using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class ExtendedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefactoredConversationId",
                table: "RefactoredEmails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConversationId",
                table: "Emails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Conversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefactoredConversation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefactoredConversation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefactoredConversation_Conversation_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "Conversation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefactoredEmails_RefactoredConversationId",
                table: "RefactoredEmails",
                column: "RefactoredConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ConversationId",
                table: "Emails",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_Id",
                table: "Conversation",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RefactoredConversation_ConversationId",
                table: "RefactoredConversation",
                column: "ConversationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefactoredConversation_Id",
                table: "RefactoredConversation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Conversation_ConversationId",
                table: "Emails",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id");

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
                name: "FK_Emails_Conversation_ConversationId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmails_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmails");

            migrationBuilder.DropTable(
                name: "RefactoredConversation");

            migrationBuilder.DropTable(
                name: "Conversation");

            migrationBuilder.DropIndex(
                name: "IX_RefactoredEmails_RefactoredConversationId",
                table: "RefactoredEmails");

            migrationBuilder.DropIndex(
                name: "IX_Emails_ConversationId",
                table: "Emails");

            migrationBuilder.DropColumn(
                name: "RefactoredConversationId",
                table: "RefactoredEmails");

            migrationBuilder.DropColumn(
                name: "ConversationId",
                table: "Emails");
        }
    }
}
