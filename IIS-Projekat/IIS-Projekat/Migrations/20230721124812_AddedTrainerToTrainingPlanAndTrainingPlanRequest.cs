using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedTrainerToTrainingPlanAndTrainingPlanRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans");

            migrationBuilder.DropIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests");

            migrationBuilder.AddColumn<long>(
                name: "TrainerId",
                table: "TrainingPlans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TrainerId",
                table: "TrainingPlanRequests",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlanRequests_Users_TrainerId",
                table: "TrainingPlanRequests",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPlans_Users_TrainerId",
                table: "TrainingPlans",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlanRequests_Users_TrainerId",
                table: "TrainingPlanRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPlans_Users_TrainerId",
                table: "TrainingPlans");

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

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainingPlans");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "TrainingPlanRequests");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1072), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1091), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1096), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1102), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1105), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1107), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1108), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1110), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1112), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1122), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1128), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1132), new DateTime(2023, 7, 21, 11, 19, 16, 336, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1809), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1825), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1871), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1881), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1888), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1890), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1896), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1901), new DateTime(2023, 7, 21, 11, 19, 16, 337, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 21, 11, 19, 16, 335, DateTimeKind.Utc).AddTicks(6692), new DateTime(2023, 7, 21, 11, 19, 16, 335, DateTimeKind.Utc).AddTicks(6696), "3426D8450A378DF1BD1DD0DAF318942E026F27DD838665D028C05E74B2DEAA631D3833B59040D273C78781D2F2215EBDDBD689B6199F93E23B43FF685BED2B71", new byte[] { 118, 210, 21, 198, 255, 232, 220, 122, 130, 183, 241, 71, 188, 60, 45, 102, 157, 170, 35, 54, 93, 84, 219, 174, 93, 73, 234, 6, 118, 123, 90, 94, 42, 249, 11, 235, 164, 10, 126, 3, 28, 125, 126, 43, 216, 163, 6, 222, 53, 87, 132, 47, 57, 150, 191, 1, 123, 245, 3, 155, 14, 42, 87, 221 } });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlans_ClientId",
                table: "TrainingPlans",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingPlanRequests_ClientId",
                table: "TrainingPlanRequests",
                column: "ClientId");
        }
    }
}
