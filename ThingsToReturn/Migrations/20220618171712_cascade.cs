using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThingsToReturn.Migrations
{
    public partial class cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserOffer_Offers_OfferId",
                table: "AppUserOffer");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserOffer_Offers_OfferId",
                table: "AppUserOffer",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserOffer_Offers_OfferId",
                table: "AppUserOffer");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserOffer_Offers_OfferId",
                table: "AppUserOffer",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id");
        }
    }
}
