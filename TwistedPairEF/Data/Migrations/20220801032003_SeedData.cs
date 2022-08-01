using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwistedPairEF.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PairsModel",
                columns: new[] { "Id", "FirstBinderColor", "FirstColor", "PairNumber", "SecondBinderColor", "SecondColor" },
                values: new object[,]
                {
                    { 3, null, "white", 3, null, "green" },
                    { 4, null, "white", 4, null, "brown" },
                    { 5, null, "white", 5, null, "slate" },
                    { 6, null, "red", 6, null, "blue" },
                    { 7, null, "red", 7, null, "orange" },
                    { 8, null, "red", 8, null, "green" },
                    { 9, null, "red", 9, null, "brown" },
                    { 10, null, "red", 10, null, "slate" },
                    { 11, null, "black", 11, null, "blue" },
                    { 12, null, "black", 12, null, "orange" },
                    { 13, null, "black", 13, null, "green" },
                    { 14, null, "black", 14, null, "brown" },
                    { 15, null, "black", 15, null, "slate" },
                    { 16, null, "yellow", 16, null, "blue" },
                    { 17, null, "yellow", 17, null, "orange" },
                    { 18, null, "yellow", 18, null, "green" },
                    { 19, null, "yellow", 19, null, "brown" },
                    { 20, null, "yellow", 20, null, "slate" },
                    { 21, null, "violet", 21, null, "blue" },
                    { 22, null, "violet", 22, null, "orange" },
                    { 23, null, "violet", 23, null, "green" },
                    { 24, null, "violet", 24, null, "brown" },
                    { 25, null, "violet", 25, null, "slate" },
                    { 26, "white", "white", 26, "blue", "blue" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PairsModel",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
