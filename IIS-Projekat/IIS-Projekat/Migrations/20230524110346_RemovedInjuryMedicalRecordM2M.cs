using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedInjuryMedicalRecordM2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjuryTherapy_Injuries_DiagnosedInjuriesId",
                table: "InjuryTherapy");

            migrationBuilder.DropTable(
                name: "InjuryMedicalRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryTherapy",
                table: "InjuryTherapy");

            migrationBuilder.RenameColumn(
                name: "DiagnosedInjuriesId",
                table: "InjuryTherapy",
                newName: "InjuryId");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "InjuryTherapy",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "InjuryTherapy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "InjurySeverity",
                table: "InjuryTherapy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InjuryTherapy",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "InjuryTherapy",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryTherapy",
                table: "InjuryTherapy",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4956), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4968), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4971), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4973), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4975), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4978), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4979), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4981), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4983), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4985), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4987), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4992), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4994), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5008), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5011), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5013), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5015), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5020), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5022), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5598), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5621), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5624), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5626), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5627), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5632), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5666), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5669), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5672), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5674), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5681), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5683), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5685), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5686), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5688), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5691), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(1902), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(1905), "9AE63DCE460FCABB3EC7B6CB99B0E1CE95BABA2ECDB43448FEB3D64C9799B250EC4BE76E1B04E9B2DA1E0BE0C5C317E602A3FC47CEF0236D4E57E0A310CB6265", new byte[] { 78, 149, 48, 162, 226, 167, 120, 42, 2, 178, 50, 146, 137, 231, 23, 238, 77, 201, 23, 28, 147, 205, 27, 62, 164, 124, 175, 150, 39, 220, 218, 56, 116, 14, 181, 204, 225, 162, 36, 187, 194, 185, 240, 103, 59, 189, 119, 249, 114, 199, 161, 152, 110, 240, 80, 234, 52, 62, 173, 74, 105, 16, 19, 236 } });

            migrationBuilder.CreateIndex(
                name: "IX_InjuryTherapy_InjuryId",
                table: "InjuryTherapy",
                column: "InjuryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryTherapy_Injuries_InjuryId",
                table: "InjuryTherapy",
                column: "InjuryId",
                principalTable: "Injuries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjuryTherapy_Injuries_InjuryId",
                table: "InjuryTherapy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryTherapy",
                table: "InjuryTherapy");

            migrationBuilder.DropIndex(
                name: "IX_InjuryTherapy_InjuryId",
                table: "InjuryTherapy");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "InjuryTherapy");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "InjuryTherapy");

            migrationBuilder.DropColumn(
                name: "InjurySeverity",
                table: "InjuryTherapy");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InjuryTherapy");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "InjuryTherapy");

            migrationBuilder.RenameColumn(
                name: "InjuryId",
                table: "InjuryTherapy",
                newName: "DiagnosedInjuriesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryTherapy",
                table: "InjuryTherapy",
                columns: new[] { "DiagnosedInjuriesId", "TherapyId" });

            migrationBuilder.CreateTable(
                name: "InjuryMedicalRecord",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuryId = table.Column<long>(type: "bigint", nullable: false),
                    MedicalRecordId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InjurySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryMedicalRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjuryMedicalRecord_Injuries_InjuryId",
                        column: x => x.InjuryId,
                        principalTable: "Injuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryMedicalRecord_MedicalRecords_MedicalRecordId",
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
                name: "IX_InjuryMedicalRecord_InjuryId",
                table: "InjuryMedicalRecord",
                column: "InjuryId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuryMedicalRecord_MedicalRecordId",
                table: "InjuryMedicalRecord",
                column: "MedicalRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryTherapy_Injuries_DiagnosedInjuriesId",
                table: "InjuryTherapy",
                column: "DiagnosedInjuriesId",
                principalTable: "Injuries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
