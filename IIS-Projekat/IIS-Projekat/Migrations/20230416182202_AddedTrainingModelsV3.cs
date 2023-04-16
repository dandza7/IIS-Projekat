using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrainingModelsV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseMuscleGroup");

            migrationBuilder.CreateTable(
                name: "ExerciseMuscleGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ExerciseId = table.Column<long>(type: "bigint", nullable: false),
                    MuscleGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IsPrimaryMuscleGroup = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscleGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroups_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroups_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2790), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2796), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2800), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2804), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2811), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2814), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2821), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2826), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2834), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3183), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3191), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3197), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3205), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 955, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 4, 16, 18, 22, 1, 955, DateTimeKind.Utc).AddTicks(5679), "6BA2AEDF260918EBF87167EFF1F518DA08BE2AC944B73FC6E7DAB1C8F48CB8C85411961BC09E94B47744A3BFDDDD77AA05BC3D13A059F84F6F1391FA24EC1DF4", new byte[] { 175, 137, 204, 133, 9, 50, 72, 41, 61, 220, 6, 95, 49, 204, 113, 206, 232, 15, 130, 191, 13, 28, 75, 61, 16, 201, 70, 208, 218, 157, 68, 183, 196, 182, 206, 208, 227, 235, 2, 229, 190, 250, 115, 3, 141, 165, 15, 142, 200, 88, 113, 192, 30, 92, 95, 89, 239, 236, 37, 70, 56, 22, 190, 91 } });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroups_ExerciseId",
                table: "ExerciseMuscleGroups",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroups_MuscleGroupId",
                table: "ExerciseMuscleGroups",
                column: "MuscleGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseMuscleGroups");

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
    }
}
