using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class UserProfileAvatarIsNullable : Migration
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
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(280), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(305), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(310), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(312), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(315), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(319), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(323), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(333), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(336), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(339), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(341), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(344), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(357), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(361), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(363), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(483), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(486), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(489), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(492), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(494), new DateTime(2023, 4, 17, 14, 59, 37, 223, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 17, 14, 59, 37, 222, DateTimeKind.Utc).AddTicks(6088), new DateTime(2023, 4, 17, 14, 59, 37, 222, DateTimeKind.Utc).AddTicks(6092), "94E7DF4B2FDFF087321F88EA7C622DBDFD86046A84EB8D8F3F991FC5815C2B6BA91F6B74E03F459C428D2D9A417C1B2AD39AD7953FBAD3F930FBAAB21FD9E6A0", new byte[] { 154, 238, 116, 194, 15, 63, 148, 19, 59, 196, 169, 26, 141, 45, 251, 222, 7, 55, 139, 11, 63, 8, 146, 14, 230, 117, 50, 104, 193, 106, 182, 186, 159, 94, 12, 146, 51, 74, 94, 250, 239, 118, 43, 179, 78, 135, 26, 185, 134, 58, 71, 47, 219, 137, 157, 234, 218, 235, 53, 97, 3, 47, 102, 241 } });
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
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7291), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7293), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7297), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7437), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7442), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7455), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7459), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7462), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7464), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7466), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7467), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7469), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(5362), "178533E0CFDB492829F7718B75275C0EB1616BF01038A06811C2075BA048A0AFD12A47A25A465B2A70543278044428D58D9D38D0F5D2CDFF4DA1586493DC9337", new byte[] { 222, 197, 107, 65, 120, 86, 18, 222, 17, 136, 181, 85, 158, 117, 212, 91, 188, 81, 61, 110, 16, 206, 161, 107, 202, 186, 139, 105, 162, 188, 193, 4, 153, 229, 117, 164, 77, 44, 156, 244, 134, 195, 70, 108, 206, 242, 173, 212, 201, 195, 85, 200, 94, 199, 193, 84, 12, 46, 48, 35, 240, 0, 118, 32 } });
        }
    }
}
