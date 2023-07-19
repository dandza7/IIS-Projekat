using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedNoteColumnForExerciseFlagging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "ExerciseTrainingSession",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5022), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5037), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5039), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5041), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5042) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5043), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5047), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5049), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5051), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5053), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5055), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5058), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5062), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5064), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5070), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5072), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5074), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5078), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5082), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5084), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5087), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5089), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9966), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9983), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9986), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9988), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9991), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9994), new DateTime(2023, 7, 19, 12, 43, 27, 779, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(36), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(44), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(47), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(49), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(52), new DateTime(2023, 7, 19, 12, 43, 27, 780, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 7, 19, 12, 43, 27, 778, DateTimeKind.Utc).AddTicks(2056), "D886519F680818BC0728576C91D043730A480E9A61DFD9C68A7322FDF4FC125BBB59970339AB7677834DB2F111685915886C6EDB523517A03A6538CCC9F074C8", new byte[] { 3, 10, 62, 148, 106, 8, 107, 159, 70, 178, 68, 121, 72, 144, 141, 117, 70, 63, 18, 233, 84, 110, 183, 40, 116, 148, 179, 14, 7, 89, 52, 7, 33, 156, 239, 86, 39, 227, 154, 158, 16, 187, 56, 133, 106, 149, 220, 212, 97, 135, 116, 13, 122, 138, 24, 129, 155, 211, 161, 190, 123, 104, 53, 231 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "ExerciseTrainingSession");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(980), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(986), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(990), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(993), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1005), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1008), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1037), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1040), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1044), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1047), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1049), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1052), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1055), new DateTime(2023, 7, 19, 10, 39, 53, 636, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7307), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7324), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7331), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7333), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7338), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7340), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7370), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7373), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7377), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7380), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7386), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7388), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7391), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7394), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7397), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7400), new DateTime(2023, 7, 19, 10, 39, 53, 637, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 19, 10, 39, 53, 635, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 7, 19, 10, 39, 53, 635, DateTimeKind.Utc).AddTicks(7889), "9C44E431E9E910E8F8088C580A5C26B60E01557AE6357273063C7970BB93A0F9356E680C39365C28FE906CDD5734B8967ED7186173AFC8B96A397622280DC2DE", new byte[] { 98, 109, 91, 102, 132, 167, 111, 196, 75, 11, 41, 64, 255, 209, 214, 233, 229, 45, 74, 45, 34, 106, 14, 204, 254, 182, 202, 118, 194, 208, 31, 239, 232, 233, 23, 21, 61, 137, 170, 179, 95, 237, 201, 58, 118, 64, 9, 193, 247, 242, 220, 77, 110, 95, 15, 163, 109, 193, 226, 83, 224, 194, 83, 61 } });
        }
    }
}
