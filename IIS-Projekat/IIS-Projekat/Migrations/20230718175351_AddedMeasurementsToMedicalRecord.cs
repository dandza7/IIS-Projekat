using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedMeasurementsToMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUnhappy",
                table: "ExerciseTrainingSession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Bicep = table.Column<float>(type: "real", nullable: false),
                    Forearm = table.Column<float>(type: "real", nullable: false),
                    Chest = table.Column<float>(type: "real", nullable: false),
                    Waist = table.Column<float>(type: "real", nullable: false),
                    Thigh = table.Column<float>(type: "real", nullable: false),
                    Calf = table.Column<float>(type: "real", nullable: false),
                    MedicalRecordId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2201), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2217), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2218), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2221), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2228), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2229), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2231), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2290), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2291), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2293), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2295), new DateTime(2023, 7, 18, 17, 53, 50, 710, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8417), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8431), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8433), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8435), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8437), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8439), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8442), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8468), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8470), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8473), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8477), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8479), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8481), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8482), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8484), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8486), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8488), new DateTime(2023, 7, 18, 17, 53, 50, 711, DateTimeKind.Utc).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 18, 17, 53, 50, 709, DateTimeKind.Utc).AddTicks(8634), new DateTime(2023, 7, 18, 17, 53, 50, 709, DateTimeKind.Utc).AddTicks(8636), "D23A2F050E9AFC1AF30F15146D9BC9687013F4F38D25A036816FEE248F62492251A09DEEB5A6FC11E6BE6701FA7DBC0EE91461038C70949FF31D6A920AC9CB28", new byte[] { 141, 86, 81, 231, 145, 216, 56, 172, 95, 254, 195, 255, 82, 221, 193, 104, 76, 196, 197, 242, 82, 53, 61, 225, 1, 170, 247, 17, 181, 88, 38, 140, 187, 240, 72, 36, 255, 162, 109, 234, 153, 159, 39, 142, 64, 209, 163, 210, 55, 75, 165, 142, 50, 167, 247, 248, 127, 86, 5, 248, 90, 249, 9, 5 } });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_MedicalRecordId",
                table: "Measurements",
                column: "MedicalRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropColumn(
                name: "IsUnhappy",
                table: "ExerciseTrainingSession");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7121), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7147), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7154), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7161), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7167), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7178), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7181), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7195), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7232), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7236), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7364), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7377), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7380), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5388), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5402), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5404), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5445), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5452), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5455), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5459) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5461), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5468), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5471), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5478), new DateTime(2023, 6, 3, 18, 12, 52, 153, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 6, 3, 18, 12, 52, 151, DateTimeKind.Utc).AddTicks(3680), "C8CB00A8BB7613D31BBA5D154D8302A951F8581A7FA34EF81A6E182AF4AA31429A126C6D70A0D0EECB83884DA1FA1BF1E29750A05670A9917E95E4E31EB7A194", new byte[] { 211, 243, 162, 248, 220, 211, 62, 5, 75, 196, 201, 145, 169, 176, 17, 191, 106, 125, 119, 138, 248, 180, 32, 192, 147, 131, 199, 111, 176, 30, 178, 160, 149, 158, 84, 207, 8, 250, 227, 65, 7, 52, 19, 100, 203, 142, 179, 44, 226, 171, 192, 244, 218, 190, 78, 66, 235, 121, 52, 35, 176, 110, 141, 233 } });
        }
    }
}
