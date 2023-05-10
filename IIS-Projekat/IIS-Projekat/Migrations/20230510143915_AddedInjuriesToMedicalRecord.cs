using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedInjuriesToMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InjuryMedicalRecord",
                columns: table => new
                {
                    InjuriesId = table.Column<long>(type: "bigint", nullable: false),
                    MedicalRecordsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryMedicalRecord", x => new { x.InjuriesId, x.MedicalRecordsId });
                    table.ForeignKey(
                        name: "FK_InjuryMedicalRecord_Injuries_InjuriesId",
                        column: x => x.InjuriesId,
                        principalTable: "Injuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordsId",
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
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5501), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5520), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5526), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5529), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5536), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5539), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5547), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5551), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5553), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5555), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5567), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5571), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5574), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5634), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5639), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5644), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(2348), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(2350), "E7E3F7289AB01F6650D83EEAC8CCF2A270D530EDE2620B4D61140E0A6E861FE22061421AA7B6B11FB1E0832BC032F7E27B2F4D2382DF88DAC4CE0A24BFDCC3D3", new byte[] { 219, 41, 160, 6, 159, 98, 84, 68, 175, 152, 103, 221, 215, 223, 156, 6, 149, 150, 240, 71, 27, 28, 71, 213, 182, 78, 49, 59, 139, 122, 137, 50, 232, 240, 234, 155, 193, 191, 215, 243, 19, 253, 42, 71, 189, 55, 64, 16, 115, 245, 154, 76, 168, 9, 68, 189, 53, 116, 159, 155, 204, 196, 8, 207 } });

            migrationBuilder.CreateIndex(
                name: "IX_InjuryMedicalRecord_MedicalRecordsId",
                table: "InjuryMedicalRecord",
                column: "MedicalRecordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InjuryMedicalRecord");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1586), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 179, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 5, 10, 14, 32, 29, 179, DateTimeKind.Utc).AddTicks(8911), "E665A4C298EE16B4F85CA08DF4E795A2C68D14F4D7C6453B2B65A1983D9EE60298966DA6287162EAE53891618EB74A39288C6387A37814555533C25049DF478A", new byte[] { 61, 247, 211, 25, 110, 132, 109, 29, 137, 169, 67, 77, 133, 11, 103, 91, 118, 5, 123, 134, 77, 137, 72, 78, 182, 144, 122, 230, 176, 172, 75, 122, 60, 229, 85, 25, 59, 99, 51, 210, 67, 64, 181, 173, 125, 56, 253, 111, 142, 58, 160, 46, 158, 9, 51, 47, 236, 112, 199, 203, 194, 55, 62, 186 } });
        }
    }
}
