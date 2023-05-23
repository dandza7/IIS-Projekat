using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedMealModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortionSize = table.Column<float>(type: "real", nullable: false),
                    RecipeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(844), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(878), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(883), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(892), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(906), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(921), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(924), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8543), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8547), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8551), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8561), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8589), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8596), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8602), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8605), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8607), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8676), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 762, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 5, 23, 15, 16, 40, 762, DateTimeKind.Utc).AddTicks(8478), "1885FAB4B24C5F1585F869DA809806B71819343DA73FD865EE4006A88A1BB3EE14DE6465FF251EFAC4721882169F93700DAE74D07072203990CED8B2A9C33B77", new byte[] { 0, 220, 123, 244, 86, 69, 20, 183, 187, 166, 11, 195, 218, 229, 246, 165, 38, 148, 116, 250, 112, 193, 170, 119, 33, 80, 197, 72, 222, 74, 132, 144, 101, 158, 90, 28, 224, 2, 85, 129, 7, 187, 57, 51, 89, 121, 115, 28, 144, 79, 55, 240, 0, 97, 105, 175, 60, 78, 253, 111, 120, 214, 208, 30 } });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_RecipeId",
                table: "Meals",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(30), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(45), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(59), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(61), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(62), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(176), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(178), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(180), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(182), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(183) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(184), new DateTime(2023, 5, 23, 15, 7, 52, 934, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1722), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1751), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1817), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1822), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1870), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1896), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1899), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 5, 23, 15, 7, 52, 936, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 7, 52, 933, DateTimeKind.Utc).AddTicks(5162), new DateTime(2023, 5, 23, 15, 7, 52, 933, DateTimeKind.Utc).AddTicks(5164), "53ECE7C7CC33BB168A542FCEEF7BDB862FDB0EC542E9FB07ED91AD81348B9A20083B3E7EDBD772144E89BC53C0297A199BA58EFA96197CC35034845D377BDEA4", new byte[] { 197, 254, 75, 109, 191, 30, 27, 246, 145, 201, 37, 97, 254, 157, 180, 8, 103, 19, 217, 28, 231, 23, 214, 179, 230, 144, 67, 237, 204, 215, 1, 1, 154, 173, 207, 212, 35, 24, 0, 174, 243, 241, 102, 104, 11, 223, 250, 241, 64, 72, 29, 128, 36, 238, 183, 0, 51, 41, 222, 169, 165, 97, 107, 51 } });
        }
    }
}
