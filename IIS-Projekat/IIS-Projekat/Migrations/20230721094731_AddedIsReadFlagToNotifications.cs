using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IISProjekat.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsReadFlagToNotifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Profiles_RecieverId",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_RecieverId",
                table: "Notifications",
                newName: "IX_Notifications_RecieverId");

            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6718), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6732), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6735), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6737), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6738), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6741), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6743), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6744), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6746), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6749), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6750), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6753), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6755), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6759), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6763), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6767), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6772), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7470), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7482), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7484), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7486), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7488), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7490), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7492), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7518), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7520), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7523), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7581), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7590), new DateTime(2023, 7, 21, 9, 47, 30, 589, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(2673), new DateTime(2023, 7, 21, 9, 47, 30, 588, DateTimeKind.Utc).AddTicks(2676), "2992369D819AD2781BB9951F2E007CA7E3277A677919539C9DE91A882E31572AE34A5181B51E7AB171866A5A16957A5AB8463CE6E19D315AD57433E4D412FCE5", new byte[] { 235, 214, 82, 114, 238, 106, 68, 250, 27, 247, 43, 87, 29, 79, 205, 214, 103, 15, 125, 174, 217, 48, 246, 45, 155, 242, 113, 12, 5, 60, 129, 58, 51, 0, 190, 136, 223, 121, 138, 165, 46, 230, 7, 168, 139, 130, 163, 75, 15, 85, 27, 78, 148, 109, 186, 144, 140, 208, 89, 167, 157, 113, 88, 194 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Profiles_RecieverId",
                table: "Notifications",
                column: "RecieverId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Profiles_RecieverId",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Notifications");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_RecieverId",
                table: "Notification",
                newName: "IX_Notification_RecieverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5605), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5623), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5626), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5628), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5633), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5635), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5636), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5638), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5641), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5643), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5645), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5647), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5649), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5657), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5659), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5665), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5667), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5669), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9745), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9762), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9764), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9768), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9794), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9796), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9798), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9802), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9804), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9806), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9811), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Nutrients",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9874), new DateTime(2023, 7, 19, 17, 35, 10, 416, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password", "Salt" },
                values: new object[] { new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(229), new DateTime(2023, 7, 19, 17, 35, 10, 415, DateTimeKind.Utc).AddTicks(232), "F26F38DD5EC1B0B0CAEF964BDF4C72EDA989CC28DE2F45A2D2B80BBA62DEB1C3E3572FA29CA62F4D26D368805FA46F87C92BF342EB2BAB109181F9F36B347EF8", new byte[] { 18, 100, 177, 99, 216, 246, 225, 13, 38, 36, 194, 46, 132, 112, 205, 112, 155, 3, 129, 167, 84, 99, 56, 46, 27, 76, 204, 240, 43, 225, 12, 114, 42, 205, 137, 109, 66, 134, 238, 46, 236, 247, 142, 54, 31, 4, 251, 60, 12, 156, 49, 210, 164, 207, 180, 147, 216, 220, 198, 32, 240, 207, 161, 164 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Profiles_RecieverId",
                table: "Notification",
                column: "RecieverId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
