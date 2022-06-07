using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThingsToReturn.Migrations
{
    public partial class commentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentatorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentatorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentatorId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "CommentReceiverId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CommentSenderId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentReceiverId",
                table: "Comments",
                column: "CommentReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentSenderId",
                table: "Comments",
                column: "CommentSenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments",
                column: "CommentReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentSenderId",
                table: "Comments",
                column: "CommentSenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentSenderId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CommentSenderId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CommentSenderId",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "CommentatorId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommentatorId",
                table: "Comments",
                column: "CommentatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentatorId",
                table: "Comments",
                column: "CommentatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
