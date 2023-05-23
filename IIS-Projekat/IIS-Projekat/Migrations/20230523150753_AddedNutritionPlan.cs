using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedNutritionPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionPlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionPlans_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(30), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(45), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(59), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(61), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(62), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(176), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(178), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(180), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(182), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(184), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1751), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1817), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1822), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1870), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1896), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1899), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 933, DateTimeKind.Utc).AddTicks(5162), new DateTime(2023, 5, 23, 15, 7, 52, 933, DateTimeKind.Utc).AddTicks(5164), "53ECE7C7CC33BB168A542FCEEF7BDB862FDB0EC542E9FB07ED91AD81348B9A20083B3E7EDBD772144E89BC53C0297A199BA58EFA96197CC35034845D377BDEA4", new byte[] { 197, 254, 75, 109, 191, 30, 27, 246, 145, 201, 37, 97, 254, 157, 180, 8, 103, 19, 217, 28, 231, 23, 214, 179, 230, 144, 67, 237, 204, 215, 1, 1, 154, 173, 207, 212, 35, 24, 0, 174, 243, 241, 102, 104, 11, 223, 250, 241, 64, 72, 29, 128, 36, 238, 183, 0, 51, 41, 222, 169, 165, 97, 107, 51 } });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlans_UserId",
                table: "NutritionPlans",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionPlans");

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
    }
}
