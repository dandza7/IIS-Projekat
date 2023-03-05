using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedSaltingAndHashing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 36, 21, 134, DateTimeKind.Utc).AddTicks(4951), new DateTime(2023, 3, 5, 0, 36, 21, 134, DateTimeKind.Utc).AddTicks(4954), "D148435D55E9E9B6814119C30FE7DDA7252946936A00C915C3F4E1243F14D0DC6D5AB26AF769BF1ECAD6A6EA7FCADB4267B50A757E9A5ED57585AE32DFF2A73F", new byte[] { 225, 233, 29, 77, 110, 33, 136, 239, 112, 190, 168, 208, 201, 106, 51, 161, 123, 232, 137, 124, 94, 150, 172, 196, 86, 229, 180, 21, 120, 117, 42, 35, 60, 142, 249, 140, 139, 162, 122, 203, 36, 255, 20, 119, 94, 3, 175, 86, 1, 245, 212, 228, 254, 186, 86, 188, 214, 32, 101, 57, 32, 244, 191, 59 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 4, 23, 32, 7, 361, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 3, 4, 23, 32, 7, 361, DateTimeKind.Utc).AddTicks(7421), "123" });
        }
    }
}
