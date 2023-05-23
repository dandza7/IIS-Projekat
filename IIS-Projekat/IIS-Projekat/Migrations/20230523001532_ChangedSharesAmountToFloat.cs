using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSharesAmountToFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Share",
                table: "NutrientShares",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Share",
                table: "FoodShares",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Calories",
                table: "Food",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3829), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3853) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3857), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3868), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3875), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3881), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3889), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3892), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3895), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3897), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3902), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3918), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3926), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3932), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3941), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3944), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3946), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3949), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3952), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9296), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9299), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9302), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9304), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9307), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9309), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9335), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9337), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9343), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9345), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9347), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9349), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9351), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9354), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9356), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9358), new DateTime(2023, 5, 23, 0, 15, 31, 922, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 5, 23, 0, 15, 31, 921, DateTimeKind.Utc).AddTicks(970), "4007D1DD50314F60996AE4BBAD1334E2EDE97233D086261676714A9903271CC899052E0E3FBE7759D21FF6AC971FCC397BB27CF2CE2B135EDE24AE84BC314FBF", new byte[] { 96, 46, 68, 157, 160, 113, 132, 90, 222, 96, 175, 23, 137, 79, 28, 127, 73, 1, 4, 32, 108, 227, 240, 214, 58, 31, 17, 241, 109, 91, 28, 154, 134, 135, 124, 40, 51, 107, 208, 212, 205, 46, 105, 26, 163, 138, 147, 185, 240, 245, 112, 167, 110, 162, 185, 175, 101, 172, 73, 99, 173, 37, 26, 27 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Share",
                table: "NutrientShares",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Share",
                table: "FoodShares",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "Food",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
    }
}
