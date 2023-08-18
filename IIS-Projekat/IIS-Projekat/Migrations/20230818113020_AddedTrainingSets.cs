using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrainingSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingSets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    TrainingSessionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSets_TrainingSessions_TrainingSessionId",
                        column: x => x.TrainingSessionId,
                        principalTable: "TrainingSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSets_TrainingSessionId",
                table: "TrainingSets",
                column: "TrainingSessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingSets");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3648), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3652), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3654), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3658), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3661), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3665), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3670), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3672), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3675), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3680), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3690), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3696), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3699), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3702), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3704), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3707), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3709), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7026), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7047), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7050), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7053), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7055), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7059), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7062), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7109), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7115), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7118), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7123), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7126), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7131), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7134), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 280, DateTimeKind.Utc).AddTicks(5722), new DateTime(2023, 8, 16, 14, 20, 41, 280, DateTimeKind.Utc).AddTicks(5726), "51529E7E5CDE2AEE103BE296600E11E8EC04AC424BC89FC95C31795B090D09B44FDECDC4FDBD829335A129DE83ABBDE64E9E013D07DC6400399493B15B068CB5", new byte[] { 141, 126, 139, 37, 43, 40, 93, 147, 229, 255, 211, 94, 212, 41, 91, 0, 205, 151, 170, 51, 147, 99, 247, 208, 19, 148, 69, 0, 147, 185, 70, 63, 156, 109, 14, 245, 202, 188, 239, 198, 248, 212, 192, 102, 177, 122, 42, 174, 204, 85, 250, 14, 133, 141, 2, 241, 179, 117, 18, 142, 231, 107, 246, 44 } });
        }
    }
}
