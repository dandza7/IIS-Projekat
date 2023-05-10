using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class NewModelsWithoutRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beginning = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ending = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodShares",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Share = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodShares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Injuries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjurySeverity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injuries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anamnesis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Therapy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutritions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutritions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NutritionShares",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Share = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionShares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergies");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "FoodShares");

            migrationBuilder.DropTable(
                name: "Injuries");

            migrationBuilder.DropTable(
                name: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "Nutritions");

            migrationBuilder.DropTable(
                name: "NutritionShares");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7934), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7949), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7951), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7952), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7955), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7961), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7964), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7966), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7968), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7979), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7981), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7986), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7998), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(5954), new DateTime(2023, 5, 9, 9, 29, 35, 691, DateTimeKind.Utc).AddTicks(5957), "8F301F3F1E4DA991379E85E504C15EA8B591671C54889D396844F32460BDBA3FD6BC4AD1EDF43A2B7F589E1ACA80830AC0B18418BE65E6A39DD9BB43BE25B49F", new byte[] { 20, 43, 234, 119, 196, 24, 11, 103, 183, 201, 52, 120, 33, 115, 251, 88, 142, 241, 183, 46, 199, 168, 45, 133, 36, 103, 254, 61, 239, 246, 31, 106, 56, 192, 135, 6, 148, 202, 42, 59, 213, 59, 6, 118, 113, 140, 92, 148, 96, 21, 201, 237, 229, 19, 90, 119, 236, 200, 39, 152, 175, 89, 47, 170 } });
        }
    }
}
