using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRequiredPropertiesFromUsersProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 57, 59, 372, DateTimeKind.Utc).AddTicks(7417), new DateTime(2023, 4, 11, 0, 57, 59, 372, DateTimeKind.Utc).AddTicks(7421), "F31914BC3D9B75C5FABF42AC716DD051C8630047CBCE7A3BEBEE5251974A23E4EC40B47B586ED8567813FA9425396616EE0AAEC385AD63E9BD8519F17DD37AFD", new byte[] { 66, 182, 84, 204, 98, 201, 18, 107, 142, 194, 155, 51, 243, 51, 87, 205, 36, 215, 156, 36, 203, 127, 146, 113, 154, 63, 83, 42, 125, 228, 21, 58, 187, 10, 211, 182, 55, 182, 14, 39, 202, 191, 162, 239, 102, 30, 7, 22, 70, 147, 217, 254, 183, 211, 41, 161, 224, 18, 152, 22, 60, 29, 201, 42 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Avatar",
                table: "Profiles",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 10, 18, 27, 33, 432, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 4, 10, 18, 27, 33, 432, DateTimeKind.Utc).AddTicks(3136), "8314524AE9393E78040E88D3099BF43322A5646545F87B0B4542EF1C5089AF9CB21EBF30F1194A83CFA665DFF210874E5F6A4D87186900877D7A3B85E9E8AF65", new byte[] { 5, 220, 166, 243, 190, 73, 23, 252, 146, 240, 165, 69, 188, 120, 0, 85, 213, 107, 9, 254, 97, 24, 185, 246, 124, 87, 230, 172, 7, 36, 188, 153, 52, 108, 54, 191, 108, 194, 235, 184, 218, 195, 192, 28, 168, 161, 207, 187, 57, 3, 55, 3, 208, 155, 16, 3, 231, 35, 177, 27, 11, 236, 248, 172 } });
        }
    }
}
