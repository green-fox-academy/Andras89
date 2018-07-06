using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reddit.Migrations
{
    public partial class PostDateTimeMod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
