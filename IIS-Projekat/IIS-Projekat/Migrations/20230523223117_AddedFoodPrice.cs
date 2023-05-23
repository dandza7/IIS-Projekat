using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedFoodPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodPrices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<long>(type: "bigint", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodPrices_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodPrices_FoodId",
                table: "FoodPrices",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodPrices");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2518), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2537), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2547), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2551), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2554), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2724), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2728), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2731), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2734), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2758), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2762), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2766), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2769), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2771), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2774), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2776), new DateTime(2023, 5, 23, 17, 17, 9, 640, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1638), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1667), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1671), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1674), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1676), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1680), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1720), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1725), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1730), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1735), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1737), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1739), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1745), new DateTime(2023, 5, 23, 17, 17, 9, 642, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 17, 17, 9, 639, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 5, 23, 17, 17, 9, 639, DateTimeKind.Utc).AddTicks(9372), "7C7DD5BD8BBB433572F515DF01F9B9F425914E8A560BD7EBC6C19338970BEFC5A8A0C7F11C5D0DCCD7A13F2DCD0BB64EE78F5E4AD9F8210803D358103CF49012", new byte[] { 46, 93, 198, 127, 201, 43, 60, 32, 81, 1, 190, 243, 111, 124, 7, 164, 192, 224, 77, 17, 169, 190, 1, 167, 92, 14, 120, 221, 239, 199, 83, 79, 37, 183, 126, 140, 162, 35, 85, 130, 188, 66, 57, 177, 141, 221, 183, 38, 226, 223, 156, 55, 143, 45, 118, 237, 24, 77, 248, 5, 114, 63, 0, 67 } });
        }
    }
}
