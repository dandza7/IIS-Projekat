using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllergiesToMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllergyMedicalRecord",
                columns: table => new
                {
                    AllergiesId = table.Column<long>(type: "bigint", nullable: false),
                    MedicalRecordsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyMedicalRecord", x => new { x.AllergiesId, x.MedicalRecordsId });
                    table.ForeignKey(
                        name: "FK_AllergyMedicalRecord_Allergies_AllergiesId",
                        column: x => x.AllergiesId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyMedicalRecord_MedicalRecords_MedicalRecordsId",
                        column: x => x.MedicalRecordsId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4030), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4043), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4203), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4206), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4208), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4214), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4216), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4218), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4219), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4221), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4233), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4234), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4237), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4239), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4241), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4242), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4244), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4246), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(1243), new DateTime(2023, 5, 10, 15, 1, 17, 735, DateTimeKind.Utc).AddTicks(1245), "A9E1EE8B3199C22486B4833B0402E560AF22A15833EE2BBF7C8450ACAAB81A8104DADBBAC98A37FE3002EA8E164827BFC8B1F12CE2412A3301C6E2F42AA66408", new byte[] { 38, 11, 115, 221, 205, 76, 189, 213, 224, 72, 162, 107, 184, 59, 250, 6, 82, 87, 215, 217, 239, 94, 131, 96, 69, 87, 57, 1, 149, 242, 23, 12, 64, 63, 91, 65, 34, 199, 100, 108, 54, 151, 7, 111, 7, 55, 174, 2, 153, 254, 159, 79, 156, 46, 135, 21, 29, 54, 93, 123, 115, 53, 207, 137 } });

            migrationBuilder.CreateIndex(
                name: "IX_AllergyMedicalRecord_MedicalRecordsId",
                table: "AllergyMedicalRecord",
                column: "MedicalRecordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergyMedicalRecord");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8984), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8988), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8991), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9003), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9009), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9015), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9021), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9024), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9026), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9029), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9032), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9036), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9055), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9064), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9068), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9070), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9072), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9074), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9076), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(4841), "9A644481F909E55BF0D77768F016F0417EF239E89F89A6FA0211D447D058AD6FD09055A0F939909C7D80CBDCF35DD66E5C83D2D434C714F359213124460E619C", new byte[] { 231, 112, 132, 12, 223, 240, 103, 84, 178, 27, 180, 5, 1, 199, 237, 16, 101, 106, 215, 95, 194, 65, 109, 234, 4, 64, 212, 79, 96, 252, 228, 21, 180, 31, 141, 203, 163, 72, 3, 97, 133, 132, 62, 38, 93, 144, 180, 68, 102, 206, 162, 215, 34, 212, 60, 48, 53, 157, 75, 25, 109, 28, 178, 251 } });
        }
    }
}
