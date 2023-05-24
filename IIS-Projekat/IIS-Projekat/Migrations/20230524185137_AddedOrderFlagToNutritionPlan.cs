using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderFlagToNutritionPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsOrdered",
                table: "NutritionPlans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9251), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9275), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9278), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9281), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9283), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9287), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9292), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9297), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9301), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9303), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9305), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9307), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9443), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9455), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9457), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9467), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9469), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6683), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6686) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6709), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6712), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6715), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6718), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6722), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6725), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 5, 24, 18, 51, 37, 95, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(5595), new DateTime(2023, 5, 24, 18, 51, 37, 93, DateTimeKind.Utc).AddTicks(5598), "AE3821D662D044C8D6AE3098F9EBA0B20087DF866E096B7F689D11EB91CC8E46D568781C464A794F66864E55CC766108D28F63C633FDD5DC3F13BE650C6A1B85", new byte[] { 169, 33, 210, 245, 176, 187, 26, 240, 79, 53, 136, 204, 248, 106, 192, 23, 100, 193, 201, 135, 244, 79, 52, 79, 63, 115, 47, 199, 20, 67, 88, 16, 218, 224, 58, 208, 43, 227, 110, 199, 213, 214, 214, 231, 82, 137, 156, 255, 75, 169, 10, 179, 142, 92, 112, 222, 179, 179, 118, 124, 223, 73, 153, 191 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOrdered",
                table: "NutritionPlans");

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
    }
}
