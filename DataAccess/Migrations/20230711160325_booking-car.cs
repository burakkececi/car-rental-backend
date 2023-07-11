﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bookingcar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CarId",
                table: "Bookings",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Cars_CarId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_CarId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Bookings");
        }
    }
}
