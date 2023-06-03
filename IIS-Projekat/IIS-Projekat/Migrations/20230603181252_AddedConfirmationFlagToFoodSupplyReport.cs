using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedConfirmationFlagToFoodSupplyReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "FoodSupplyReports",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7121), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7147), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7154), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7161), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7167), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7178), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7181), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7195), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7232), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7236), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7364), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7377), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7380), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5388), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5402), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5404), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5445), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5452), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5455), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5461), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5468), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5471), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5478), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(3680), "C8CB00A8BB7613D31BBA5D154D8302A951F8581A7FA34EF81A6E182AF4AA31429A126C6D70A0D0EECB83884DA1FA1BF1E29750A05670A9917E95E4E31EB7A194", new byte[] { 211, 243, 162, 248, 220, 211, 62, 5, 75, 196, 201, 145, 169, 176, 17, 191, 106, 125, 119, 138, 248, 180, 32, 192, 147, 131, 199, 111, 176, 30, 178, 160, 149, 158, 84, 207, 8, 250, 227, 65, 7, 52, 19, 100, 203, 142, 179, 44, 226, 171, 192, 244, 218, 190, 78, 66, 235, 121, 52, 35, 176, 110, 141, 233 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "FoodSupplyReports");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2111), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3091), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3118), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3122), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3126), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3134), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3169), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3176), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3199), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3202), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3205), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 810, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 5, 31, 8, 16, 30, 810, DateTimeKind.Utc).AddTicks(7925), "21D2081E2B79FE9B9C9FC99FDA5EA69E59DB97FF2928C91D8955F5B530D1B2D61612A82E0946656A16DBB91D9FCE5028A686A6482315911C8F67C759F36EF756", new byte[] { 200, 54, 25, 117, 172, 74, 186, 100, 95, 181, 63, 134, 228, 198, 2, 127, 226, 154, 223, 115, 24, 252, 72, 241, 169, 234, 255, 148, 192, 191, 61, 139, 100, 103, 211, 160, 221, 167, 79, 71, 34, 59, 31, 34, 55, 179, 60, 88, 195, 40, 71, 38, 201, 206, 39, 55, 177, 61, 9, 130, 195, 251, 43, 75 } });
        }
    }
}
