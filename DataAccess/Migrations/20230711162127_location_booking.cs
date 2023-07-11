using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class location_booking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DropOffLocId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PickUpLocId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_DropOffLocId",
                table: "Bookings",
                column: "DropOffLocId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PickUpLocId",
                table: "Bookings",
                column: "PickUpLocId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Locations_DropOffLocId",
                table: "Bookings",
                column: "DropOffLocId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Locations_PickUpLocId",
                table: "Bookings",
                column: "PickUpLocId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Locations_DropOffLocId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Locations_PickUpLocId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_DropOffLocId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_PickUpLocId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "DropOffLocId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PickUpLocId",
                table: "Bookings");
        }
    }
}
