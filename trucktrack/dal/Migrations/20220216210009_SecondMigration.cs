using Microsoft.EntityFrameworkCore.Migrations;

namespace dal.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_report_location_locationId",
                table: "report");

            migrationBuilder.DropForeignKey(
                name: "FK_report_truck_truckId",
                table: "report");

            migrationBuilder.AddForeignKey(
                name: "FK_report_location_locationId",
                table: "report",
                column: "locationId",
                principalTable: "location",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_report_truck_truckId",
                table: "report",
                column: "truckId",
                principalTable: "truck",
                principalColumn: "truckId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_report_location_locationId",
                table: "report");

            migrationBuilder.DropForeignKey(
                name: "FK_report_truck_truckId",
                table: "report");

            migrationBuilder.AddForeignKey(
                name: "FK_report_location_locationId",
                table: "report",
                column: "locationId",
                principalTable: "location",
                principalColumn: "locationId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_report_truck_truckId",
                table: "report",
                column: "truckId",
                principalTable: "truck",
                principalColumn: "truckId",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
