using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class FoodDiagnosisM2MAndSupplementModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosisFood",
                columns: table => new
                {
                    DiagnosesId = table.Column<long>(type: "bigint", nullable: false),
                    InadvisableFoodsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisFood", x => new { x.DiagnosesId, x.InadvisableFoodsId });
                    table.ForeignKey(
                        name: "FK_DiagnosisFood_Diagnoses_DiagnosesId",
                        column: x => x.DiagnosesId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosisFood_Food_InadvisableFoodsId",
                        column: x => x.InadvisableFoodsId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supplement",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<float>(type: "real", nullable: false)
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
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4676), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4698), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4701), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4707), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4711), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4713), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4716), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4718), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4724), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4727), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4730), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4748), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4751), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4753), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4757), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4759), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4762), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4765), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4768), new DateTime(2023, 8, 12, 8, 11, 22, 56, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(683), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(700), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(703), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(706), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(708), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(751), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(765), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(767), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(767) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(772), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 8, 12, 8, 11, 22, 58, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 8, 11, 22, 55, DateTimeKind.Utc).AddTicks(9698), new DateTime(2023, 8, 12, 8, 11, 22, 55, DateTimeKind.Utc).AddTicks(9701), "B1241B44E004D06C3BC4E65C9B1318FA39FC27BFCA49D5EF6311E1F5D011B7215BB9D1128BCDE513F803BF51A7F1AF6343F3433450F021992AD9BC10073942AB", new byte[] { 205, 41, 165, 110, 64, 68, 113, 178, 140, 203, 96, 202, 39, 5, 55, 28, 129, 184, 6, 7, 90, 39, 201, 10, 137, 18, 242, 9, 29, 234, 89, 232, 138, 22, 92, 185, 21, 148, 179, 247, 89, 118, 55, 59, 98, 10, 139, 168, 141, 245, 131, 83, 113, 197, 199, 188, 35, 211, 72, 29, 84, 25, 202, 108 } });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosisFood_InadvisableFoodsId",
                table: "DiagnosisFood",
                column: "InadvisableFoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionPlanSupplement_SupplementsId",
                table: "NutritionPlanSupplement",
                column: "SupplementsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosisFood");

            migrationBuilder.DropTable(
                name: "NutritionPlanSupplement");

            migrationBuilder.DropTable(
                name: "Supplement");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1746), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1790), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1808), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1881), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1902), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1921), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 7, 26, 13, 14, 9, 255, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4004), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4042), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4047), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4057), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4061), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4071), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4075), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4134), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4142), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4145), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4148), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4151), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4156), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4159), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4167), new DateTime(2023, 7, 26, 13, 14, 9, 259, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 26, 13, 14, 9, 254, DateTimeKind.Utc).AddTicks(1414), new DateTime(2023, 7, 26, 13, 14, 9, 254, DateTimeKind.Utc).AddTicks(1423), "6841317B493896D2BA57D0FD34D18E918DFCEA2ACAEB526FD87F835CBB33A71D38E88BDE1CABBC8C0A79FD8828A9BC352190E2DF0EA5376488D7467CA2243C09", new byte[] { 159, 117, 121, 250, 1, 208, 249, 179, 38, 36, 154, 175, 62, 30, 121, 125, 88, 143, 202, 253, 197, 242, 33, 254, 233, 100, 21, 156, 229, 236, 20, 195, 219, 200, 1, 103, 177, 133, 253, 244, 96, 27, 125, 140, 217, 136, 176, 194, 134, 87, 68, 37, 100, 71, 172, 221, 106, 222, 71, 116, 87, 160, 96, 10 } });
        }
    }
}
