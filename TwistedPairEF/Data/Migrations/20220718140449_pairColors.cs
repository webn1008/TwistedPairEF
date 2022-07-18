using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwistedPairEF.Data.Migrations
{
    public partial class pairColors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecondPair",
                table: "PairsModel",
                newName: "SecondColor");

            migrationBuilder.RenameColumn(
                name: "FirstPair",
                table: "PairsModel",
                newName: "FirstColor");

            migrationBuilder.AddColumn<int>(
                name: "PairNumber",
                table: "PairsModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PairNumber",
                table: "PairsModel");

            migrationBuilder.RenameColumn(
                name: "SecondColor",
                table: "PairsModel",
                newName: "SecondPair");

            migrationBuilder.RenameColumn(
                name: "FirstColor",
                table: "PairsModel",
                newName: "FirstPair");
        }
    }
}
