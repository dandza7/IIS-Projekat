using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedNumberOfSetsForExercisePerTrainingSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfSets",
                table: "ExerciseTrainingSession",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7382), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7525), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7535), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7539), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7542), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7544), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7547), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7553), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7556), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7558), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7587), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7594), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7162), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7167), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7173), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7196), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7199), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7213), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7221), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7227), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7229), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7232), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7235), new DateTime(2023, 5, 15, 18, 55, 29, 276, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(4466), new DateTime(2023, 5, 15, 18, 55, 29, 274, DateTimeKind.Utc).AddTicks(4469), "EF9802C0BF26252260244A849922F5F2CCDA8E4F98A472DFF705BFDC1ED7F8333AA04F839043451A035A0E5B7DE3A616BBD26376B6382D1AEDC3BE30B4F7C899", new byte[] { 97, 147, 92, 18, 86, 107, 252, 97, 101, 44, 34, 125, 249, 51, 37, 146, 156, 43, 226, 107, 22, 210, 13, 228, 105, 199, 133, 146, 224, 47, 16, 247, 144, 173, 221, 151, 22, 32, 242, 215, 153, 0, 181, 139, 7, 12, 90, 212, 222, 43, 18, 141, 250, 131, 66, 237, 31, 55, 58, 9, 27, 53, 115, 189 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSets",
                table: "ExerciseTrainingSession");

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
    }
}
