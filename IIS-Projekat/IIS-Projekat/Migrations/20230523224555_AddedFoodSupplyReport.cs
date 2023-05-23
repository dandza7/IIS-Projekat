using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedFoodSupplyReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodOrders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    FoodPriceId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodOrders_FoodPrices_FoodPriceId",
                        column: x => x.FoodPriceId,
                        principalTable: "FoodPrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodSupplyReports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodSupplyReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodOrderFoodSupplyReport",
                columns: table => new
                {
                    FoodOrdersId = table.Column<long>(type: "bigint", nullable: false),
                    FoodSupplyReportId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderFoodSupplyReport", x => new { x.FoodOrdersId, x.FoodSupplyReportId });
                    table.ForeignKey(
                        name: "FK_FoodOrderFoodSupplyReport_FoodOrders_FoodOrdersId",
                        column: x => x.FoodOrdersId,
                        principalTable: "FoodOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodOrderFoodSupplyReport_FoodSupplyReports_FoodSupplyReportId",
                        column: x => x.FoodSupplyReportId,
                        principalTable: "FoodSupplyReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5792), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5795), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5798), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5803), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5806), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5809), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5822), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5827), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5836), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5842), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5849), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5852), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6923), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6926), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6931), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6934), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6972), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6976), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6979), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6982), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6985), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6987), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6991), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6994), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6997), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7000), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7072), new DateTime(2023, 5, 23, 22, 45, 54, 352, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 5, 23, 22, 45, 54, 350, DateTimeKind.Utc).AddTicks(2551), "A51C9401CC3889D5E9653D13FFCB17DA90EBF7F8844DC1D9179B15458692F155F30D8DFE078E9B09C906C3FE92C0FD6C12F4B2EC064FB182EC998BE7F9A0ABFC", new byte[] { 106, 196, 229, 216, 9, 122, 115, 101, 63, 164, 198, 165, 92, 75, 145, 25, 81, 156, 150, 183, 67, 82, 174, 249, 224, 163, 241, 125, 176, 189, 237, 228, 25, 59, 221, 86, 119, 50, 18, 185, 170, 178, 114, 84, 10, 7, 171, 52, 93, 16, 32, 215, 36, 21, 108, 19, 191, 216, 232, 171, 180, 229, 184, 96 } });

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrderFoodSupplyReport_FoodSupplyReportId",
                table: "FoodOrderFoodSupplyReport",
                column: "FoodSupplyReportId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodOrders_FoodPriceId",
                table: "FoodOrders",
                column: "FoodPriceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOrderFoodSupplyReport");

            migrationBuilder.DropTable(
                name: "FoodOrders");

            migrationBuilder.DropTable(
                name: "FoodSupplyReports");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6774), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6785), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6787), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6791), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6795), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6796), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6798), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6801), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6803), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6804), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6807), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6808), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6813), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6860), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6863), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6866), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6867), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6869), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5510), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5538), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5543), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5548), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5550), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5579), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5581), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5585), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5587), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5590), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5593), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5595), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5598), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5601), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5603), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5607), new DateTime(2023, 5, 23, 22, 31, 17, 187, DateTimeKind.Utc).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(4799), new DateTime(2023, 5, 23, 22, 31, 17, 185, DateTimeKind.Utc).AddTicks(4804), "DF88FDB15E78826C2A601DFE2A4DE360E66DBDF97F6B3DAFA4B935DFF767FDDAE07D4B56636A930F67AB12AADC87060563734FE7AE64101FCFF8BA81069C9E23", new byte[] { 42, 45, 253, 129, 128, 81, 245, 75, 155, 37, 204, 73, 199, 85, 149, 218, 108, 193, 171, 171, 190, 158, 105, 227, 130, 92, 158, 253, 222, 146, 189, 250, 165, 67, 160, 79, 76, 39, 243, 37, 68, 93, 27, 239, 196, 54, 199, 209, 107, 8, 186, 106, 196, 253, 108, 26, 162, 176, 119, 146, 73, 138, 37, 228 } });
        }
    }
}
