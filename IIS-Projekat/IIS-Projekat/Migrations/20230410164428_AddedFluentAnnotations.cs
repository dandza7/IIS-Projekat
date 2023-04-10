using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedFluentAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 10, 16, 44, 28, 371, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 4, 10, 16, 44, 28, 371, DateTimeKind.Utc).AddTicks(620), "ACB87311A821B9CFA5AF6BA30E01D97533D6139753DF73595A4908B05CF59FBD622F8CCECA419178CB1500ABBC7C2EAAFD5820647380E97AA0A0F588AE51F51F", new byte[] { 212, 88, 143, 98, 175, 61, 182, 22, 78, 161, 123, 135, 87, 143, 34, 170, 206, 215, 64, 242, 175, 155, 13, 191, 154, 87, 50, 9, 192, 52, 229, 215, 114, 86, 230, 240, 61, 201, 179, 114, 127, 12, 30, 19, 38, 238, 2, 141, 91, 20, 188, 179, 168, 227, 163, 55, 105, 91, 158, 109, 209, 141, 197, 149 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2023, 3, 4, 23, 32, 7, 361, DateTimeKind.Utc).AddTicks(7415), new DateTime(2023, 3, 4, 23, 32, 7, 361, DateTimeKind.Utc).AddTicks(7421), "123" });
        }
    }
}
