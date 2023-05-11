using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedUnitFromNutrientShare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "NutrientShares");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7722), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7768), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7772), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7777), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7781), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7783), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7786), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7790), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7792), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7795), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7798), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7802), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7811), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7814), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7816), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7820), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7822), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7824), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7827), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7830), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5213), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5248), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5329), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5334), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5338), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5342), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5344), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(4120), "D9EC1A845CCBFABD3047938A6053F1E3D5CB20CAC51F919FBCE13026110B7AFB76E314C8441AD1FB29B5158738CF45962A027E04EDFC82AB9C032866F2F553F4", new byte[] { 59, 196, 68, 131, 76, 208, 252, 228, 211, 252, 33, 204, 166, 83, 41, 116, 55, 65, 90, 150, 90, 111, 24, 192, 245, 46, 61, 69, 159, 18, 49, 107, 29, 217, 8, 134, 53, 208, 234, 48, 44, 247, 45, 41, 83, 255, 219, 213, 143, 66, 246, 232, 66, 128, 198, 57, 93, 161, 200, 240, 174, 241, 114, 247 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "NutrientShares",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4969), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4991), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4994), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4996), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4999), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5002), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5005), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5007), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5009), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5012), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5014), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5016), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5018), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5020), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5043), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5043) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5045), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5047), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5126), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5128), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7742), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7744), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7746), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7748), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7750), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7752), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7773), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7777), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7778), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7783), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7786), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7873), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7877), new DateTime(2023, 5, 10, 21, 57, 42, 805, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(932), new DateTime(2023, 5, 10, 21, 57, 42, 804, DateTimeKind.Utc).AddTicks(934), "75379309C6F7EFC9E7EA3DC04E4B099BA5D674EFE1D629872659DA67BA4035D263278BF86B9937F7284B6B2B39F77FD1A85E15EC172B016D26E1E7C6310A7EED", new byte[] { 170, 68, 212, 22, 238, 125, 124, 106, 89, 200, 94, 130, 141, 41, 144, 165, 226, 178, 162, 92, 98, 199, 34, 255, 10, 203, 215, 228, 38, 215, 149, 133, 201, 219, 118, 73, 238, 17, 79, 156, 79, 222, 230, 38, 188, 138, 44, 238, 61, 22, 11, 226, 79, 4, 156, 19, 29, 72, 160, 244, 44, 135, 17, 128 } });
        }
    }
}
