using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThingsToReturn.Data.Migrations
{
    public partial class testss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferCategories_Categories_CategoryId",
                table: "OfferCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCategories_Categories_CategoryId",
                table: "OfferCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_OfferCategories_Categories_CategoryId",
                table: "OfferCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCategories_Categories_CategoryId",
                table: "OfferCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferCategories_Offers_OfferId",
                table: "OfferCategories",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }
    }
}
