using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllergiesToFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllergyFood",
                columns: table => new
                {
                    AllergiesId = table.Column<long>(type: "bigint", nullable: false),
                    FoodId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyFood", x => new { x.AllergiesId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_AllergyFood_Allergies_AllergiesId",
                        column: x => x.AllergiesId,
                        principalTable: "Allergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyFood_Food_FoodId",
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
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8984), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8988), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8991), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9003), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9009), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9015), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9021), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9024), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9026), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9029), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9032), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9036), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9055), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9062), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9064), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9068), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9070), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9072), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9074), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9076), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(4838), new DateTime(2023, 5, 10, 14, 52, 23, 413, DateTimeKind.Utc).AddTicks(4841), "9A644481F909E55BF0D77768F016F0417EF239E89F89A6FA0211D447D058AD6FD09055A0F939909C7D80CBDCF35DD66E5C83D2D434C714F359213124460E619C", new byte[] { 231, 112, 132, 12, 223, 240, 103, 84, 178, 27, 180, 5, 1, 199, 237, 16, 101, 106, 215, 95, 194, 65, 109, 234, 4, 64, 212, 79, 96, 252, 228, 21, 180, 31, 141, 203, 163, 72, 3, 97, 133, 132, 62, 38, 93, 144, 180, 68, 102, 206, 162, 215, 34, 212, 60, 48, 53, 157, 75, 25, 109, 28, 178, 251 } });

            migrationBuilder.CreateIndex(
                name: "IX_AllergyFood_FoodId",
                table: "AllergyFood",
                column: "FoodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergyFood");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5501), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5520), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5526), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5529), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5536), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5539), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5547), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5551), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5553), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5555), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5567), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5571), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5571) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5574), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5634), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5639), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5644), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(2348), new DateTime(2023, 5, 10, 14, 39, 15, 380, DateTimeKind.Utc).AddTicks(2350), "E7E3F7289AB01F6650D83EEAC8CCF2A270D530EDE2620B4D61140E0A6E861FE22061421AA7B6B11FB1E0832BC032F7E27B2F4D2382DF88DAC4CE0A24BFDCC3D3", new byte[] { 219, 41, 160, 6, 159, 98, 84, 68, 175, 152, 103, 221, 215, 223, 156, 6, 149, 150, 240, 71, 27, 28, 71, 213, 182, 78, 49, 59, 139, 122, 137, 50, 232, 240, 234, 155, 193, 191, 215, 243, 19, 253, 42, 71, 189, 55, 64, 16, 115, 245, 154, 76, 168, 9, 68, 189, 53, 116, 159, 155, 204, 196, 8, 207 } });
        }
    }
}
