using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ChangedMealRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NutritionPlanId",
                table: "Meals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Meals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8877), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8956), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8960), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8964), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8966), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8973), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8976), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8979), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8983), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8985), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8988), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8991), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8994), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9002), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9005), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9008), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9012), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9014), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9017), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9023), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1263), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1311), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1313), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1315), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1318), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1354), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1357), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1366), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1368), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1372), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1377), new DateTime(2023, 5, 23, 15, 33, 50, 911, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(6114), new DateTime(2023, 5, 23, 15, 33, 50, 908, DateTimeKind.Utc).AddTicks(6116), "F6C2940242E106DA8C2467EE867827018461824E5C61E9FCCB70B1D03F56EE85F4952E1D7A05175E78B47F642EAF9CBE0776F20C4921C662B220731E0530C2CF", new byte[] { 78, 122, 78, 60, 231, 251, 28, 26, 120, 100, 153, 215, 75, 72, 252, 213, 215, 148, 178, 98, 140, 224, 88, 38, 41, 64, 241, 77, 124, 213, 176, 239, 100, 85, 243, 119, 7, 122, 84, 179, 211, 159, 43, 25, 88, 107, 212, 152, 148, 38, 157, 58, 38, 226, 230, 95, 80, 245, 234, 107, 51, 173, 119, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_NutritionPlanId",
                table: "Meals",
                column: "NutritionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_NutritionPlans_NutritionPlanId",
                table: "Meals",
                column: "NutritionPlanId",
                principalTable: "NutritionPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_NutritionPlans_NutritionPlanId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_NutritionPlanId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "NutritionPlanId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Meals");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(844), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(878), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(883), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(886), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(892), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(906), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(908), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(911), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(913), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(915), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(919), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(921), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(924), new DateTime(2023, 5, 23, 15, 16, 40, 763, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8543), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8547), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8551), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8558), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8561), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8589), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8592), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8596), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8602), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8605), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8607), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8676), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 5, 23, 15, 16, 40, 764, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 23, 15, 16, 40, 762, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 5, 23, 15, 16, 40, 762, DateTimeKind.Utc).AddTicks(8478), "1885FAB4B24C5F1585F869DA809806B71819343DA73FD865EE4006A88A1BB3EE14DE6465FF251EFAC4721882169F93700DAE74D07072203990CED8B2A9C33B77", new byte[] { 0, 220, 123, 244, 86, 69, 20, 183, 187, 166, 11, 195, 218, 229, 246, 165, 38, 148, 116, 250, 112, 193, 170, 119, 33, 80, 197, 72, 222, 74, 132, 144, 101, 158, 90, 28, 224, 2, 85, 129, 7, 187, 57, 51, 89, 121, 115, 28, 144, 79, 55, 240, 0, 97, 105, 175, 60, 78, 253, 111, 120, 214, 208, 30 } });
        }
    }
}
