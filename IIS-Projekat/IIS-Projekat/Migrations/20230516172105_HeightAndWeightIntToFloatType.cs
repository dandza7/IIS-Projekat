using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class HeightAndWeightIntToFloatType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "MedicalRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Height",
                table: "MedicalRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2791), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2806), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2809), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2811), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2812), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2815), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2820), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2822), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2824), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2826), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2828), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2831), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2832), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2846), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2848), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2853), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2854), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2856), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2858), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2860), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5109), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5124), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5126), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5129), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5131), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5161), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5163), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5165), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5167), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5169), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5173), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5174), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5176), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5178), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5265), new DateTime(2023, 5, 16, 17, 21, 5, 354, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(521), new DateTime(2023, 5, 16, 17, 21, 5, 353, DateTimeKind.Utc).AddTicks(525), "5DD01DBC577FEBA9B41B6DE01CC40B5F7330F6E13E718A30EDD8BEE430ADF1DA492FEF02E822DB67EE1C93583101FAEB93F664A146BF0D66F43E600F6873A596", new byte[] { 129, 20, 245, 49, 211, 83, 164, 86, 149, 60, 120, 43, 93, 38, 13, 152, 136, 92, 28, 192, 97, 234, 98, 60, 164, 214, 173, 34, 147, 3, 127, 178, 160, 4, 182, 165, 26, 169, 110, 84, 133, 149, 192, 19, 212, 149, 210, 114, 189, 12, 14, 187, 214, 1, 107, 189, 94, 17, 176, 35, 182, 245, 1, 255 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "MedicalRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "MedicalRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2330), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2347), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2349), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2351), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2353), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2356), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2357), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2359), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2361), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2363), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2367), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2369), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2370), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2384), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2391), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2396), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2398), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4504), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4521), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4523), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4525), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4527), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4529), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4531), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4563), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4573), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4575), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4576), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4578), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4596), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 139, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 5, 16, 17, 18, 0, 139, DateTimeKind.Utc).AddTicks(9499), "1564AD4F127E049B65BBD0A81A792B433E1684F2FD1547864F502392F9949906C635FFCA19CA9185F23E761FB8FFE5C7AE02761ADBCEEC434C90826EB7DB5586", new byte[] { 171, 88, 229, 96, 225, 93, 97, 42, 96, 96, 68, 251, 213, 136, 155, 230, 240, 101, 28, 88, 164, 231, 123, 81, 218, 34, 63, 136, 31, 101, 172, 19, 111, 125, 1, 97, 248, 137, 34, 82, 40, 158, 136, 126, 100, 88, 168, 162, 163, 34, 43, 17, 19, 186, 50, 178, 59, 158, 202, 122, 88, 197, 137, 14 } });
        }
    }
}
