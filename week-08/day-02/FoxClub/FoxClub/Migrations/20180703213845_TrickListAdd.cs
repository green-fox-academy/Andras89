using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxClub.Migrations
{
    public partial class TrickListAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrickList",
                table: "Foxes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrickList",
                table: "Foxes");
        }
    }
}
