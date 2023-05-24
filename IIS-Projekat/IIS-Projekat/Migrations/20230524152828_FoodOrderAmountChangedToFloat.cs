using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class FoodOrderAmountChangedToFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "FoodOrders",
                type: "real",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7631), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7655), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7663), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7665), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7667), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7671), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7676), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7748), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7757), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7760), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7762), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7764), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7767), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7778), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7784), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7790), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7797), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7805), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7807), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7809), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7811), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5932), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5935), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5948), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5982), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5986), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6006), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6029), new DateTime(2023, 5, 24, 15, 28, 28, 269, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(3930), new DateTime(2023, 5, 24, 15, 28, 28, 267, DateTimeKind.Utc).AddTicks(3936), "378CE3EC5C835B52245062A8B802A1BA762E5506CD2FB4263B6178763E7672180B13600403D5E6B40E79572E58D94BC63CA82313973FE456726D2C768D3334F9", new byte[] { 245, 7, 129, 48, 218, 2, 165, 251, 173, 198, 157, 103, 198, 110, 236, 171, 206, 0, 54, 28, 33, 123, 139, 59, 65, 187, 3, 72, 12, 117, 81, 150, 179, 122, 9, 32, 60, 70, 166, 245, 19, 237, 127, 60, 220, 134, 211, 77, 45, 112, 114, 102, 167, 220, 178, 211, 125, 77, 156, 56, 13, 3, 171, 243 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Amount",
                table: "FoodOrders",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4956), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4968), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4971), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4973), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4975), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4978), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4979), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4981), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4983), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4985), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4987), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4992), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4994), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5008), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5011), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5013), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5015), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5020), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5022), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5598), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5621), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5624), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5626), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5627), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5632), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5666), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5669), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5672), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5674), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5681), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5683), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5685), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5686), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5688), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5691), new DateTime(2023, 5, 24, 11, 3, 45, 556, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(1902), new DateTime(2023, 5, 24, 11, 3, 45, 554, DateTimeKind.Utc).AddTicks(1905), "9AE63DCE460FCABB3EC7B6CB99B0E1CE95BABA2ECDB43448FEB3D64C9799B250EC4BE76E1B04E9B2DA1E0BE0C5C317E602A3FC47CEF0236D4E57E0A310CB6265", new byte[] { 78, 149, 48, 162, 226, 167, 120, 42, 2, 178, 50, 146, 137, 231, 23, 238, 77, 201, 23, 28, 147, 205, 27, 62, 164, 124, 175, 150, 39, 220, 218, 56, 116, 14, 181, 204, 225, 162, 36, 187, 194, 185, 240, 103, 59, 189, 119, 249, 114, 199, 161, 152, 110, 240, 80, 234, 52, 62, 173, 74, 105, 16, 19, 236 } });
        }
    }
}
