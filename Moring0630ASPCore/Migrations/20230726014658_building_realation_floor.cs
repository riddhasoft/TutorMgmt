using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moring0630ASPCore.Migrations
{
    /// <inheritdoc />
    public partial class building_realation_floor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildingId",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Buildings_BuildingId",
                table: "Floors",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Buildings_BuildingId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Floors");
        }
    }
}
