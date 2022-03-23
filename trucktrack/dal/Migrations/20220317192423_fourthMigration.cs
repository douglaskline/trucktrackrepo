using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dal.Migrations
{
    public partial class fourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    locationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latitude = table.Column<float>(type: "real", nullable: false),
                    longitude = table.Column<float>(type: "real", nullable: false),
                    geocode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    locationDescription = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    timeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.locationId);
                });

            migrationBuilder.CreateTable(
                name: "truck",
                columns: table => new
                {
                    truckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    truckName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    homeCity = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: true),
                    homeState = table.Column<string>(type: "CHAR(2)", maxLength: 2, nullable: true),
                    foodStyle = table.Column<string>(type: "VARCHAR(75)", maxLength: 75, nullable: true),
                    priceRange = table.Column<string>(type: "VARCHAR(10)", maxLength: 10, nullable: true),
                    tagLine = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    truckURL = table.Column<string>(type: "VARCHAR(300)", maxLength: 300, nullable: true),
                    timeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_truck", x => x.truckId);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reportTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    truckId = table.Column<int>(type: "int", nullable: false),
                    locationId = table.Column<int>(type: "int", nullable: false),
                    startTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: true),
                    timeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_report_location_locationId",
                        column: x => x.locationId,
                        principalTable: "location",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_report_truck_truckId",
                        column: x => x.truckId,
                        principalTable: "truck",
                        principalColumn: "truckId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_report_user_userId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_report_locationId",
                table: "report",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_report_truckId",
                table: "report",
                column: "truckId");

            migrationBuilder.CreateIndex(
                name: "IX_report_userId",
                table: "report",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "report");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "truck");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
