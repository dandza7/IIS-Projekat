using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedCaloriesPropertyToFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionShares");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "Food",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutrientShares",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Share = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutrientId = table.Column<long>(type: "bigint", nullable: false),
                    FoodId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutrientShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutrientShares_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutrientShares_Nutrients_NutrientId",
                        column: x => x.NutrientId,
                        principalTable: "Nutrients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8063), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8066), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8069), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8074), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8076), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8078), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8082), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8087), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8088), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8090), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8097), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8101), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8104), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8106), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8108), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8110), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(5581), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(5584), "51970134C370B55ACBAA987C540148A365F14E16B0A2DD86CA6A6D7B761BAC58E45737AEB1424AB461602DB8373D3AEC7B54700A14CD53FF24478C158D765069", new byte[] { 218, 234, 249, 80, 87, 248, 2, 157, 145, 135, 236, 156, 50, 188, 96, 216, 193, 154, 49, 105, 87, 201, 239, 202, 252, 20, 99, 199, 103, 63, 2, 172, 37, 80, 137, 160, 253, 112, 225, 101, 121, 29, 179, 54, 202, 102, 200, 47, 250, 24, 147, 198, 209, 167, 220, 153, 47, 113, 69, 214, 115, 58, 60, 141 } });

            migrationBuilder.CreateIndex(
                name: "IX_NutrientShares_FoodId",
                table: "NutrientShares",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_NutrientShares_NutrientId",
                table: "NutrientShares",
                column: "NutrientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutrientShares");

            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Food");

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionShares",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<long>(type: "bigint", nullable: false),
                    NutritionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Share = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionShares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionShares_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NutritionShares_Nutritions_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "Nutritions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2465), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2468), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2470), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2476), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2478), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2492), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2499), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2501), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2506), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2508), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2509), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2512), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 568, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 5, 10, 15, 21, 44, 568, DateTimeKind.Utc).AddTicks(9532), "34BC4480734C626D94CC448226D32472F095967D2D8B978EE0722906FDC4E78FAA52368BEE69FF809C575EF9A9B7905A9D4BE4FC47B794133588328C0AB802D4", new byte[] { 193, 242, 89, 98, 152, 79, 60, 125, 35, 24, 72, 117, 239, 69, 195, 245, 159, 108, 37, 155, 25, 228, 247, 135, 11, 61, 238, 209, 239, 37, 214, 39, 127, 104, 204, 251, 2, 252, 160, 195, 46, 184, 4, 254, 24, 81, 53, 72, 93, 251, 214, 136, 63, 55, 63, 135, 115, 156, 129, 21, 187, 42, 106, 167 } });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionShares_FoodId",
                table: "NutritionShares",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionShares_NutritionId",
                table: "NutritionShares",
                column: "NutritionId");
        }
    }
}
