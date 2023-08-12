using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedCodeToEmailValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Code",
                table: "EmailValidations",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7203), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7227), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7231), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7239), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7262), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7399), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7405), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7409), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5113), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5147), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5151), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5154), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5158), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5163), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5166), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5204), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5208), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5304), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5324), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5328), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 612, DateTimeKind.Utc).AddTicks(7481), new DateTime(2023, 8, 12, 22, 38, 50, 612, DateTimeKind.Utc).AddTicks(7487), "C0275A319D1FD45F9A0975C1D8941A0ECB9301AC1E071E67849DADD641399382BD88156EEB86E522E0DF60D9AF2223CF2883668A9C46F9E9D697AF44F247A4FC", new byte[] { 22, 185, 53, 197, 177, 48, 227, 139, 25, 21, 92, 101, 33, 156, 85, 247, 205, 73, 78, 236, 123, 35, 111, 211, 36, 232, 156, 117, 206, 51, 184, 200, 149, 206, 52, 99, 47, 72, 246, 171, 51, 232, 123, 60, 161, 36, 166, 3, 221, 26, 36, 254, 203, 255, 41, 77, 237, 201, 105, 134, 9, 153, 95, 5 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "EmailValidations");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1237), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1357), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1365), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1367), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1371), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1377), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1389), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1391), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1393), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1397), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1399), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1401), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1403), new DateTime(2023, 8, 12, 21, 47, 52, 806, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6217), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6233), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6235), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6237), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6239), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6243), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6246), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6270), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6272), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6275), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6276), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6278), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6280), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6282), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6284), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6285), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6287), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6290), new DateTime(2023, 8, 12, 21, 47, 52, 807, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 21, 47, 52, 805, DateTimeKind.Utc).AddTicks(4933), new DateTime(2023, 8, 12, 21, 47, 52, 805, DateTimeKind.Utc).AddTicks(4935), "D6F8230BD9837B826E0BB5D09D747363E70CEE271777CFDF56429D86CB0313F943F91BB9B91B4637B88DFD036FDE628F910800FCFC1C7E22A4C9B292AF43A213", new byte[] { 154, 99, 240, 37, 81, 99, 9, 22, 115, 89, 239, 110, 158, 20, 37, 137, 250, 231, 45, 225, 129, 195, 137, 164, 152, 169, 220, 130, 37, 178, 244, 136, 125, 220, 92, 97, 182, 137, 32, 197, 89, 3, 106, 180, 78, 113, 204, 101, 238, 253, 82, 122, 170, 61, 102, 106, 110, 204, 190, 222, 171, 18, 150, 81 } });
        }
    }
}
