using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedHypertrophicCheckToExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHypertrophic",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7934), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7949), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7951), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7952), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7955), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7961), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7964), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7966), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7968), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7979), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7981), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7986), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(5954), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(5957), "8F301F3F1E4DA991379E85E504C15EA8B591671C54889D396844F32460BDBA3FD6BC4AD1EDF43A2B7F589E1ACA80830AC0B18418BE65E6A39DD9BB43BE25B49F", new byte[] { 20, 43, 234, 119, 196, 24, 11, 103, 183, 201, 52, 120, 33, 115, 251, 88, 142, 241, 183, 46, 199, 168, 45, 133, 36, 103, 254, 61, 239, 246, 31, 106, 56, 192, 135, 6, 148, 202, 42, 59, 213, 59, 6, 118, 113, 140, 92, 148, 96, 21, 201, 237, 229, 19, 90, 119, 236, 200, 39, 152, 175, 89, 47, 170 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHypertrophic",
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
    }
}
