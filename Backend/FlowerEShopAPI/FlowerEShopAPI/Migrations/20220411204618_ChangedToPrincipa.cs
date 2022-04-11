using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerEShopAPI.Migrations
{
    public partial class ChangedToPrincipa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Shops_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Id",
                table: "User");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_User_Id",
                table: "User",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_UserId",
                table: "Shops",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_User_UserId",
                table: "Shops",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_User_UserId",
                table: "Shops");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_User_Id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Shops_UserId",
                table: "Shops");

            migrationBuilder.CreateIndex(
                name: "IX_User_Id",
                table: "User",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Shops_Id",
                table: "User",
                column: "Id",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
