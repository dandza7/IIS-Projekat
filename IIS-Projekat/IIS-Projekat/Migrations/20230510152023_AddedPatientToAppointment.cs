using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedPatientToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PatientId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(920), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(922), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(924), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(927), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(928), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(930), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(932), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(934), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(936), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(938), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(940), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(941), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(949), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(951), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(952), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(955), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(957), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(958), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(962), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 984, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 5, 10, 15, 20, 22, 984, DateTimeKind.Utc).AddTicks(7982), "11976F6C14EF0036785B49C379C8A760F05290B469EB210EB65F4A6EFC1EF9EDFA99BC423A69253B4BB9FAAAA999406C5F54E303563CCF84ECF583436E3DBA37", new byte[] { 130, 222, 225, 44, 18, 230, 42, 88, 56, 132, 121, 49, 61, 68, 201, 103, 228, 134, 17, 232, 167, 200, 173, 190, 74, 152, 86, 245, 101, 37, 224, 49, 254, 120, 143, 17, 249, 21, 247, 30, 136, 25, 253, 245, 234, 230, 31, 49, 196, 57, 93, 200, 221, 82, 23, 140, 182, 234, 195, 12, 129, 210, 230, 222 } });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9231), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9250), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9253), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9255), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9262), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9264), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9265), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9268), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9346), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9350), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9364), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9373), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(5435), "4BA01E3A96B704C659132B2D2479476D57EDA6E2AF91A9A5A0DC4BF8BCE32D43E310F24B9D0689C74B926F7575B5C5EF0FB00D0BBBC4D7E16FFEED1C19CB0B16", new byte[] { 78, 59, 160, 166, 13, 196, 172, 179, 65, 183, 207, 146, 181, 102, 74, 191, 177, 102, 166, 51, 152, 102, 190, 204, 252, 92, 38, 25, 184, 216, 51, 201, 65, 253, 60, 84, 212, 249, 4, 187, 58, 247, 94, 105, 183, 28, 234, 173, 118, 194, 208, 252, 139, 80, 111, 65, 125, 217, 70, 80, 154, 117, 229, 143 } });
        }
    }
}
