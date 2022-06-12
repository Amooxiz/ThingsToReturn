using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThingsToReturn.Migrations
{
    public partial class changeddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentSenderId",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Offers",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments",
                column: "CommentReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_CommentSenderId",
                table: "Comments",
                column: "CommentSenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentReceiverId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_CommentSenderId",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                table: "Offers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

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
    }
}
