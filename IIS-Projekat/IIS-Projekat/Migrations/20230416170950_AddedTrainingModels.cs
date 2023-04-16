using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrainingModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlanRequests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SessionsPerWeek = table.Column<int>(type: "int", nullable: false),
                    TrainingGoal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlanRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingPlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    TrainingGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionsPerWeek = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryTargetMuscleId = table.Column<long>(type: "bigint", nullable: false),
                    Repetitions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_MuscleGroups_PrimaryTargetMuscleId",
                        column: x => x.PrimaryTargetMuscleId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingSessions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfExercises = table.Column<int>(type: "int", nullable: false),
                    TrainingPlanId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingSessions_TrainingPlans_TrainingPlanId",
                        column: x => x.TrainingPlanId,
                        principalTable: "TrainingPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTrainingSession",
                columns: table => new
                {
                    ExercisesId = table.Column<long>(type: "bigint", nullable: false),
                    TrainingSessionsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTrainingSession", x => new { x.ExercisesId, x.TrainingSessionsId });
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingSession_Exercises_ExercisesId",
                        column: x => x.ExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTrainingSession_TrainingSessions_TrainingSessionsId",
                        column: x => x.TrainingSessionsId,
                        principalTable: "TrainingSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MuscleGroups",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1404), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1405), "Calves" },
                    { 2L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1421), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1421), "Quads" },
                    { 3L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1425), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1425), "Hamstrings" },
                    { 4L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1428), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1429), "Abductors" },
                    { 5L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1431), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1432), "Adductors" },
                    { 6L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1436), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1437), "Gluteus" },
                    { 7L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1439), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1440), "Core" },
                    { 8L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1442), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1443), "Abs" },
                    { 9L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1446), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1446), "Lower Back" },
                    { 10L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1450), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1451), "Lats" },
                    { 11L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1453), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1453), "Teres Major" },
                    { 12L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1456), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1456), "Lower Traps" },
                    { 13L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1458), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1459), "Traps" },
                    { 14L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1461), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1462), "Rear Delts" },
                    { 15L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1470), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1470), "Side Delts" },
                    { 16L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1473), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1473), "Front Delts" },
                    { 17L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1476), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1476), "Upper Chest" },
                    { 18L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1480), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1481), "Lower Chest" },
                    { 19L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1483), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1483), "Biceps" },
                    { 20L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1486), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1486), "Triceps" },
                    { 21L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1488), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1489), "Brachialis" },
                    { 22L, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1491), false, new DateTime(2023, 4, 16, 17, 9, 49, 593, DateTimeKind.Utc).AddTicks(1492), "Forearms" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainingSession_TrainingSessionsId",
                table: "ExerciseTrainingSession",
                column: "TrainingSessionsId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingSessions_TrainingPlanId",
                table: "TrainingSessions",
                column: "TrainingPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseTrainingSession");

            migrationBuilder.DropTable(
                name: "TrainingPlanRequests");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "TrainingSessions");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "TrainingPlans");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 57, 59, 372, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 4, 11, 0, 57, 59, 372, DateTimeKind.Utc).AddTicks(7421), "F31914BC3D9B75C5FABF42AC716DD051C8630047CBCE7A3BEBEE5251974A23E4EC40B47B586ED8567813FA9425396616EE0AAEC385AD63E9BD8519F17DD37AFD", new byte[] { 66, 182, 84, 204, 98, 201, 18, 107, 142, 194, 155, 51, 243, 51, 87, 205, 36, 215, 156, 36, 203, 127, 146, 113, 154, 63, 83, 42, 125, 228, 21, 58, 187, 10, 211, 182, 55, 182, 14, 39, 202, 191, 162, 239, 102, 30, 7, 22, 70, 147, 217, 254, 183, 211, 41, 161, 224, 18, 152, 22, 60, 29, 201, 42 } });
        }
    }
}
