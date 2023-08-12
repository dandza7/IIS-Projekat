using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailValidationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailValidations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailValidations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailValidations_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_EmailValidations_UserId",
                table: "EmailValidations",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailValidations");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3049), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3078), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3081), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3089), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3092), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3095), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3098), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3104), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3112), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3121), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3124), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3127), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2244), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2248), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2252), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2255), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2259), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2261), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2263), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2344), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 737, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 8, 12, 17, 17, 14, 737, DateTimeKind.Utc).AddTicks(6563), "E8CF76B1FDB8DC08A57A06CCCAA4333D7507EC5D2E465B28FD34C5CCBE87D667D174B2F38FA13B623EADC0A5D6F29123881D0B7ABB435A19995E194FCA55C067", new byte[] { 60, 223, 115, 152, 251, 217, 251, 86, 183, 149, 230, 247, 188, 51, 154, 238, 232, 7, 85, 6, 87, 59, 40, 211, 80, 85, 205, 191, 123, 23, 181, 252, 77, 173, 178, 53, 11, 15, 222, 196, 172, 250, 87, 163, 47, 129, 170, 198, 33, 38, 208, 6, 212, 71, 52, 72, 49, 233, 200, 61, 163, 63, 241, 172 } });
        }
    }
}
