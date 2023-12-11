using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class alterConversation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConversationId",
                table: "Conversation",
                newName: "RefactoredConversationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RefactoredConversationId",
                table: "Conversation",
                newName: "ConversationId");
        }
    }
}
