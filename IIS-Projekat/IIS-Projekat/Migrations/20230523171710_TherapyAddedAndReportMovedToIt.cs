using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class TherapyAddedAndReportMovedToIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Reports_ReportId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ReportId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Appointments");

            migrationBuilder.CreateTable(
                name: "Therapies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ReportMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalRecordId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapies_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseTherapy",
                columns: table => new
                {
                    RecommendedExercisesId = table.Column<long>(type: "bigint", nullable: false),
                    TherapiesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseTherapy", x => new { x.RecommendedExercisesId, x.TherapiesId });
                    table.ForeignKey(
                        name: "FK_ExerciseTherapy_Exercises_RecommendedExercisesId",
                        column: x => x.RecommendedExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseTherapy_Therapies_TherapiesId",
                        column: x => x.TherapiesId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2518), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2537), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2551), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2554), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2724), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2728), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2731), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2734), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2758), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2762), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2766), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2769), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2771), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2774), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2776), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1638), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1667), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1671), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1674), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1676), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1680), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1730), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1735), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1737), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1739), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1745), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 639, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 5, 23, 17, 17, 9, 639, DateTimeKind.Utc).AddTicks(9372), "7C7DD5BD8BBB433572F515DF01F9B9F425914E8A560BD7EBC6C19338970BEFC5A8A0C7F11C5D0DCCD7A13F2DCD0BB64EE78F5E4AD9F8210803D358103CF49012", new byte[] { 46, 93, 198, 127, 201, 43, 60, 32, 81, 1, 190, 243, 111, 124, 7, 164, 192, 224, 77, 17, 169, 190, 1, 167, 92, 14, 120, 221, 239, 199, 83, 79, 37, 183, 126, 140, 162, 35, 85, 130, 188, 66, 57, 177, 141, 221, 183, 38, 226, 223, 156, 55, 143, 45, 118, 237, 24, 77, 248, 5, 114, 63, 0, 67 } });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseTherapy_TherapiesId",
                table: "ExerciseTherapy",
                column: "TherapiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapies_MedicalRecordId",
                table: "Therapies",
                column: "MedicalRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseTherapy");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.AddColumn<long>(
                name: "ReportId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8877), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8956), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8960), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8973), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8976), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8979), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8983), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8985), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8988), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8991), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9002), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9005), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9008), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9012), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9014), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9017), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9023), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1263), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1311), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1313), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1315), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1318), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1354), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1357), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1366), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1368), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1372), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1377), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(6114), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(6116), "F6C2940242E106DA8C2467EE867827018461824E5C61E9FCCB70B1D03F56EE85F4952E1D7A05175E78B47F642EAF9CBE0776F20C4921C662B220731E0530C2CF", new byte[] { 78, 122, 78, 60, 231, 251, 28, 26, 120, 100, 153, 215, 75, 72, 252, 213, 215, 148, 178, 98, 140, 224, 88, 38, 41, 64, 241, 77, 124, 213, 176, 239, 100, 85, 243, 119, 7, 122, 84, 179, 211, 159, 43, 25, 88, 107, 212, 152, 148, 38, 157, 58, 38, 226, 230, 95, 80, 245, 234, 107, 51, 173, 119, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ReportId",
                table: "Appointments",
                column: "ReportId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Reports_ReportId",
                table: "Appointments",
                column: "ReportId",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
