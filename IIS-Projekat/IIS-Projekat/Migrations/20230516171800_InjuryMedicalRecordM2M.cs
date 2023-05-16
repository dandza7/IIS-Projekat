using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class InjuryMedicalRecordM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjuryMedicalRecord_Injuries_InjuriesId",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordsId",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryMedicalRecord",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "InjurySeverity",
                table: "Injuries");

            migrationBuilder.RenameColumn(
                name: "MedicalRecordsId",
                table: "InjuryMedicalRecord",
                newName: "MedicalRecordId");

            migrationBuilder.RenameColumn(
                name: "InjuriesId",
                table: "InjuryMedicalRecord",
                newName: "InjuryId");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryMedicalRecord_MedicalRecordsId",
                table: "InjuryMedicalRecord",
                newName: "IX_InjuryMedicalRecord_MedicalRecordId");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "InjuryMedicalRecord",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "InjuryMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InjurySeverity",
                table: "InjuryMedicalRecord",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InjuryMedicalRecord",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "InjuryMedicalRecord",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryMedicalRecord",
                table: "InjuryMedicalRecord",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2330), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2347), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2349), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2351), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2353), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2356), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2357), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2359), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2361), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2363), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2367), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2369), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2370), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2384), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2391), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2396), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2398), new DateTime(2023, 5, 16, 17, 18, 0, 140, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4504), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4521), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4523), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4525), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4527), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4529), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4531), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4563), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4565), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4568), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4571), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4573), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4575), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4576), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4578), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4596), new DateTime(2023, 5, 16, 17, 18, 0, 141, DateTimeKind.Utc).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 16, 17, 18, 0, 139, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 5, 16, 17, 18, 0, 139, DateTimeKind.Utc).AddTicks(9499), "1564AD4F127E049B65BBD0A81A792B433E1684F2FD1547864F502392F9949906C635FFCA19CA9185F23E761FB8FFE5C7AE02761ADBCEEC434C90826EB7DB5586", new byte[] { 171, 88, 229, 96, 225, 93, 97, 42, 96, 96, 68, 251, 213, 136, 155, 230, 240, 101, 28, 88, 164, 231, 123, 81, 218, 34, 63, 136, 31, 101, 172, 19, 111, 125, 1, 97, 248, 137, 34, 82, 40, 158, 136, 126, 100, 88, 168, 162, 163, 34, 43, 17, 19, 186, 50, 178, 59, 158, 202, 122, 88, 197, 137, 14 } });

            migrationBuilder.CreateIndex(
                name: "IX_InjuryMedicalRecord_InjuryId",
                table: "InjuryMedicalRecord",
                column: "InjuryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryMedicalRecord_Injuries_InjuryId",
                table: "InjuryMedicalRecord",
                column: "InjuryId",
                principalTable: "Injuries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordId",
                table: "InjuryMedicalRecord",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjuryMedicalRecord_Injuries_InjuryId",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordId",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryMedicalRecord",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropIndex(
                name: "IX_InjuryMedicalRecord_InjuryId",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "InjurySeverity",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InjuryMedicalRecord");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "InjuryMedicalRecord");

            migrationBuilder.RenameColumn(
                name: "MedicalRecordId",
                table: "InjuryMedicalRecord",
                newName: "MedicalRecordsId");

            migrationBuilder.RenameColumn(
                name: "InjuryId",
                table: "InjuryMedicalRecord",
                newName: "InjuriesId");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryMedicalRecord_MedicalRecordId",
                table: "InjuryMedicalRecord",
                newName: "IX_InjuryMedicalRecord_MedicalRecordsId");

            migrationBuilder.AddColumn<string>(
                name: "InjurySeverity",
                table: "Injuries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryMedicalRecord",
                table: "InjuryMedicalRecord",
                columns: new[] { "InjuriesId", "MedicalRecordsId" });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7382), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7525), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7535), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7539), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7542), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7544), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7553), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7558), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7594), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7162), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7167), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7173), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7196), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7199), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7213), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7221), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7227), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7229), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7232), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7235), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(4466), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(4469), "EF9802C0BF26252260244A849922F5F2CCDA8E4F98A472DFF705BFDC1ED7F8333AA04F839043451A035A0E5B7DE3A616BBD26376B6382D1AEDC3BE30B4F7C899", new byte[] { 97, 147, 92, 18, 86, 107, 252, 97, 101, 44, 34, 125, 249, 51, 37, 146, 156, 43, 226, 107, 22, 210, 13, 228, 105, 199, 133, 146, 224, 47, 16, 247, 144, 173, 221, 151, 22, 32, 242, 215, 153, 0, 181, 139, 7, 12, 90, 212, 222, 43, 18, 141, 250, 131, 66, 237, 31, 55, 58, 9, 27, 53, 115, 189 } });

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryMedicalRecord_Injuries_InjuriesId",
                table: "InjuryMedicalRecord",
                column: "InjuriesId",
                principalTable: "Injuries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordsId",
                table: "InjuryMedicalRecord",
                column: "MedicalRecordsId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
