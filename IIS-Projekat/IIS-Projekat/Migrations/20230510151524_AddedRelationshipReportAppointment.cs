using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipReportAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ReportId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(278), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(300), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(302), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(305), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(308), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(310), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(312), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(319), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(321), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(323), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(328), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(550), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(556), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(563), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(567), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(569), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 801, DateTimeKind.Utc).AddTicks(5966), new DateTime(2023, 5, 10, 15, 15, 23, 801, DateTimeKind.Utc).AddTicks(5969), "9C452F7CF57A46F730DFB7675DBF519E038D2497B05CD6F50D01D1DAC270A49C87A44AEDA56B7CFC5890D52537BB48E8808D6533828590CAE8E09CC31D7654B7", new byte[] { 97, 14, 142, 151, 215, 103, 237, 106, 111, 7, 105, 199, 228, 167, 233, 153, 16, 178, 252, 159, 25, 182, 96, 145, 133, 28, 140, 242, 48, 173, 249, 223, 198, 8, 97, 134, 43, 220, 233, 54, 105, 241, 15, 251, 164, 94, 42, 175, 234, 217, 197, 140, 58, 11, 51, 71, 88, 139, 159, 198, 247, 211, 5, 43 } });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Reports_ReportId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ReportId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Appointments");

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
        }
    }
}
