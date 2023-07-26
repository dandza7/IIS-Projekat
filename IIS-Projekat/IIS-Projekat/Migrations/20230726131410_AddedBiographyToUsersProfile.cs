using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedBiographyToUsersProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Profiles",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1746), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1790), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1808), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1881), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1902), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1921), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4042), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4047), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4057), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4061), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4071), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4075), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4134), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4142), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4145), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4148), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4151), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4156), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4159), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4167), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 254, DateTimeKind.Utc).AddTicks(1414), new DateTime(2023, 7, 26, 13, 14, 9, 254, DateTimeKind.Utc).AddTicks(1423), "6841317B493896D2BA57D0FD34D18E918DFCEA2ACAEB526FD87F835CBB33A71D38E88BDE1CABBC8C0A79FD8828A9BC352190E2DF0EA5376488D7467CA2243C09", new byte[] { 159, 117, 121, 250, 1, 208, 249, 179, 38, 36, 154, 175, 62, 30, 121, 125, 88, 143, 202, 253, 197, 242, 33, 254, 233, 100, 21, 156, 229, 236, 20, 195, 219, 200, 1, 103, 177, 133, 253, 244, 96, 27, 125, 140, 217, 136, 176, 194, 134, 87, 68, 37, 100, 71, 172, 221, 106, 222, 71, 116, 87, 160, 96, 10 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Profiles");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6392), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6419), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6422), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6426), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6428), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6433), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6435), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6438), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6444), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6446), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6449), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6452), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6455), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6461), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6464), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6466), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6470), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6473), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6475), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6477), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5403), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5406), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5408), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(194), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(197), "926373BE1A9080ED8B637475F57501EB9D298EC98ED1803BD1650FB590B6A7389DD5D54E78FF9219620D0706F231C50E1EBF7E9591F9F1508039028D0A8D4F3F", new byte[] { 138, 32, 107, 166, 37, 189, 9, 198, 114, 173, 5, 39, 198, 100, 217, 149, 159, 16, 210, 205, 1, 35, 152, 111, 230, 119, 133, 146, 255, 125, 24, 91, 133, 147, 113, 59, 103, 160, 109, 194, 104, 48, 163, 112, 251, 85, 225, 177, 48, 181, 177, 25, 228, 111, 180, 195, 119, 180, 2, 72, 115, 234, 96, 51 } });
        }
    }
}
