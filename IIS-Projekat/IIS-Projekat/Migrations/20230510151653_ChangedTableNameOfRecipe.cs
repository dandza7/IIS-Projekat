using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTableNameOfRecipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodShares_Recipe_RecipeId",
                table: "FoodShares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe");

            migrationBuilder.RenameTable(
                name: "Recipe",
                newName: "Recipes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9231), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9250), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9253), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9255), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9257), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9259), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9262), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9264), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9265), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9268), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9341), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9346), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9348), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9350), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9364), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9367), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9369), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9373), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9375), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9378), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9384), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(5432), new DateTime(2023, 5, 10, 15, 16, 52, 742, DateTimeKind.Utc).AddTicks(5435), "4BA01E3A96B704C659132B2D2479476D57EDA6E2AF91A9A5A0DC4BF8BCE32D43E310F24B9D0689C74B926F7575B5C5EF0FB00D0BBBC4D7E16FFEED1C19CB0B16", new byte[] { 78, 59, 160, 166, 13, 196, 172, 179, 65, 183, 207, 146, 181, 102, 74, 191, 177, 102, 166, 51, 152, 102, 190, 204, 252, 92, 38, 25, 184, 216, 51, 201, 65, 253, 60, 84, 212, 249, 4, 187, 58, 247, 94, 105, 183, 28, 234, 173, 118, 194, 208, 252, 139, 80, 111, 65, 125, 217, 70, 80, 154, 117, 229, 143 } });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodShares_Recipes_RecipeId",
                table: "FoodShares",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodShares_Recipes_RecipeId",
                table: "FoodShares");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "Recipe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipe",
                table: "Recipe",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(278), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(300), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(302), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(305), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(308), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(310), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(312), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(319), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(321), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(323), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(328), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(550), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(556), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(563), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(567), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(569), new DateTime(2023, 5, 10, 15, 15, 23, 802, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 10, 15, 15, 23, 801, DateTimeKind.Utc).AddTicks(5966), new DateTime(2023, 5, 10, 15, 15, 23, 801, DateTimeKind.Utc).AddTicks(5969), "9C452F7CF57A46F730DFB7675DBF519E038D2497B05CD6F50D01D1DAC270A49C87A44AEDA56B7CFC5890D52537BB48E8808D6533828590CAE8E09CC31D7654B7", new byte[] { 97, 14, 142, 151, 215, 103, 237, 106, 111, 7, 105, 199, 228, 167, 233, 153, 16, 178, 252, 159, 25, 182, 96, 145, 133, 28, 140, 242, 48, 173, 249, 223, 198, 8, 97, 134, 43, 220, 233, 54, 105, 241, 15, 251, 164, 94, 42, 175, 234, 217, 197, 140, 58, 11, 51, 71, 88, 139, 159, 198, 247, 211, 5, 43 } });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodShares_Recipe_RecipeId",
                table: "FoodShares",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
