using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class BLAa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClientId",
                table: "Comments",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Articles_ArticleId",
                table: "Comments",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Articles_ArticleId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ClientId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ArticlesArticleId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientsClientId",
                table: "Comments",
                type: "int",
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
    }
}
