using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ChangedEmailValidationToO2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmailValidations_UserId",
                table: "EmailValidations");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6577), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6592), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6594), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6596), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6599), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6601), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6666), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6667) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6668), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6672), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6673), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6675), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6677), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6679), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6689), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6691), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6693), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6696), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6698), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6702), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6703), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1594), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1599), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1622), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1627), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1631), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1633), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1635), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1637), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1639), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1643), new DateTime(2023, 8, 28, 19, 58, 24, 193, DateTimeKind.Utc).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(1641), new DateTime(2023, 8, 28, 19, 58, 24, 191, DateTimeKind.Utc).AddTicks(1645), "6487F02AF34A4C58C2B6A0576D06E3A2A91653F53B8ADA85A7121CDA35AF143892177BD390962858DF45AD677729699762FBD8189C16E7D863B9577E1A1F2926", new byte[] { 103, 13, 2, 103, 167, 156, 148, 139, 199, 192, 91, 219, 151, 22, 28, 97, 75, 126, 16, 99, 219, 21, 10, 7, 52, 223, 203, 113, 65, 186, 127, 34, 228, 151, 47, 6, 59, 27, 18, 119, 12, 49, 136, 249, 162, 16, 198, 28, 236, 81, 137, 201, 26, 48, 223, 132, 193, 49, 183, 188, 43, 217, 81, 24 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailValidations_UserId",
                table: "EmailValidations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmailValidations_UserId",
                table: "EmailValidations");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5284), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5302), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5305), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5307), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5309), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5313), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5315), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5317), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5320), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5323), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5323) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5328), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5330), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5332), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5348), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5351), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5422), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5426), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5430), new DateTime(2023, 8, 20, 13, 49, 12, 426, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3106), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3109), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3111), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3114), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3207), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3216), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3218), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3223), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3226), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3229), new DateTime(2023, 8, 20, 13, 49, 12, 428, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 8, 20, 13, 49, 12, 425, DateTimeKind.Utc).AddTicks(9895), new DateTime(2023, 8, 20, 13, 49, 12, 425, DateTimeKind.Utc).AddTicks(9898), "0D433DB7A30B0F30E4E3B3F842227F560BF75E57FE39AACF3458F85CD94B86DB7023C81EE729D2AC2EC7DEAC7058C6B3AC77CF1F5C364F7BF07807AC153E3893", new byte[] { 173, 3, 255, 226, 116, 113, 18, 141, 175, 19, 228, 168, 231, 228, 88, 220, 205, 228, 130, 158, 46, 252, 232, 115, 144, 60, 60, 190, 132, 200, 141, 129, 79, 77, 127, 21, 89, 211, 89, 103, 158, 103, 185, 242, 4, 180, 141, 117, 172, 184, 210, 223, 84, 20, 124, 71, 160, 205, 246, 157, 101, 196, 161, 20 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailValidations_UserId",
                table: "EmailValidations",
                column: "UserId",
                unique: true);
        }
    }
}
