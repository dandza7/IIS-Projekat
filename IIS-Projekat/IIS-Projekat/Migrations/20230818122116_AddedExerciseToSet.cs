using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedExerciseToSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ExerciseId",
                table: "TrainingSets",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1562), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1581), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1678), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1681), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1710), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1713), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1716), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1721), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1724), new DateTime(2023, 8, 18, 12, 21, 16, 11, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8213), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8216), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8289), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8292), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8339), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8341), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8344), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8346), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8353), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 8, 18, 12, 21, 16, 12, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 18, 12, 21, 16, 10, DateTimeKind.Utc).AddTicks(7594), new DateTime(2023, 8, 18, 12, 21, 16, 10, DateTimeKind.Utc).AddTicks(7598), "863B7B32659C92D950B5B9EAD7AE39518E0F5F4AED0F2E3C8368966A271787C38AB5F1A5942D1539B94900DBC36DA522FF5EBBB475D30B89FD10643C7754EFD1", new byte[] { 139, 194, 158, 199, 250, 171, 134, 22, 28, 82, 166, 147, 85, 50, 49, 254, 175, 232, 242, 194, 165, 24, 188, 16, 65, 75, 144, 27, 216, 170, 125, 163, 65, 99, 217, 85, 26, 73, 119, 247, 107, 151, 101, 115, 10, 129, 64, 7, 2, 244, 218, 249, 49, 4, 138, 35, 126, 23, 56, 98, 14, 214, 145, 20 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSets_ExerciseId",
                table: "TrainingSets",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingSets_Exercises_ExerciseId",
                table: "TrainingSets",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingSets_Exercises_ExerciseId",
                table: "TrainingSets");

            migrationBuilder.DropIndex(
                name: "IX_TrainingSets_ExerciseId",
                table: "TrainingSets");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "TrainingSets");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1339), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1342), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1352), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1366), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1369), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1406), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1411), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1414), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1419), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1423), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1426), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1429), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1432), new DateTime(2023, 8, 18, 11, 30, 19, 328, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6622), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6625), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6634), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6663), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6666), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6672), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6675), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6679), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6753), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6756), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6762), new DateTime(2023, 8, 18, 11, 30, 19, 330, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 18, 11, 30, 19, 326, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 8, 18, 11, 30, 19, 326, DateTimeKind.Utc).AddTicks(8347), "F7BC921770763ED42955D1C8DA77F51EFEC67E9181CEECFA66416F2A8A6BE3115A601511ADBA01263AB7DD0AC8EA031D8E328EE56C2B91BCB18FCAB8E476C083", new byte[] { 42, 230, 62, 252, 46, 240, 77, 220, 203, 6, 39, 77, 117, 116, 206, 100, 94, 75, 45, 12, 20, 59, 215, 181, 12, 215, 223, 121, 176, 112, 196, 66, 123, 156, 235, 46, 87, 28, 101, 101, 138, 49, 65, 195, 46, 117, 147, 171, 197, 46, 28, 143, 35, 43, 247, 202, 157, 37, 29, 78, 127, 110, 228, 190 } });
        }
    }
}
