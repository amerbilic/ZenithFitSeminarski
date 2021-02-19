using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class bla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticlesArticleId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientsClientId",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 38, 38, 152, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 38, 38, 154, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 38, 38, 154, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 18, 38, 38, 154, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 156, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 18, 38, 38, 157, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticlesArticleId",
                table: "Comments",
                column: "ArticlesArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClientsClientId",
                table: "Comments",
                column: "ClientsClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Articles_ArticlesArticleId",
                table: "Comments",
                column: "ArticlesArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientsClientId",
                table: "Comments",
                column: "ClientsClientId",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Articles_ArticlesArticleId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientsClientId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ArticlesArticleId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ClientsClientId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ArticlesArticleId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ClientsClientId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 17, 31, 12, 310, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 17, 31, 12, 313, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 17, 31, 12, 313, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 17, 31, 12, 313, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 315, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 315, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 315, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 315, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 316, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 317, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 317, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 17, 31, 12, 317, DateTimeKind.Local).AddTicks(3587));
        }
    }
}
