using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedMuscleToInjury : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MuscleId",
                table: "Injuries",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1527), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1545), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1586), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1601), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1620), new DateTime(2023, 5, 10, 14, 32, 29, 180, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 32, 29, 179, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 5, 10, 14, 32, 29, 179, DateTimeKind.Utc).AddTicks(8911), "E665A4C298EE16B4F85CA08DF4E795A2C68D14F4D7C6453B2B65A1983D9EE60298966DA6287162EAE53891618EB74A39288C6387A37814555533C25049DF478A", new byte[] { 61, 247, 211, 25, 110, 132, 109, 29, 137, 169, 67, 77, 133, 11, 103, 91, 118, 5, 123, 134, 77, 137, 72, 78, 182, 144, 122, 230, 176, 172, 75, 122, 60, 229, 85, 25, 59, 99, 51, 210, 67, 64, 181, 173, 125, 56, 253, 111, 142, 58, 160, 46, 158, 9, 51, 47, 236, 112, 199, 203, 194, 55, 62, 186 } });

            migrationBuilder.CreateIndex(
                name: "IX_Injuries_MuscleId",
                table: "Injuries",
                column: "MuscleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Injuries_MuscleGroups_MuscleId",
                table: "Injuries",
                column: "MuscleId",
                principalTable: "MuscleGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Injuries_MuscleGroups_MuscleId",
                table: "Injuries");

            migrationBuilder.DropIndex(
                name: "IX_Injuries_MuscleId",
                table: "Injuries");

            migrationBuilder.DropColumn(
                name: "MuscleId",
                table: "Injuries");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4297), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4321), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4325), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4329), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4332), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4337), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4340), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4342), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4346), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4350), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4353), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4356), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4359), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4363), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4372), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4375), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4392), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(1429), new DateTime(2023, 5, 10, 14, 28, 8, 750, DateTimeKind.Utc).AddTicks(1431), "20C41C3D034EDEBB8496ED7E0C87618FE518390AACC1B0CB60B9DBAD434C8FF324F36724B2DCB05111DF31CCCC4A74E65C3D402F95D0696AF199937E685C1094", new byte[] { 195, 117, 57, 211, 178, 188, 9, 237, 243, 106, 164, 178, 174, 28, 132, 95, 97, 217, 131, 114, 28, 99, 232, 57, 158, 23, 61, 86, 183, 142, 142, 124, 254, 11, 84, 138, 87, 130, 245, 26, 250, 50, 236, 56, 73, 33, 93, 163, 104, 20, 14, 194, 110, 254, 72, 135, 69, 187, 6, 196, 50, 242, 226, 76 } });
        }
    }
}
