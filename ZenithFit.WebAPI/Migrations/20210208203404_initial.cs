using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__19093A2B0E46F8E4", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFirstName = table.Column<string>(maxLength: 100, nullable: true),
                    ClientLastName = table.Column<string>(maxLength: 100, nullable: true),
                    ClientRegisterDate = table.Column<DateTime>(nullable: false),
                    ClientEmail = table.Column<string>(maxLength: 100, nullable: true),
                    ClientPhone = table.Column<string>(maxLength: 100, nullable: true),
                    ClientUsername = table.Column<string>(maxLength: 30, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 200, nullable: true),
                    PasswordSalt = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clients__E67E1A044D08DA90", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Manufact__357E5CA1584EC634", x => x.ManufacturerID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: true),
                    RoleNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__8AFACE3A32FDA6D3", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierContact = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierAddress = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierPhone = table.Column<string>(maxLength: 30, nullable: true),
                    SupplierWeb = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierEmail = table.Column<string>(maxLength: 30, nullable: true),
                    SupplierBankAccount = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierNote = table.Column<string>(nullable: true),
                    SupplierStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Supplier__4BE66694FF6CCDB0", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(maxLength: 100, nullable: true),
                    UserLastName = table.Column<string>(maxLength: 100, nullable: true),
                    UserEmail = table.Column<string>(maxLength: 50, nullable: true),
                    UserPhone = table.Column<string>(maxLength: 100, nullable: true),
                    UserUsername = table.Column<string>(maxLength: 30, nullable: true),
                    PasswordHash = table.Column<string>(maxLength: 200, nullable: true),
                    PasswordSalt = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC54B38ACA", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseName = table.Column<string>(maxLength: 200, nullable: true),
                    WarehouseAddress = table.Column<string>(maxLength: 200, nullable: true),
                    WarehouseNote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Warehous__2608AFD92D3BBDD6", x => x.WarehouseID);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    RequestTitle = table.Column<string>(maxLength: 100, nullable: true),
                    RequestDescription = table.Column<string>(maxLength: 200, nullable: true),
                    ClientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Requests__33A8519A648FA1C5", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK__Requests__Client__44FF419A",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(maxLength: 100, nullable: true),
                    ArticleCode = table.Column<string>(nullable: true),
                    ArticlePrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    ArticlePicture = table.Column<byte[]>(nullable: true),
                    ArticlePictureThumb = table.Column<byte[]>(nullable: true),
                    ArticleStatus = table.Column<bool>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    ManufacturerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Articles__9C6270C826A134A7", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK__Articles__Catego__4E88ABD4",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Articles__Manufa__4D94879B",
                        column: x => x.ManufacturerID,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    NoticeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoticeTitle = table.Column<string>(maxLength: 100, nullable: true),
                    NoticeText = table.Column<string>(nullable: true),
                    NoticeImage = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notices__CE83CB858F8BDC96", x => x.NoticeID);
                    table.ForeignKey(
                        name: "FK__Notices__UserID__3C69FB99",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    ChangeDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRole__3D978A55393233A9", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK__UserRoles__RoleI__52593CB8",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__UserRoles__Chang__5165187F",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(maxLength: 100, nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderStatus = table.Column<bool>(nullable: false),
                    OrderCancelled = table.Column<bool>(nullable: true),
                    OrderPriceNoTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    OrderPriceTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    WarehouseID = table.Column<int>(nullable: false),
                    ClientID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__C3905BAF4AE8A624", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK__Orders__ClientID__628FA481",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Orders__UserID__6383C8BA",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Orders__Warehous__619B8048",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procurements",
                columns: table => new
                {
                    ProcurementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcurementNumber = table.Column<string>(maxLength: 100, nullable: true),
                    ProcurementDate = table.Column<DateTime>(nullable: false),
                    ProcurementAccountAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProcurementTax = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ProcurementNote = table.Column<string>(maxLength: 500, nullable: true),
                    WarehouseID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    SupplierID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Procurem__95B4518CAA2BF8FB", x => x.ProcurementID);
                    table.ForeignKey(
                        name: "FK__Procureme__Suppl__5AEE82B9",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Procureme__UserI__59FA5E80",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Procureme__Wareh__59063A47",
                        column: x => x.WarehouseID,
                        principalTable: "Warehouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestDetails",
                columns: table => new
                {
                    RequestDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestResponse = table.Column<string>(nullable: true),
                    RequestID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestDetails", x => x.RequestDetailsID);
                    table.ForeignKey(
                        name: "FK__RequestDe__Reque__47DBAE45",
                        column: x => x.RequestID,
                        principalTable: "Requests",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__RequestDe__UserI__48CFD27E",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    ArticleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsID);
                    table.ForeignKey(
                        name: "FK__OrderDeta__Artic__66603565",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    RatingDate = table.Column<DateTime>(nullable: false),
                    RatingGrade = table.Column<int>(nullable: false),
                    ArticleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ratings__FCCDF85CE0628B79", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK__Ratings__Article__5629CD9C",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Ratings__ClientI__5535A963",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompleteOrder",
                columns: table => new
                {
                    CompleteOrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    CompleteOrderDate = table.Column<DateTime>(nullable: false),
                    CompleteOrderSent = table.Column<bool>(nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompleteOrder", x => x.CompleteOrderID);
                    table.ForeignKey(
                        name: "FK__CompleteO__Clien__693CA210",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CompleteO__Order__6B24EA82",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__CompleteO__UserI__6A30C649",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementDetails",
                columns: table => new
                {
                    ProcurementDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcurementID = table.Column<int>(nullable: false),
                    ArticleID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Procurem__67666710DC9D5C2B", x => x.ProcurementDetailID);
                    table.ForeignKey(
                        name: "FK__Procureme__Artic__5EBF139D",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Procureme__Procu__5DCAEF64",
                        column: x => x.ProcurementID,
                        principalTable: "Procurements",
                        principalColumn: "ProcurementID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryID",
                table: "Articles",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ManufacturerID",
                table: "Articles",
                column: "ManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_CompleteOrder_ClientID",
                table: "CompleteOrder",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_CompleteOrder_OrderID",
                table: "CompleteOrder",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_CompleteOrder_UserID",
                table: "CompleteOrder",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notices_UserID",
                table: "Notices",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ArticleID",
                table: "OrderDetails",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientID",
                table: "Orders",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WarehouseID",
                table: "Orders",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementDetails_ArticleID",
                table: "ProcurementDetails",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementDetails_ProcurementID",
                table: "ProcurementDetails",
                column: "ProcurementID");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_SupplierID",
                table: "Procurements",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_UserID",
                table: "Procurements",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Procurements_WarehouseID",
                table: "Procurements",
                column: "WarehouseID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ArticleID",
                table: "Ratings",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ClientID",
                table: "Ratings",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestDetails_RequestID",
                table: "RequestDetails",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestDetails_UserID",
                table: "RequestDetails",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ClientID",
                table: "Requests",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompleteOrder");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProcurementDetails");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "RequestDetails");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Procurements");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
