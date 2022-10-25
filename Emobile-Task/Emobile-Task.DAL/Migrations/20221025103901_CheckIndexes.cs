using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emobile_Task.DAL.Migrations
{
    public partial class CheckIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountriesId",
                table: "Travel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Travel_CountriesId",
                table: "Travel",
                column: "CountriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travel_Countries_CountriesId",
                table: "Travel",
                column: "CountriesId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travel_Countries_CountriesId",
                table: "Travel");

            migrationBuilder.DropIndex(
                name: "IX_Travel_CountriesId",
                table: "Travel");

            migrationBuilder.DropColumn(
                name: "CountriesId",
                table: "Travel");
        }
    }
}
