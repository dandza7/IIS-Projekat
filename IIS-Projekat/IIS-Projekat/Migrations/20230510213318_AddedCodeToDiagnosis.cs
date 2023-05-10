using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedCodeToDiagnosis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Diagnoses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2756), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2790), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2793), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2796), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2801), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2803), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2805), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2810), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2815), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2819), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2837), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2840), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2842), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2845), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2846), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2848), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 5, 10, 21, 33, 17, 847, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 21, 33, 17, 846, DateTimeKind.Utc).AddTicks(7107), new DateTime(2023, 5, 10, 21, 33, 17, 846, DateTimeKind.Utc).AddTicks(7110), "EEEF52EE4FDBB0FB8D37BAE2679699639827C4E5D3D0BF7F2A097DE85801E81FE00F13560E6682A7BF8E41151AB19A4FECD2766D3FD4FF1F68BFEF627C04658B", new byte[] { 94, 68, 134, 99, 186, 134, 166, 159, 28, 133, 216, 104, 247, 227, 39, 190, 150, 16, 97, 162, 130, 69, 6, 181, 185, 14, 143, 51, 215, 198, 23, 231, 224, 61, 85, 204, 218, 124, 190, 130, 3, 27, 152, 44, 105, 129, 234, 34, 31, 114, 77, 8, 105, 183, 162, 96, 162, 5, 33, 204, 180, 89, 59, 60 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Diagnoses");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8063), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8066), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8069), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8074), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8076), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8078), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8082), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8087), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8088), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8090), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8097), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8101), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8104), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8106), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8108), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8110), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(5581), new DateTime(2023, 5, 10, 17, 49, 32, 821, DateTimeKind.Utc).AddTicks(5584), "51970134C370B55ACBAA987C540148A365F14E16B0A2DD86CA6A6D7B761BAC58E45737AEB1424AB461602DB8373D3AEC7B54700A14CD53FF24478C158D765069", new byte[] { 218, 234, 249, 80, 87, 248, 2, 157, 145, 135, 236, 156, 50, 188, 96, 216, 193, 154, 49, 105, 87, 201, 239, 202, 252, 20, 99, 199, 103, 63, 2, 172, 37, 80, 137, 160, 253, 112, 225, 101, 121, 29, 179, 54, 202, 102, 200, 47, 250, 24, 147, 198, 209, 167, 220, 153, 47, 113, 69, 214, 115, 58, 60, 141 } });
        }
    }
}
