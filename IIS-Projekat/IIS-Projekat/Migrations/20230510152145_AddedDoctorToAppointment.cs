using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedDoctorToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DoctorId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2465), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2468), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2470), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2476), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2478), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2492), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2499), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2501), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2506), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2508), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2509), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2512), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2514), new DateTime(2023, 5, 10, 15, 21, 44, 569, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 21, 44, 568, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 5, 10, 15, 21, 44, 568, DateTimeKind.Utc).AddTicks(9532), "34BC4480734C626D94CC448226D32472F095967D2D8B978EE0722906FDC4E78FAA52368BEE69FF809C575EF9A9B7905A9D4BE4FC47B794133588328C0AB802D4", new byte[] { 193, 242, 89, 98, 152, 79, 60, 125, 35, 24, 72, 117, 239, 69, 195, 245, 159, 108, 37, 155, 25, 228, 247, 135, 11, 61, 238, 209, 239, 37, 214, 39, 127, 104, 204, 251, 2, 252, 160, 195, 46, 184, 4, 254, 24, 81, 53, 72, 93, 251, 214, 136, 63, 55, 63, 135, 115, 156, 129, 21, 187, 42, 106, 167 } });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_DoctorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(917), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(920), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(922), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(924), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(927), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(928), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(930), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(932), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(934), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(936), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(938), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(940), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(941), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(949), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(951), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(952), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(955), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(957), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(958), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(962), new DateTime(2023, 5, 10, 15, 20, 22, 985, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 20, 22, 984, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 5, 10, 15, 20, 22, 984, DateTimeKind.Utc).AddTicks(7982), "11976F6C14EF0036785B49C379C8A760F05290B469EB210EB65F4A6EFC1EF9EDFA99BC423A69253B4BB9FAAAA999406C5F54E303563CCF84ECF583436E3DBA37", new byte[] { 130, 222, 225, 44, 18, 230, 42, 88, 56, 132, 121, 49, 61, 68, 201, 103, 228, 134, 17, 232, 167, 200, 173, 190, 74, 152, 86, 245, 101, 37, 224, 49, 254, 120, 143, 17, 249, 21, 247, 30, 136, 25, 253, 245, 234, 230, 31, 49, 196, 57, 93, 200, 221, 82, 23, 140, 182, 234, 195, 12, 129, 210, 230, 222 } });
        }
    }
}
