using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedDiagnosesToMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosisMedicalRecord",
                columns: table => new
                {
                    DiagnosesId = table.Column<long>(type: "bigint", nullable: false),
                    MedicalRecordsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisMedicalRecord", x => new { x.DiagnosesId, x.MedicalRecordsId });
                    table.ForeignKey(
                        name: "FK_DiagnosisMedicalRecord_Diagnoses_DiagnosesId",
                        column: x => x.DiagnosesId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisMedicalRecord_MedicalRecords_MedicalRecordsId",
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
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6742), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6773), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6787), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6791), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6794), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6796), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6800), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6811), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6813), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6815), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6818), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6820), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6822), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6824), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6826), new DateTime(2023, 5, 10, 15, 5, 54, 93, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 5, 54, 92, DateTimeKind.Utc).AddTicks(8337), new DateTime(2023, 5, 10, 15, 5, 54, 92, DateTimeKind.Utc).AddTicks(8340), "203B7F3FC2166D513DA7BD8906124467130F973B05B1CACBE97E5AA76E944B1F50056FDC23546F3C03EC695252A1ECB68FF70356DC3572840C9A3BDDE88B63F7", new byte[] { 107, 60, 199, 206, 53, 221, 29, 177, 187, 111, 224, 200, 22, 223, 66, 184, 4, 99, 47, 119, 41, 160, 111, 231, 128, 87, 222, 104, 0, 131, 96, 241, 113, 185, 147, 231, 20, 224, 100, 10, 69, 38, 55, 36, 22, 48, 98, 209, 114, 144, 111, 197, 247, 180, 67, 199, 71, 24, 67, 196, 230, 116, 40, 104 } });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisMedicalRecord_MedicalRecordsId",
                table: "DiagnosisMedicalRecord",
                column: "MedicalRecordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosisMedicalRecord");

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
        }
    }
}
