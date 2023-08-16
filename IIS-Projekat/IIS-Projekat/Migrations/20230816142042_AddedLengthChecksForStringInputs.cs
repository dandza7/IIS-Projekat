using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedLengthChecksForStringInputs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingSessions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ExerciseTrainingSession",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsUnhappy",
                table: "ExerciseTrainingSession",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3645), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3648), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3652), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3654), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3658), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3661), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3663), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3665), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3670), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3672), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3675), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3677), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3680), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3690), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3693), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3696), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3699), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3702), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3704), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3707), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3709), new DateTime(2023, 8, 16, 14, 20, 41, 281, DateTimeKind.Utc).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7026), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7047), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7050), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7053), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7055), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7059), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7062), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7106), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7109), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7115), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7118), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7123), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7126), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7128), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7131), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7134), new DateTime(2023, 8, 16, 14, 20, 41, 283, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 16, 14, 20, 41, 280, DateTimeKind.Utc).AddTicks(5722), new DateTime(2023, 8, 16, 14, 20, 41, 280, DateTimeKind.Utc).AddTicks(5726), "51529E7E5CDE2AEE103BE296600E11E8EC04AC424BC89FC95C31795B090D09B44FDECDC4FDBD829335A129DE83ABBDE64E9E013D07DC6400399493B15B068CB5", new byte[] { 141, 126, 139, 37, 43, 40, 93, 147, 229, 255, 211, 94, 212, 41, 91, 0, 205, 151, 170, 51, 147, 99, 247, 208, 19, 148, 69, 0, 147, 185, 70, 63, 156, 109, 14, 245, 202, 188, 239, 198, 248, 212, 192, 102, 177, 122, 42, 174, 204, 85, 250, 14, 133, 141, 2, 241, 179, 117, 18, 142, 231, 107, 246, 44 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingSessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MuscleGroups",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "ExerciseTrainingSession",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsUnhappy",
                table: "ExerciseTrainingSession",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7113), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7172), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7185), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7203), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7224), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7227), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7231), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7239), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7262), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7273), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7383), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7399), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7405), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7409), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7419), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7429), new DateTime(2023, 8, 12, 22, 38, 50, 613, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5113), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5147), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5151), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5154), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5158), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5163), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5166), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5204), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5208), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5304), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5319), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5324), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5328), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 8, 12, 22, 38, 50, 616, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 38, 50, 612, DateTimeKind.Utc).AddTicks(7481), new DateTime(2023, 8, 12, 22, 38, 50, 612, DateTimeKind.Utc).AddTicks(7487), "C0275A319D1FD45F9A0975C1D8941A0ECB9301AC1E071E67849DADD641399382BD88156EEB86E522E0DF60D9AF2223CF2883668A9C46F9E9D697AF44F247A4FC", new byte[] { 22, 185, 53, 197, 177, 48, 227, 139, 25, 21, 92, 101, 33, 156, 85, 247, 205, 73, 78, 236, 123, 35, 111, 211, 36, 232, 156, 117, 206, 51, 184, 200, 149, 206, 52, 99, 47, 72, 246, 171, 51, 232, 123, 60, 161, 36, 166, 3, 221, 26, 36, 254, 203, 255, 41, 77, 237, 201, 105, 134, 9, 153, 95, 5 } });
        }
    }
}
