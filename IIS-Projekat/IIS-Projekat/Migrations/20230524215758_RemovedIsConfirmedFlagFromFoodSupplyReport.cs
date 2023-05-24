using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedIsConfirmedFlagFromFoodSupplyReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "FoodSupplyReports");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3225), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3227), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3230), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3231), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3233), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3234), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3236), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3238), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3239), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3241), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3242), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3248), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3251), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3255), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3258), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8217), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8224), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8232), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9009), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9015), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9027), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9032), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9035), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9037), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9039), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9041), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9043), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9045), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(594), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(597), "7EC7F49F580E02ECA097C2F6E26C84D788911717C9592D8194AC3E6E58295A9059B7D79298897DD3B4EC6CB81888B59DE2AEF8813427B1D9B7F7EF5D2BADCAB5", new byte[] { 241, 229, 249, 92, 52, 46, 19, 241, 204, 188, 136, 187, 240, 159, 243, 129, 190, 156, 25, 65, 92, 153, 222, 212, 142, 101, 240, 171, 214, 223, 96, 221, 192, 169, 195, 33, 104, 136, 119, 151, 88, 224, 190, 30, 108, 59, 181, 23, 35, 18, 61, 108, 143, 187, 182, 57, 35, 201, 59, 136, 96, 212, 94, 207 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9251), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9278), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9281), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9283), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9287), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9292), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9297), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9301), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9303), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9305), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9307), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9443), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9455), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9457), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6709), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6712), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6715), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6718), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6722), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6725), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(5595), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(5598), "AE3821D662D044C8D6AE3098F9EBA0B20087DF866E096B7F689D11EB91CC8E46D568781C464A794F66864E55CC766108D28F63C633FDD5DC3F13BE650C6A1B85", new byte[] { 169, 33, 210, 245, 176, 187, 26, 240, 79, 53, 136, 204, 248, 106, 192, 23, 100, 193, 201, 135, 244, 79, 52, 79, 63, 115, 47, 199, 20, 67, 88, 16, 218, 224, 58, 208, 43, 227, 110, 199, 213, 214, 214, 231, 82, 137, 156, 255, 75, 169, 10, 179, 142, 92, 112, 222, 179, 179, 118, 124, 223, 73, 153, 191 } });
        }
    }
}
