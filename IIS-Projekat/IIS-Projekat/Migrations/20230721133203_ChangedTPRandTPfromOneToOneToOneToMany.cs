using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTPRandTPfromOneToOneToOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_TrainerId",
                table: "TrainingPlanRequests");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6392), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6419), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6422), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6426), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6428), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6433), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6435), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6438), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6444), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6446), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6449), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6452), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6455), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6461), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6464), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6466), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6470), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6473), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6475), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6477), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5303), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5325), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5395), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5398), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5401), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5403), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5406), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5408), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 7, 21, 13, 32, 3, 107, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(194), new DateTime(2023, 7, 21, 13, 32, 3, 105, DateTimeKind.Utc).AddTicks(197), "926373BE1A9080ED8B637475F57501EB9D298EC98ED1803BD1650FB590B6A7389DD5D54E78FF9219620D0706F231C50E1EBF7E9591F9F1508039028D0A8D4F3F", new byte[] { 138, 32, 107, 166, 37, 189, 9, 198, 114, 173, 5, 39, 198, 100, 217, 149, 159, 16, 210, 205, 1, 35, 152, 111, 230, 119, 133, 146, 255, 125, 24, 91, 133, 147, 113, 59, 103, 160, 109, 194, 104, 48, 163, 112, 251, 85, 225, 177, 48, 181, 177, 25, 228, 111, 180, 195, 119, 180, 2, 72, 115, 234, 96, 51 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_TrainerId",
                table: "TrainingPlanRequests",
                column: "TrainerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_TrainerId",
                table: "TrainingPlanRequests");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6046), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6049), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6062), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6065), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6067), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6072), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6075), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6084), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6086), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6094), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6101), new DateTime(2023, 7, 21, 12, 48, 11, 557, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7610), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7616), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7630), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7634), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7636), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7666), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7669), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7671), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7676), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7678), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7680), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7683), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7686), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7691), new DateTime(2023, 7, 21, 12, 48, 11, 559, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 21, 12, 48, 11, 556, DateTimeKind.Utc).AddTicks(9701), new DateTime(2023, 7, 21, 12, 48, 11, 556, DateTimeKind.Utc).AddTicks(9705), "696C8EAB25C8B6A2C6A0C7FD5DB755DD420F3ECD07797CDF8C0A0DB4C4BA3DB530BA7054BBF5A1C04A7E7E5836C636C8CD8AF7FEEB0385D1D1ADA11FFC5F8B48", new byte[] { 173, 202, 197, 235, 5, 80, 36, 153, 55, 45, 199, 1, 111, 226, 218, 156, 209, 123, 33, 254, 33, 136, 103, 25, 64, 211, 197, 40, 112, 56, 181, 43, 145, 80, 236, 6, 56, 143, 174, 120, 107, 247, 114, 89, 71, 235, 165, 161, 87, 199, 83, 96, 160, 251, 130, 110, 7, 238, 168, 92, 214, 38, 72, 142 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_TrainerId",
                table: "TrainingPlanRequests",
                column: "TrainerId",
                unique: true);
        }
    }
}
