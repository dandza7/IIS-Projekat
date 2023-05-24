using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class InjuryTherapyM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTherapy_Therapies_TherapiesId",
                table: "ExerciseTherapy");

            migrationBuilder.RenameColumn(
                name: "TherapiesId",
                table: "ExerciseTherapy",
                newName: "TherapyId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseTherapy_TherapiesId",
                table: "ExerciseTherapy",
                newName: "IX_ExerciseTherapy_TherapyId");

            migrationBuilder.CreateTable(
                name: "InjuryTherapy",
                columns: table => new
                {
                    DiagnosedInjuriesId = table.Column<long>(type: "bigint", nullable: false),
                    TherapyId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryTherapy", x => new { x.DiagnosedInjuriesId, x.TherapyId });
                    table.ForeignKey(
                        name: "FK_InjuryTherapy_Injuries_DiagnosedInjuriesId",
                        column: x => x.DiagnosedInjuriesId,
                        principalTable: "Injuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryTherapy_Therapies_TherapyId",
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
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4493), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4547), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4550), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4552), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4554), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4556), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4558), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4560), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4562), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4564), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4566), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4569), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4584), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4587), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4589), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4591), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4593), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4595), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4598), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7262), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7278), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7283), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7284), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7287), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7318), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7321), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7323), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7325), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7327), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7329), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7331), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7332), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7335), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7336), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7339), new DateTime(2023, 5, 24, 9, 57, 42, 35, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(2318), new DateTime(2023, 5, 24, 9, 57, 42, 34, DateTimeKind.Utc).AddTicks(2320), "A6DD95FB4EAE88373A4ED3AF1FD15320BBFB73BC50101FAE1376F35BAFE2944A3197EF3E94009596C06B635D8EEAFCAD379ED7253816D15831DD7002972DBE2E", new byte[] { 164, 191, 183, 83, 97, 247, 88, 92, 61, 206, 121, 182, 238, 27, 176, 99, 53, 172, 204, 172, 225, 191, 10, 78, 170, 57, 118, 215, 70, 96, 34, 123, 133, 57, 50, 10, 85, 95, 145, 176, 172, 153, 125, 72, 159, 106, 231, 34, 99, 193, 206, 250, 195, 170, 100, 192, 154, 207, 253, 238, 164, 2, 131, 229 } });

            migrationBuilder.CreateIndex(
                name: "IX_InjuryTherapy_TherapyId",
                table: "InjuryTherapy",
                column: "TherapyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTherapy_Therapies_TherapyId",
                table: "ExerciseTherapy",
                column: "TherapyId",
                principalTable: "Therapies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseTherapy_Therapies_TherapyId",
                table: "ExerciseTherapy");

            migrationBuilder.DropTable(
                name: "InjuryTherapy");

            migrationBuilder.RenameColumn(
                name: "TherapyId",
                table: "ExerciseTherapy",
                newName: "TherapiesId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseTherapy_TherapyId",
                table: "ExerciseTherapy",
                newName: "IX_ExerciseTherapy_TherapiesId");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5792), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5795), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5798), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5803), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5806), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5809), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5822), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5827), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5836), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5842), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5849), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5852), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6923), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6926), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6931), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6972), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6976), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6979), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6982), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6985), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6987), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6991), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6994), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6997), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7000), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7072), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(2551), "A51C9401CC3889D5E9653D13FFCB17DA90EBF7F8844DC1D9179B15458692F155F30D8DFE078E9B09C906C3FE92C0FD6C12F4B2EC064FB182EC998BE7F9A0ABFC", new byte[] { 106, 196, 229, 216, 9, 122, 115, 101, 63, 164, 198, 165, 92, 75, 145, 25, 81, 156, 150, 183, 67, 82, 174, 249, 224, 163, 241, 125, 176, 189, 237, 228, 25, 59, 221, 86, 119, 50, 18, 185, 170, 178, 114, 84, 10, 7, 171, 52, 93, 16, 32, 215, 36, 21, 108, 19, 191, 216, 232, 171, 180, 229, 184, 96 } });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseTherapy_Therapies_TherapiesId",
                table: "ExerciseTherapy",
                column: "TherapiesId",
                principalTable: "Therapies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
