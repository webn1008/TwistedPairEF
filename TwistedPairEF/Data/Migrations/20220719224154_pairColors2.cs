using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwistedPairEF.Data.Migrations
{
    public partial class pairColors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PairsModel",
                columns: new[] { "Id", "FirstBinderColor", "FirstColor", "PairNumber", "SecondBinderColor", "SecondColor" },
                values: new object[] { 1, null, "White", 1, null, "Blue" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
