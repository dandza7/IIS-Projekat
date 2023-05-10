using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserToMedicalRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PatientId",
                table: "MedicalRecords",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4329), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4332), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4340), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4342), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4346), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4350), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4353), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4356), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4359), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4363), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4372), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4375), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4392), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(1429), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(1431), "20C41C3D034EDEBB8496ED7E0C87618FE518390AACC1B0CB60B9DBAD434C8FF324F36724B2DCB05111DF31CCCC4A74E65C3D402F95D0696AF199937E685C1094", new byte[] { 195, 117, 57, 211, 178, 188, 9, 237, 243, 106, 164, 178, 174, 28, 132, 95, 97, 217, 131, 114, 28, 99, 232, 57, 158, 23, 61, 86, 183, 142, 142, 124, 254, 11, 84, 138, 87, 130, 245, 26, 250, 50, 236, 56, 73, 33, 93, 163, 104, 20, 14, 194, 110, 254, 72, 135, 69, 187, 6, 196, 50, 242, 226, 76 } });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Users_PatientId",
                table: "MedicalRecords",
                column: "PatientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Users_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropIndex(
                name: "IX_MedicalRecords_PatientId",
                table: "MedicalRecords");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalRecords");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7550), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7599), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7771), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7775), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2992), "392E335497D18ABDEBB5A42353A2BE45EF563AA6191A925B653C3E20E2651B890D3876C1590597618734EA3591D20C8738337C0E69088BE94391EDAD54144229", new byte[] { 81, 161, 48, 168, 102, 11, 201, 79, 95, 221, 106, 64, 39, 80, 153, 76, 205, 146, 28, 93, 228, 115, 193, 121, 165, 5, 63, 89, 181, 6, 98, 58, 30, 35, 1, 112, 183, 64, 90, 60, 185, 170, 182, 83, 16, 205, 30, 108, 135, 255, 251, 32, 69, 25, 31, 7, 93, 140, 23, 133, 193, 65, 158, 202 } });
        }
    }
}
