using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipFoodNutrition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FoodId",
                table: "NutritionShares",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "NutritionId",
                table: "NutritionShares",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7550), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7599), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7604), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7771), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7775), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 5, 9, 13, 36, 21, 255, DateTimeKind.Utc).AddTicks(2992), "392E335497D18ABDEBB5A42353A2BE45EF563AA6191A925B653C3E20E2651B890D3876C1590597618734EA3591D20C8738337C0E69088BE94391EDAD54144229", new byte[] { 81, 161, 48, 168, 102, 11, 201, 79, 95, 221, 106, 64, 39, 80, 153, 76, 205, 146, 28, 93, 228, 115, 193, 121, 165, 5, 63, 89, 181, 6, 98, 58, 30, 35, 1, 112, 183, 64, 90, 60, 185, 170, 182, 83, 16, 205, 30, 108, 135, 255, 251, 32, 69, 25, 31, 7, 93, 140, 23, 133, 193, 65, 158, 202 } });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionShares_FoodId",
                table: "NutritionShares",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionShares_NutritionId",
                table: "NutritionShares",
                column: "NutritionId");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionShares_Food_FoodId",
                table: "NutritionShares",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionShares_Nutritions_NutritionId",
                table: "NutritionShares",
                column: "NutritionId",
                principalTable: "Nutritions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionShares_Food_FoodId",
                table: "NutritionShares");

            migrationBuilder.DropForeignKey(
                name: "FK_NutritionShares_Nutritions_NutritionId",
                table: "NutritionShares");

            migrationBuilder.DropIndex(
                name: "IX_NutritionShares_FoodId",
                table: "NutritionShares");

            migrationBuilder.DropIndex(
                name: "IX_NutritionShares_NutritionId",
                table: "NutritionShares");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "NutritionShares");

            migrationBuilder.DropColumn(
                name: "NutritionId",
                table: "NutritionShares");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7136), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7160), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7165), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7167), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7171), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7173), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7175), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7176), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7181), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7184), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7186), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7188), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7240), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7247), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7249), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7251), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7253), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7255), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(3541), new DateTime(2023, 5, 9, 13, 29, 16, 880, DateTimeKind.Utc).AddTicks(3547), "D8C91A426E2B70B8D9FD3C79D06F736754307FA775B64BE3E8BB3E184DEE7743060CC400AF0BB51864C74E4CB81616A770C80D73B8183F316A27651A0AE3986C", new byte[] { 68, 150, 16, 140, 4, 98, 244, 71, 221, 66, 209, 84, 139, 164, 112, 213, 245, 71, 54, 150, 137, 247, 19, 192, 163, 101, 135, 44, 33, 56, 88, 159, 208, 171, 195, 200, 163, 69, 147, 137, 47, 220, 54, 56, 216, 241, 10, 11, 88, 230, 85, 109, 243, 20, 98, 244, 171, 34, 50, 168, 183, 209, 146, 229 } });
        }
    }
}
