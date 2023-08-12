using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedNameFieldToSupplement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Supplement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5333), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5346), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5358), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5361), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5378), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5384), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5390), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3218), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3245), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3249), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3251), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3258), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3296), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3299), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3305), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3308), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3312), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3320), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3325), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 307, DateTimeKind.Utc).AddTicks(9082), new DateTime(2023, 8, 12, 9, 19, 56, 307, DateTimeKind.Utc).AddTicks(9085), "8A6A391FDABA1EB081D3995CFD2A3C68F8D2EF7E3226031B381015A77948587377E45EE896C842042B01C12973FFBFD209103007DAFC1A0E1739810BD256FABE", new byte[] { 228, 93, 101, 136, 15, 61, 31, 102, 199, 17, 151, 123, 141, 90, 57, 235, 165, 51, 244, 215, 234, 232, 71, 217, 159, 79, 75, 73, 35, 90, 61, 136, 108, 103, 44, 203, 112, 81, 100, 77, 210, 233, 236, 63, 69, 211, 159, 150, 175, 48, 146, 85, 251, 115, 70, 77, 134, 226, 142, 197, 244, 126, 202, 30 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Supplement");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4676), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4698), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4701), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4707), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4711), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4713), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4716), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4718), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4724), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4727), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4730), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4748), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4751), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4753), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4757), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4759), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4762), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4765), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4768), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(683), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(700), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(703), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(706), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(751), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(765), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(772), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 55, DateTimeKind.Utc).AddTicks(9698), new DateTime(2023, 8, 12, 8, 11, 22, 55, DateTimeKind.Utc).AddTicks(9701), "B1241B44E004D06C3BC4E65C9B1318FA39FC27BFCA49D5EF6311E1F5D011B7215BB9D1128BCDE513F803BF51A7F1AF6343F3433450F021992AD9BC10073942AB", new byte[] { 205, 41, 165, 110, 64, 68, 113, 178, 140, 203, 96, 202, 39, 5, 55, 28, 129, 184, 6, 7, 90, 39, 201, 10, 137, 18, 242, 9, 29, 234, 89, 232, 138, 22, 92, 185, 21, 148, 179, 247, 89, 118, 55, 59, 98, 10, 139, 168, 141, 245, 131, 83, 113, 197, 199, 188, 35, 211, 72, 29, 84, 25, 202, 108 } });
        }
    }
}
