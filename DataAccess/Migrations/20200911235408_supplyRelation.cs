using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class supplyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productId",
                table: "suppliers");

            migrationBuilder.AddColumn<int>(
                name: "supplyId",
                table: "supplyDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_supplyDetails_supplyId",
                table: "supplyDetails",
                column: "supplyId");

            migrationBuilder.AddForeignKey(
                name: "FK_supplyDetails_supplies_supplyId",
                table: "supplyDetails",
                column: "supplyId",
                principalTable: "supplies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_supplyDetails_supplies_supplyId",
                table: "supplyDetails");

            migrationBuilder.DropIndex(
                name: "IX_supplyDetails_supplyId",
                table: "supplyDetails");

            migrationBuilder.DropColumn(
                name: "supplyId",
                table: "supplyDetails");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
