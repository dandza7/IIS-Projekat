using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedNamePropertyToTrainingSessionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfExercises",
                table: "TrainingSessions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TrainingSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2933), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2946), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2949), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2950), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2953), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2956), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2958), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2960), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2961), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2964), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2966), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2968), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2970), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2982), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2984), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2985), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2990), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2993), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2996), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2998), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4184), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4198), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4204), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4206), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4228), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4230), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4233), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4234), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4236), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4238), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4240), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4242), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4243), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4245), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4248), new DateTime(2023, 5, 15, 16, 3, 2, 959, DateTimeKind.Utc).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(669), new DateTime(2023, 5, 15, 16, 3, 2, 958, DateTimeKind.Utc).AddTicks(672), "C88054D99BD53340E69ECAF5ABF251D96F7BB37A5361DA93B9634F2799F6C2DACBD11CA656C8E54BB86F4CB94E692C2D553FAE7CED81681FB6F0B96697A84AF2", new byte[] { 121, 242, 193, 208, 22, 111, 38, 155, 199, 182, 78, 147, 205, 119, 251, 198, 120, 199, 52, 103, 41, 176, 175, 215, 106, 129, 51, 99, 12, 244, 243, 77, 186, 109, 68, 19, 54, 182, 190, 60, 4, 170, 228, 39, 68, 49, 233, 123, 120, 159, 114, 169, 15, 119, 247, 143, 219, 79, 250, 9, 82, 219, 204, 224 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TrainingSessions");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfExercises",
                table: "TrainingSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(610), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(628), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(633), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(634), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(637), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(639), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(641), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(642), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(646), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(649), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(651), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(653), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(666), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(668), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(670), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(672), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(676), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(677), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(680), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(683), new DateTime(2023, 5, 15, 15, 59, 0, 116, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5704), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5723), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5726), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5728), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5734), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5757), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5759), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5764), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5767), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5769), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5772), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5774), new DateTime(2023, 5, 15, 15, 59, 0, 117, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 15, 15, 59, 0, 115, DateTimeKind.Utc).AddTicks(7355), new DateTime(2023, 5, 15, 15, 59, 0, 115, DateTimeKind.Utc).AddTicks(7362), "2655CD5112027B73128542E0DF43A8CBEE93538E6150306171221C0ACA7F805E8C848D4F06FD2DA2F811E135483EFC51AC6231C4C36C1E46871C7DDCE9DD940D", new byte[] { 90, 242, 57, 242, 221, 70, 55, 207, 65, 99, 51, 186, 0, 193, 107, 171, 145, 112, 94, 186, 103, 187, 34, 45, 78, 197, 29, 167, 15, 118, 52, 26, 142, 223, 38, 154, 87, 153, 182, 152, 244, 104, 128, 159, 199, 124, 201, 184, 157, 219, 53, 142, 35, 121, 22, 189, 169, 201, 55, 189, 0, 153, 130, 178 } });
        }
    }
}
