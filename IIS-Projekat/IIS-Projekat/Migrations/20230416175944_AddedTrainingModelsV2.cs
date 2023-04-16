using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrainingModelsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_MuscleGroups_PrimaryTargetMuscleId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_PrimaryTargetMuscleId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "PrimaryTargetMuscleId",
                table: "Exercises");

            migrationBuilder.CreateTable(
                name: "ExerciseMuscleGroup",
                columns: table => new
                {
                    SecondaryExercisesId = table.Column<long>(type: "bigint", nullable: false),
                    SecondaryTargetMusclesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscleGroup", x => new { x.SecondaryExercisesId, x.SecondaryTargetMusclesId });
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroup_Exercises_SecondaryExercisesId",
                        column: x => x.SecondaryExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroup_MuscleGroups_SecondaryTargetMusclesId",
                        column: x => x.SecondaryTargetMusclesId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6407), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6506), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6516), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6533), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6537), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6541), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6550), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6554), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6557), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6561), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6564), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6568), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6639), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6653), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6660), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6667), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6676), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6685), new DateTime(2023, 4, 16, 17, 59, 43, 725, DateTimeKind.Utc).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 59, 43, 723, DateTimeKind.Utc).AddTicks(5055), new DateTime(2023, 4, 16, 17, 59, 43, 723, DateTimeKind.Utc).AddTicks(5074), "9407788BAF63F3A2809CDD526E09B09A5EF2F5DC25A77595A926C00B5411FE4F6F47EE9FA308C959504189C352E18FA77B2038876ED6665D9214AF32CBF5B16F", new byte[] { 91, 85, 149, 236, 242, 95, 234, 140, 200, 247, 9, 121, 244, 92, 175, 35, 166, 76, 228, 109, 128, 6, 124, 51, 18, 237, 91, 11, 2, 4, 239, 93, 100, 17, 158, 34, 34, 84, 232, 16, 150, 210, 198, 249, 28, 201, 224, 2, 229, 130, 103, 85, 36, 159, 132, 239, 195, 117, 73, 88, 130, 205, 157, 241 } });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroup_SecondaryTargetMusclesId",
                table: "ExerciseMuscleGroup",
                column: "SecondaryTargetMusclesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseMuscleGroup");

            migrationBuilder.AddColumn<long>(
                name: "PrimaryTargetMuscleId",
                table: "Exercises",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1404), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1421), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1425), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1428), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1431), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1436), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1439), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1446), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1453), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1456), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1458), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1461), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1470), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1473), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1476), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1480), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1483), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1488), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1491), new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 16, 17, 9, 49, 592, DateTimeKind.Utc).AddTicks(9264), new DateTime(2023, 4, 16, 17, 9, 49, 592, DateTimeKind.Utc).AddTicks(9268), "D79FEF82F15BFBAE0AC0C0E8E1A401B2B0E283A1E37C9ECE186A2C416226D8C48DFF02C739CF29CACACD130B9F4B75EBB676B36AE5CCAC488E90287EB9BE81AC", new byte[] { 223, 128, 96, 122, 230, 107, 0, 213, 146, 74, 183, 193, 101, 106, 250, 246, 167, 62, 68, 226, 252, 221, 0, 207, 95, 94, 60, 221, 153, 244, 254, 222, 211, 166, 116, 190, 85, 54, 250, 99, 23, 70, 100, 53, 183, 107, 169, 12, 5, 193, 11, 13, 97, 117, 158, 189, 116, 191, 240, 214, 199, 86, 151, 40 } });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_PrimaryTargetMuscleId",
                table: "Exercises",
                column: "PrimaryTargetMuscleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_MuscleGroups_PrimaryTargetMuscleId",
                table: "Exercises",
                column: "PrimaryTargetMuscleId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
