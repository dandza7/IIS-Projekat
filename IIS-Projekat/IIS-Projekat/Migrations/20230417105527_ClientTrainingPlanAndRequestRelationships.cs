using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ClientTrainingPlanAndRequestRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "TrainingPlans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ClientId",
                table: "TrainingPlanRequests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7275), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7289), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7291), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7293), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7294), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7297), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7425), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7432), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7432) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7433), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7436), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7437), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7439), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7442), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7455), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7458), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7459), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7462), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7464), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7466), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7467), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7469), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 4, 17, 10, 55, 27, 245, DateTimeKind.Utc).AddTicks(5362), "178533E0CFDB492829F7718B75275C0EB1616BF01038A06811C2075BA048A0AFD12A47A25A465B2A70543278044428D58D9D38D0F5D2CDFF4DA1586493DC9337", new byte[] { 222, 197, 107, 65, 120, 86, 18, 222, 17, 136, 181, 85, 158, 117, 212, 91, 188, 81, 61, 110, 16, 206, 161, 107, 202, 186, 139, 105, 162, 188, 193, 4, 153, 229, 117, 164, 77, 44, 156, 244, 134, 195, 70, 108, 206, 242, 173, 212, 201, 195, 85, 200, 94, 199, 193, 84, 12, 46, 48, 35, 240, 0, 118, 32 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlanRequests_Users_ClientId",
                table: "TrainingPlanRequests",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_Users_ClientId",
                table: "TrainingPlans",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlanRequests_Users_ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_Users_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2743), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2790), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2796), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2800), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2804), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2811), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2814), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2818) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2821), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2826), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2830), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2834), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3183), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3191), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3197), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3205), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 4, 16, 18, 22, 1, 956, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 4, 16, 18, 22, 1, 955, DateTimeKind.Utc).AddTicks(5673), new DateTime(2023, 4, 16, 18, 22, 1, 955, DateTimeKind.Utc).AddTicks(5679), "6BA2AEDF260918EBF87167EFF1F518DA08BE2AC944B73FC6E7DAB1C8F48CB8C85411961BC09E94B47744A3BFDDDD77AA05BC3D13A059F84F6F1391FA24EC1DF4", new byte[] { 175, 137, 204, 133, 9, 50, 72, 41, 61, 220, 6, 95, 49, 204, 113, 206, 232, 15, 130, 191, 13, 28, 75, 61, 16, 201, 70, 208, 218, 157, 68, 183, 196, 182, 206, 208, 227, 235, 2, 229, 190, 250, 115, 3, 141, 165, 15, 142, 200, 88, 113, 192, 30, 92, 95, 89, 239, 236, 37, 70, 56, 22, 190, 91 } });
        }
    }
}
