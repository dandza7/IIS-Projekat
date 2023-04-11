using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedUsersProfileEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 27, 33, 432, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 4, 10, 18, 27, 33, 432, DateTimeKind.Utc).AddTicks(3136), "8314524AE9393E78040E88D3099BF43322A5646545F87B0B4542EF1C5089AF9CB21EBF30F1194A83CFA665DFF210874E5F6A4D87186900877D7A3B85E9E8AF65", new byte[] { 5, 220, 166, 243, 190, 73, 23, 252, 146, 240, 165, 69, 188, 120, 0, 85, 213, 107, 9, 254, 97, 24, 185, 246, 124, 87, 230, 172, 7, 36, 188, 153, 52, 108, 54, 191, 108, 194, 235, 184, 218, 195, 192, 28, 168, 161, 207, 187, 57, 3, 55, 3, 208, 155, 16, 3, 231, 35, 177, 27, 11, 236, 248, 172 } });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 10, 16, 44, 28, 371, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 4, 10, 16, 44, 28, 371, DateTimeKind.Utc).AddTicks(620), "ACB87311A821B9CFA5AF6BA30E01D97533D6139753DF73595A4908B05CF59FBD622F8CCECA419178CB1500ABBC7C2EAAFD5820647380E97AA0A0F588AE51F51F", new byte[] { 212, 88, 143, 98, 175, 61, 182, 22, 78, 161, 123, 135, 87, 143, 34, 170, 206, 215, 64, 242, 175, 155, 13, 191, 154, 87, 50, 9, 192, 52, 229, 215, 114, 86, 230, 240, 61, 201, 179, 114, 127, 12, 30, 19, 38, 238, 2, 141, 91, 20, 188, 179, 168, 227, 163, 55, 105, 91, 158, 109, 209, 141, 197, 149 } });
        }
    }
}
