using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class Comments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 13, 6, 1, 101, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 13, 6, 1, 104, DateTimeKind.Local).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 13, 6, 1, 104, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 14, 13, 6, 1, 104, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 106, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 19, 13, 6, 1, 107, DateTimeKind.Local).AddTicks(4215));
        }
    }
}
