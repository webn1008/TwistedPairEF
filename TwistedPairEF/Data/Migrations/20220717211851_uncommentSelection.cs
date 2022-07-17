using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwistedPairEF.Data.Migrations
{
    public partial class uncommentSelection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstBinderColor",
                table: "PairsModel",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstPair",
                table: "PairsModel",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBinderColor",
                table: "PairsModel",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondPair",
                table: "PairsModel",
                type: "nvarchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstBinderColor",
                table: "PairsModel");

            migrationBuilder.DropColumn(
                name: "FirstPair",
                table: "PairsModel");

            migrationBuilder.DropColumn(
                name: "SecondBinderColor",
                table: "PairsModel");

            migrationBuilder.DropColumn(
                name: "SecondPair",
                table: "PairsModel");
        }
    }
}
