using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTherapyMuscleGroupToInjury : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InjuredMuscleTherapy");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingSessions",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "TrainingGoal",
                table: "TrainingPlans",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TrainingGoal",
                table: "TrainingPlanRequests",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReportMessage",
                table: "Therapies",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Profiles",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Anamnesis",
                table: "MedicalRecords",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RepetitionRange",
                table: "ExerciseTrainingSession",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Injury",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InjuredMuscleId = table.Column<long>(type: "bigint", nullable: false),
                    TherapyId = table.Column<long>(type: "bigint", nullable: false),
                    InjurySeverity = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injury", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injury_MuscleGroups_InjuredMuscleId",
                        column: x => x.InjuredMuscleId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Injury_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5302), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5305), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5307), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5309), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5317), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5320), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5328), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5330), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5348), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5422), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5426), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5430), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3111), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3114), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3207), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3216), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3218), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3226), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3229), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 425, DateTimeKind.Utc).AddTicks(9895), new DateTime(2023, 8, 20, 13, 49, 12, 425, DateTimeKind.Utc).AddTicks(9898), "0D433DB7A30B0F30E4E3B3F842227F560BF75E57FE39AACF3458F85CD94B86DB7023C81EE729D2AC2EC7DEAC7058C6B3AC77CF1F5C364F7BF07807AC153E3893", new byte[] { 173, 3, 255, 226, 116, 113, 18, 141, 175, 19, 228, 168, 231, 228, 88, 220, 205, 228, 130, 158, 46, 252, 232, 115, 144, 60, 60, 190, 132, 200, 141, 129, 79, 77, 127, 21, 89, 211, 89, 103, 158, 103, 185, 242, 4, 180, 141, 117, 172, 184, 210, 223, 84, 20, 124, 71, 160, 205, 246, 157, 101, 196, 161, 20 } });

            migrationBuilder.CreateIndex(
                name: "IX_Injury_InjuredMuscleId",
                table: "Injury",
                column: "InjuredMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_Injury_TherapyId",
                table: "Injury",
                column: "TherapyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Injury");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingSessions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "TrainingGoal",
                table: "TrainingPlans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "TrainingGoal",
                table: "TrainingPlanRequests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "ReportMessage",
                table: "Therapies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "Profiles",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Anamnesis",
                table: "MedicalRecords",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RepetitionRange",
                table: "ExerciseTrainingSession",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(64)",
                oldMaxLength: 64);

            migrationBuilder.CreateTable(
                name: "InjuredMuscleTherapy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuredMuscleId = table.Column<long>(type: "bigint", nullable: false),
                    TherapyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InjurySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuredMuscleTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjuredMuscleTherapy_MuscleGroups_InjuredMuscleId",
                        column: x => x.InjuredMuscleId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuredMuscleTherapy_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_InjuredMuscleTherapy_InjuredMuscleId",
                table: "InjuredMuscleTherapy",
                column: "InjuredMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuredMuscleTherapy_TherapyId",
                table: "InjuredMuscleTherapy",
                column: "TherapyId");
        }
    }
}
