using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2024, 10, 5, 7, 46, 35, 758, DateTimeKind.Local).AddTicks(5907), "Went Hiking" },
                    { 2, "Went Shoping with Joe!", new DateTime(2024, 10, 5, 7, 46, 35, 758, DateTimeKind.Local).AddTicks(6179), "Went Shoping" },
                    { 3, "Went diving with Joe!", new DateTime(2024, 10, 5, 7, 46, 35, 758, DateTimeKind.Local).AddTicks(6182), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
