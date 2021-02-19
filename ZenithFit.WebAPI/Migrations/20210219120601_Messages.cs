using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class Messages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Sender = table.Column<bool>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ClientId",
                table: "Messages",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 1,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 17, 51, 0, 587, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 2,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 17, 51, 0, 589, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 3,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 17, 51, 0, 589, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "ClientID",
                keyValue: 4,
                column: "ClientRegisterDate",
                value: new DateTime(2021, 2, 4, 17, 51, 0, 589, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 1,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 2,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 3,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "CompleteOrder",
                keyColumn: "CompleteOrderID",
                keyValue: 4,
                column: "CompleteOrderDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 1,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 2,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 3,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Procurements",
                keyColumn: "ProcurementID",
                keyValue: 4,
                column: "ProcurementDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14,
                column: "RatingDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 591, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3,
                column: "ChangeDate",
                value: new DateTime(2021, 2, 9, 17, 51, 0, 592, DateTimeKind.Local).AddTicks(5419));
        }
    }
}
