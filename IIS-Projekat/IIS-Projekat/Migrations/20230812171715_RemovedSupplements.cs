using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSupplements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionPlanSupplement");

            migrationBuilder.DropTable(
                name: "Supplement");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3049), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3078), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3081), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3089), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3092), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3095), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3098), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3102), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3104), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3112), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3121), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3124), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3127), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 8, 12, 17, 17, 14, 738, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2244), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2248), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2252), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2255), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2259), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2261), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2263), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2344), new DateTime(2023, 8, 12, 17, 17, 14, 741, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 17, 17, 14, 737, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 8, 12, 17, 17, 14, 737, DateTimeKind.Utc).AddTicks(6563), "E8CF76B1FDB8DC08A57A06CCCAA4333D7507EC5D2E465B28FD34C5CCBE87D667D174B2F38FA13B623EADC0A5D6F29123881D0B7ABB435A19995E194FCA55C067", new byte[] { 60, 223, 115, 152, 251, 217, 251, 86, 183, 149, 230, 247, 188, 51, 154, 238, 232, 7, 85, 6, 87, 59, 40, 211, 80, 85, 205, 191, 123, 23, 181, 252, 77, 173, 178, 53, 11, 15, 222, 196, 172, 250, 87, 163, 47, 129, 170, 198, 33, 38, 208, 6, 212, 71, 52, 72, 49, 233, 200, 61, 163, 63, 241, 172 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dose = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionPlanSupplement",
                columns: table => new
                {
                    NutritionPlansId = table.Column<long>(type: "bigint", nullable: false),
                    SupplementsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionPlanSupplement", x => new { x.NutritionPlansId, x.SupplementsId });
                    table.ForeignKey(
                        name: "FK_NutritionPlanSupplement_NutritionPlans_NutritionPlansId",
                        column: x => x.NutritionPlansId,
                        principalTable: "NutritionPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutritionPlanSupplement_Supplement_SupplementsId",
                        column: x => x.SupplementsId,
                        principalTable: "Supplement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5333), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5346), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5355), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5358), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5361), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5378), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5381), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5384), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5387), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5390), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 8, 12, 9, 19, 56, 308, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3218), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3245), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3249), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3251), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3258), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3293), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3296), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3299), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3302), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3305), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3308), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3312), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3318), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3320), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3325), new DateTime(2023, 8, 12, 9, 19, 56, 310, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 9, 19, 56, 307, DateTimeKind.Utc).AddTicks(9082), new DateTime(2023, 8, 12, 9, 19, 56, 307, DateTimeKind.Utc).AddTicks(9085), "8A6A391FDABA1EB081D3995CFD2A3C68F8D2EF7E3226031B381015A77948587377E45EE896C842042B01C12973FFBFD209103007DAFC1A0E1739810BD256FABE", new byte[] { 228, 93, 101, 136, 15, 61, 31, 102, 199, 17, 151, 123, 141, 90, 57, 235, 165, 51, 244, 215, 234, 232, 71, 217, 159, 79, 75, 73, 35, 90, 61, 136, 108, 103, 44, 203, 112, 81, 100, 77, 210, 233, 236, 63, 69, 211, 159, 150, 175, 48, 146, 85, 251, 115, 70, 77, 134, 226, 142, 197, 244, 126, 202, 30 } });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlanSupplement_SupplementsId",
                table: "NutritionPlanSupplement",
                column: "SupplementsId");
        }
    }
}
