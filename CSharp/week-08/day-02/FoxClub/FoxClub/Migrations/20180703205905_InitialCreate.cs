using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoxClub.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foxes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Drink = table.Column<string>(nullable: true),
                    Food = table.Column<string>(nullable: true),
                    Picture = table.Column<string>(nullable: true),
                    FoodAmount = table.Column<int>(nullable: false),
                    DrinkAmount = table.Column<int>(nullable: false),
                    LastFeed = table.Column<DateTime>(nullable: false),
                    LastDrink = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foxes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foxes");
        }
    }
}
