using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 2, 12, 5, 937, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 2, 12, 5, 939, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 2, 12, 5, 939, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 2, 12, 5, 939, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 940, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                columns: new[] { "ArticleID", "RatingDate" },
                values: new object[] { 1, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                columns: new[] { "ArticleID", "RatingDate", "RatingGrade" },
                values: new object[] { 1, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5332), 3 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingID", "ArticleID", "ClientID", "RatingDate", "RatingGrade" },
                values: new object[,]
                {
                    { 14, 4, 2, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5365), 4 },
                    { 13, 4, 1, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5362), 3 },
                    { 12, 3, 4, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5359), 3 },
                    { 11, 3, 3, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5355), 3 },
                    { 10, 3, 2, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5352), 3 },
                    { 9, 3, 1, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5349), 3 },
                    { 8, 2, 4, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5345), 3 },
                    { 7, 2, 3, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5342), 3 },
                    { 6, 2, 2, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5339), 3 },
                    { 5, 2, 1, new DateTime(2021, 2, 9, 2, 12, 5, 941, DateTimeKind.Local).AddTicks(5335), 3 }
                });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 942, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 942, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 2, 12, 5, 942, DateTimeKind.Local).AddTicks(2278));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 1, 29, 27, 519, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 1, 29, 27, 522, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 1, 29, 27, 522, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 1, 29, 27, 522, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 523, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 523, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 523, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 523, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 523, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                columns: new[] { "ArticleID", "RatingDate" },
                values: new object[] { 2, new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                columns: new[] { "ArticleID", "RatingDate", "RatingGrade" },
                values: new object[] { 3, new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(808), 2 });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 1, 29, 27, 524, DateTimeKind.Local).AddTicks(7528));
        }
    }
}
