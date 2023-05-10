using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationshipFoodRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "FoodId",
                table: "FoodShares",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RecipeId",
                table: "FoodShares",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_FoodShares_FoodId",
                table: "FoodShares",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodShares_RecipeId",
                table: "FoodShares",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodShares_Food_FoodId",
                table: "FoodShares",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodShares_Recipe_RecipeId",
                table: "FoodShares",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodShares_Food_FoodId",
                table: "FoodShares");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodShares_Recipe_RecipeId",
                table: "FoodShares");

            migrationBuilder.DropIndex(
                name: "IX_FoodShares_FoodId",
                table: "FoodShares");

            migrationBuilder.DropIndex(
                name: "IX_FoodShares_RecipeId",
                table: "FoodShares");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "FoodShares");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "FoodShares");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(6832), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(6999), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7003), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7012), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7015), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7023), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7025), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7032), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7035), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7042), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7052), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7064), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7069), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7073), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7159), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7164), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7166), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7177), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8073), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8077), new DateTime(2023, 5, 9, 12, 39, 47, 486, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 12, 39, 47, 485, DateTimeKind.Utc).AddTicks(6418), new DateTime(2023, 5, 9, 12, 39, 47, 485, DateTimeKind.Utc).AddTicks(6420), "49C5F42DDB421F91C69B8C26F384229EAE6EE22461654329EE68AB3DBAAB9A38A05658855A638FC8DFA70E8F5A8C7664CACCD7E7A2984B491C81170619866E74", new byte[] { 200, 163, 122, 89, 29, 21, 203, 206, 99, 150, 93, 86, 123, 140, 99, 162, 75, 176, 106, 203, 5, 81, 100, 82, 177, 54, 14, 157, 23, 169, 151, 53, 150, 206, 191, 37, 234, 52, 67, 40, 110, 175, 126, 88, 235, 21, 208, 90, 199, 254, 215, 193, 231, 233, 95, 65, 140, 10, 210, 179, 166, 215, 157, 171 } });
        }
    }
}
