using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class SwappedInjuryForMuscleGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InjuryTherapy");

            migrationBuilder.DropTable(
                name: "Injuries");

            migrationBuilder.CreateTable(
                name: "InjuredMuscleTherapy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InjuredMuscleId = table.Column<long>(type: "bigint", nullable: false),
                    TherapyId = table.Column<long>(type: "bigint", nullable: false),
                    InjurySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuredMuscleTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjuredMuscleTherapy_MuscleGroups_InjuredMuscleId",
                        column: x => x.InjuredMuscleId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuredMuscleTherapy_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2111), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 5, 31, 8, 16, 30, 811, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3091), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3118), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3122), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3126), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3134), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3169), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3176), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3199), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3202), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3205), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 5, 31, 8, 16, 30, 813, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 31, 8, 16, 30, 810, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 5, 31, 8, 16, 30, 810, DateTimeKind.Utc).AddTicks(7925), "21D2081E2B79FE9B9C9FC99FDA5EA69E59DB97FF2928C91D8955F5B530D1B2D61612A82E0946656A16DBB91D9FCE5028A686A6482315911C8F67C759F36EF756", new byte[] { 200, 54, 25, 117, 172, 74, 186, 100, 95, 181, 63, 134, 228, 198, 2, 127, 226, 154, 223, 115, 24, 252, 72, 241, 169, 234, 255, 148, 192, 191, 61, 139, 100, 103, 211, 160, 221, 167, 79, 71, 34, 59, 31, 34, 55, 179, 60, 88, 195, 40, 71, 38, 201, 206, 39, 55, 177, 61, 9, 130, 195, 251, 43, 75 } });

            migrationBuilder.CreateIndex(
                name: "IX_InjuredMuscleTherapy_InjuredMuscleId",
                table: "InjuredMuscleTherapy",
                column: "InjuredMuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuredMuscleTherapy_TherapyId",
                table: "InjuredMuscleTherapy",
                column: "TherapyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InjuredMuscleTherapy");

            migrationBuilder.CreateTable(
                name: "Injuries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MuscleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injuries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Injuries_MuscleGroups_MuscleId",
                        column: x => x.MuscleId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjuryTherapy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuryId = table.Column<long>(type: "bigint", nullable: false),
                    TherapyId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InjurySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjuryTherapy_Injuries_InjuryId",
                        column: x => x.InjuryId,
                        principalTable: "Injuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryTherapy_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3159), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3225), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3227), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3230), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3231), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3233), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3234), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3236), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3238), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3239), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3241), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3242), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3248), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3251), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3255), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3258), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8217), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8224), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8232), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8238), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9009), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9015), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9027), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9032), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9035), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9037), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9039), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9041), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9043), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9045), new DateTime(2023, 5, 24, 21, 57, 58, 136, DateTimeKind.Utc).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(594), new DateTime(2023, 5, 24, 21, 57, 58, 135, DateTimeKind.Utc).AddTicks(597), "7EC7F49F580E02ECA097C2F6E26C84D788911717C9592D8194AC3E6E58295A9059B7D79298897DD3B4EC6CB81888B59DE2AEF8813427B1D9B7F7EF5D2BADCAB5", new byte[] { 241, 229, 249, 92, 52, 46, 19, 241, 204, 188, 136, 187, 240, 159, 243, 129, 190, 156, 25, 65, 92, 153, 222, 212, 142, 101, 240, 171, 214, 223, 96, 221, 192, 169, 195, 33, 104, 136, 119, 151, 88, 224, 190, 30, 108, 59, 181, 23, 35, 18, 61, 108, 143, 187, 182, 57, 35, 201, 59, 136, 96, 212, 94, 207 } });

            migrationBuilder.CreateIndex(
                name: "IX_Injuries_MuscleId",
                table: "Injuries",
                column: "MuscleId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuryTherapy_InjuryId",
                table: "InjuryTherapy",
                column: "InjuryId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuryTherapy_TherapyId",
                table: "InjuryTherapy",
                column: "TherapyId");
        }
    }
}
