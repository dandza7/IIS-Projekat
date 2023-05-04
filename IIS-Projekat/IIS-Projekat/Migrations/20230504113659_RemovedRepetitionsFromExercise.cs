using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRepetitionsFromExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Repetitions",
                table: "Exercises");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(889), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(912), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(920), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(925), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1003), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1006), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1018), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1021), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1024), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1038), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1041), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1044), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1047), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1050), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1052), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1055), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 5, 4, 11, 36, 59, 598, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 4, 11, 36, 59, 597, DateTimeKind.Utc).AddTicks(6850), new DateTime(2023, 5, 4, 11, 36, 59, 597, DateTimeKind.Utc).AddTicks(6854), "242873F53B6CC6E50067B0046D8A07E99CF4A03E5387FC6AB10A81DC319F3A16BF83498E14CEC412FAB2FFD3BA9918A708EFBA885EFAC5E92775AD53B10DE24F", new byte[] { 182, 225, 218, 220, 138, 191, 45, 96, 38, 8, 216, 78, 137, 248, 176, 42, 25, 93, 135, 24, 39, 0, 85, 79, 195, 98, 72, 52, 114, 88, 96, 146, 52, 53, 114, 47, 244, 160, 68, 232, 123, 163, 175, 33, 71, 217, 80, 51, 28, 68, 153, 80, 44, 170, 65, 160, 210, 169, 114, 94, 93, 117, 122, 41 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Repetitions",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
