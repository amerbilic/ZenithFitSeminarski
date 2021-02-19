using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CommentDate",
                table: "Comments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 20, 22, 22, 771, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 20, 22, 22, 774, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 20, 22, 22, 774, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 20, 22, 22, 774, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 776, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 20, 22, 22, 777, DateTimeKind.Local).AddTicks(4464));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentDate",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 40, 20, 912, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 40, 20, 914, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 40, 20, 914, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 40, 20, 914, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 916, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 917, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 917, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 40, 20, 917, DateTimeKind.Local).AddTicks(3016));
        }
    }
}
