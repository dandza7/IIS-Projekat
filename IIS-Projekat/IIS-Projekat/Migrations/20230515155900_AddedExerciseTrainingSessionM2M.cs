using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedExerciseTrainingSessionM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTrainingSession_Exercises_ExercisesId",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTrainingSession_TrainingSessions_TrainingSessionsId",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseTrainingSession",
                table: "ExerciseTrainingSession");

            migrationBuilder.RenameColumn(
                name: "TrainingSessionsId",
                table: "ExerciseTrainingSession",
                newName: "TrainingSessionId");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "ExerciseTrainingSession",
                newName: "ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseTrainingSession_TrainingSessionsId",
                table: "ExerciseTrainingSession",
                newName: "IX_ExerciseTrainingSession_TrainingSessionId");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "ExerciseTrainingSession",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ExerciseTrainingSession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ExerciseTrainingSession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ExerciseTrainingSession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "RepetitionRange",
                table: "ExerciseTrainingSession",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseTrainingSession",
                table: "ExerciseTrainingSession",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(610), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(628), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(633), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(634), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(637), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(639), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(641), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(642), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(646), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(649), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(651), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(653), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(666), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(668), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(670), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(672), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(676), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(677), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(680), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(683), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5704), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5723), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5726), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5728), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5734), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5757), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5759), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5764), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5767), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5769), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5772), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5774), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 115, DateTimeKind.Utc).AddTicks(7355), new DateTime(2023, 5, 15, 15, 59, 0, 115, DateTimeKind.Utc).AddTicks(7362), "2655CD5112027B73128542E0DF43A8CBEE93538E6150306171221C0ACA7F805E8C848D4F06FD2DA2F811E135483EFC51AC6231C4C36C1E46871C7DDCE9DD940D", new byte[] { 90, 242, 57, 242, 221, 70, 55, 207, 65, 99, 51, 186, 0, 193, 107, 171, 145, 112, 94, 186, 103, 187, 34, 45, 78, 197, 29, 167, 15, 118, 52, 26, 142, 223, 38, 154, 87, 153, 182, 152, 244, 104, 128, 159, 199, 124, 201, 184, 157, 219, 53, 142, 35, 121, 22, 189, 169, 201, 55, 189, 0, 153, 130, 178 } });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTrainingSession_ExerciseId",
                table: "ExerciseTrainingSession",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTrainingSession_Exercises_ExerciseId",
                table: "ExerciseTrainingSession",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTrainingSession_TrainingSessions_TrainingSessionId",
                table: "ExerciseTrainingSession",
                column: "TrainingSessionId",
                principalTable: "TrainingSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTrainingSession_Exercises_ExerciseId",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTrainingSession_TrainingSessions_TrainingSessionId",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseTrainingSession",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseTrainingSession_ExerciseId",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ExerciseTrainingSession");

            migrationBuilder.DropColumn(
                name: "RepetitionRange",
                table: "ExerciseTrainingSession");

            migrationBuilder.RenameColumn(
                name: "TrainingSessionId",
                table: "ExerciseTrainingSession",
                newName: "TrainingSessionsId");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "ExerciseTrainingSession",
                newName: "ExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseTrainingSession_TrainingSessionId",
                table: "ExerciseTrainingSession",
                newName: "IX_ExerciseTrainingSession_TrainingSessionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseTrainingSession",
                table: "ExerciseTrainingSession",
                columns: new[] { "ExercisesId", "TrainingSessionsId" });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7722), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7768), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7772), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7777), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7781), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7783), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7786), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7790), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7792), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7795), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7798), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7802), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7811), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7814), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7816), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7820), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7822), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7824), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7827), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7830), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5213), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5248), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5329), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5334), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5338), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5342), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5344), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 5, 11, 1, 11, 29, 560, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 5, 11, 1, 11, 29, 558, DateTimeKind.Utc).AddTicks(4120), "D9EC1A845CCBFABD3047938A6053F1E3D5CB20CAC51F919FBCE13026110B7AFB76E314C8441AD1FB29B5158738CF45962A027E04EDFC82AB9C032866F2F553F4", new byte[] { 59, 196, 68, 131, 76, 208, 252, 228, 211, 252, 33, 204, 166, 83, 41, 116, 55, 65, 90, 150, 90, 111, 24, 192, 245, 46, 61, 69, 159, 18, 49, 107, 29, 217, 8, 134, 53, 208, 234, 48, 44, 247, 45, 41, 83, 255, 219, 213, 143, 66, 246, 232, 66, 128, 198, 57, 93, 161, 200, 240, 174, 241, 114, 247 } });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTrainingSession_Exercises_ExercisesId",
                table: "ExerciseTrainingSession",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTrainingSession_TrainingSessions_TrainingSessionsId",
                table: "ExerciseTrainingSession",
                column: "TrainingSessionsId",
                principalTable: "TrainingSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
