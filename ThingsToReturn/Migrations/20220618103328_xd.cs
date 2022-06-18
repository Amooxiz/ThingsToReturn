using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThingsToReturn.Migrations
{
    public partial class xd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Offers",
                type: "nvarchar(245)",
                maxLength: 245,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Offers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(245)",
                oldMaxLength: 245);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }
    }
}
