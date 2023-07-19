using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class UsersProfileToNotificationsO2M : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEmailSubscribed",
                table: "Profiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecieverId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Profiles_RecieverId",
                        column: x => x.RecieverId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5623), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5626), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5628), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5633), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5635), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5638), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5643), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5645), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5647), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5649), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5657), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5659), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5665), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5667), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5669), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9745), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9762), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9764), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9768), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9794), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9796), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9798), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9802), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9804), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9806), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9811), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9874), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(229), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(232), "F26F38DD5EC1B0B0CAEF964BDF4C72EDA989CC28DE2F45A2D2B80BBA62DEB1C3E3572FA29CA62F4D26D368805FA46F87C92BF342EB2BAB109181F9F36B347EF8", new byte[] { 18, 100, 177, 99, 216, 246, 225, 13, 38, 36, 194, 46, 132, 112, 205, 112, 155, 3, 129, 167, 84, 99, 56, 46, 27, 76, 204, 240, 43, 225, 12, 114, 42, 205, 137, 109, 66, 134, 238, 46, 236, 247, 142, 54, 31, 4, 251, 60, 12, 156, 49, 210, 164, 207, 180, 147, 216, 220, 198, 32, 240, 207, 161, 164 } });

            migrationBuilder.CreateIndex(
                name: "IX_Notification_RecieverId",
                table: "Notification",
                column: "RecieverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropColumn(
                name: "IsEmailSubscribed",
                table: "Profiles");

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
    }
}
