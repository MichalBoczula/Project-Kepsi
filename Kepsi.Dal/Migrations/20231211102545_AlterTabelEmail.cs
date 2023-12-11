using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepsi.Dal.Migrations
{
    public partial class AlterTabelEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Conversation_ConversationId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredConversation_Conversation_ConversationId",
                table: "RefactoredConversation");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmails_Emails_EmailId",
                table: "RefactoredEmails");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmails_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefactoredEmails",
                table: "RefactoredEmails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation");

            migrationBuilder.RenameTable(
                name: "RefactoredEmails",
                newName: "RefactoredEmail");

            migrationBuilder.RenameTable(
                name: "Conversation",
                newName: "Conversations");

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

            migrationBuilder.RenameIndex(
                name: "IX_Conversation_Id",
                table: "Conversations",
                newName: "IX_Conversations_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Emails",
                type: "varchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefactoredEmail",
                table: "RefactoredEmail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversations",
                table: "Conversations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Conversations_ConversationId",
                table: "Emails",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredConversation_Conversations_ConversationId",
                table: "RefactoredConversation",
                column: "ConversationId",
                principalTable: "Conversations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Conversations_ConversationId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredConversation_Conversations_ConversationId",
                table: "RefactoredConversation");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmail_Emails_EmailId",
                table: "RefactoredEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_RefactoredEmail_RefactoredConversation_RefactoredConversationId",
                table: "RefactoredEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefactoredEmail",
                table: "RefactoredEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conversations",
                table: "Conversations");

            migrationBuilder.RenameTable(
                name: "RefactoredEmail",
                newName: "RefactoredEmails");

            migrationBuilder.RenameTable(
                name: "Conversations",
                newName: "Conversation");

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

            migrationBuilder.RenameIndex(
                name: "IX_Conversations_Id",
                table: "Conversation",
                newName: "IX_Conversation_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Emails",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefactoredEmails",
                table: "RefactoredEmails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conversation",
                table: "Conversation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Conversation_ConversationId",
                table: "Emails",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RefactoredConversation_Conversation_ConversationId",
                table: "RefactoredConversation",
                column: "ConversationId",
                principalTable: "Conversation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
