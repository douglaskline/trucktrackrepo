using Microsoft.EntityFrameworkCore.Migrations;

namespace dal.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_report_user_userId",
                table: "report");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "report",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_report_user_userId",
                table: "report",
                column: "userId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_report_user_userId",
                table: "report");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "report",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_report_user_userId",
                table: "report",
                column: "userId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
