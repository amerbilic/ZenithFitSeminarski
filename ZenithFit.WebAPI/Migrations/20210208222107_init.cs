using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZenithFit.WebAPI.Migrations
{
    public partial class init : Migration
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Proteini" },
                    { 2, "WeightGainer" },
                    { 3, "Pre-workout" },
                    { 4, "Fat-burner" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientID", "ClientEmail", "ClientFirstName", "ClientLastName", "ClientPhone", "ClientRegisterDate", "ClientUsername", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { 1, "testing1@email.com", "Amer", "Bilic", "1233455", new DateTime(2021, 2, 3, 23, 21, 6, 895, DateTimeKind.Local).AddTicks(6055), "mobile", "qEkPhwY9P2FiDqx1Rgg26GoapxE=", "fVZy3b4Z1cvYNep/oXc7aA==" },
                    { 2, "testing2@email.com", "Denis", "Bajrektarevic", "312314", new DateTime(2021, 2, 3, 23, 21, 6, 898, DateTimeKind.Local).AddTicks(2302), "hajfo", "r577PsUb6lkHEs32NUsQHbqEhqc=", "jpiaSiCqXBnw1z4lUnuRww==" },
                    { 3, "testing3@email.com", "Ajdin", "Muftic", "4133211", new DateTime(2021, 2, 3, 23, 21, 6, 898, DateTimeKind.Local).AddTicks(2397), "zake123", "ZnhzTGY3bXxC4FoYf7FEzHB+w/c=", "hx1Yw2OJcF/dQGfUKNhQgg==" },
                    { 4, "testing4@email.com", "Beze", "Kaljic", "5141231", new DateTime(2021, 2, 3, 23, 21, 6, 898, DateTimeKind.Local).AddTicks(2405), "tarke321", "r577PsUb6lkHEs32NUsQHbqEhqc=", "jpiaSiCqXBnw1z4lUnuRww==" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerID", "ManufacturerName" },
                values: new object[,]
                {
                    { 1, "Olymp" },
                    { 2, "MyProtein" },
                    { 3, "IronMaxx" },
                    { 4, "RedWeiller" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName", "RoleNote" },
                values: new object[,]
                {
                    { 2, "Employee", "Employee" },
                    { 1, "Admin", "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "SupplierAddress", "SupplierBankAccount", "SupplierContact", "SupplierEmail", "SupplierName", "SupplierNote", "SupplierPhone", "SupplierStatus", "SupplierWeb" },
                values: new object[,]
                {
                    { 1, "Random address", "12315125", "supcontact", "supplier1@email.com", "Supplier", "He is a supplier", "12312541", true, "www.supplier.com" },
                    { 2, "Random address2", "123151254", "supcontact2", "supplier2@email.com", "Supplier2", "He is a supplier", "123125412", true, "www.supplier2.com" },
                    { 3, "Random address3", "123151251", "supcontact3", "supplier3@email.com", "Supplier3", "He is a supplier", "123125413", true, "www.supplier22.com" },
                    { 4, "Random address4", "123151252", "supcontact4", "supplier4@email.com", "Supplier4", "He is a supplier", "123125414", true, "www.supplier222.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "PasswordHash", "PasswordSalt", "UserEmail", "UserFirstName", "UserLastName", "UserPhone", "UserUsername" },
                values: new object[,]
                {
                    { 1, "qEkPhwY9P2FiDqx1Rgg26GoapxE=", "fVZy3b4Z1cvYNep/oXc7aA==", "testing33@email.com", "Amer", "Hajfic", "3213215", "admin" },
                    { 2, "qEkPhwY9P2FiDqx12gg26GoapxE=", "fVZy3b4Z1cvYNep/oXc7dA==", "testing333@email.com", "Denis", "Beso", "32132154", "denje" },
                    { 3, "qEkPhwY9P2FiDqx17gg26GoapxE=", "fVZy3b4Z1cvYNep/oXc7wA==", "testing343@email.com", "Imad", "Spahic", "32132157", "samar" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName", "WarehouseNote" },
                values: new object[,]
                {
                    { 1, "Address1", "Warehouse1", "This is a note" },
                    { 2, "Address1", "Warehouse2", "This is a note" },
                    { 3, "Address3", "Pre-Warehouse3", "This is a note" },
                    { 4, "Address4", "Fat-Warehouse4", "This is a note" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleID", "ArticleCode", "ArticleName", "ArticlePicture", "ArticlePictureThumb", "ArticlePrice", "ArticleStatus", "CategoryID", "ManufacturerID" },
                values: new object[,]
                {
                    { 1, "2314", "Protein1", null, null, 300m, true, 1, 1 },
                    { 2, "2312541", "Protein2", null, null, 321m, true, 1, 1 },
                    { 3, "42312", "Weight3", null, null, 232m, true, 2, 2 },
                    { 4, "23121", "Weight2", null, null, 664m, true, 2, 2 },
                    { 5, "5675", "Random3", null, null, 213m, true, 3, 2 },
                    { 6, "756543", "Item7", null, null, 421m, true, 3, 3 },
                    { 7, "123115", "Something3", null, null, 122m, true, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "ClientID", "OrderCancelled", "OrderDate", "OrderNumber", "OrderPriceNoTax", "OrderPriceTax", "OrderStatus", "UserID", "WarehouseID" },
                values: new object[,]
                {
                    { 4, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N00-212315463", 777m, 999m, true, 1, 3 },
                    { 3, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N00-212315444", 666m, 888m, true, 1, 2 },
                    { 1, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N00-212315412", 466m, 545m, true, 1, 1 },
                    { 2, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "N00-212315413", 555m, 777m, true, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Procurements",
                columns: new[] { "ProcurementID", "ProcurementAccountAmount", "ProcurementDate", "ProcurementNote", "ProcurementNumber", "ProcurementTax", "SupplierID", "UserID", "WarehouseID" },
                values: new object[,]
                {
                    { 3, 24m, new DateTime(2021, 2, 8, 23, 21, 6, 899, DateTimeKind.Local).AddTicks(7688), "This is a procurement2", "2132162", 5m, 2, 2, 2 },
                    { 2, 23m, new DateTime(2021, 2, 8, 23, 21, 6, 899, DateTimeKind.Local).AddTicks(7603), "This is a procurement1", "2132132", 5m, 1, 1, 1 },
                    { 4, 25m, new DateTime(2021, 2, 8, 23, 21, 6, 899, DateTimeKind.Local).AddTicks(7693), "This is a procurement3", "2132182", 5m, 3, 3, 3 },
                    { 1, 230m, new DateTime(2021, 2, 8, 23, 21, 6, 899, DateTimeKind.Local).AddTicks(5496), "This is a procurement", "2132152", 5m, 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleID", "ChangeDate", "RoleID", "UserID" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(8207), 2, 3 },
                    { 1, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(7816), 1, 1 },
                    { 2, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(8194), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "CompleteOrder",
                columns: new[] { "CompleteOrderID", "ClientID", "CompleteOrderDate", "CompleteOrderSent", "OrderID", "UserID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(3056), true, 1, 1 },
                    { 2, 2, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(3973), true, 2, 2 },
                    { 3, 3, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(4002), true, 3, 3 },
                    { 4, 4, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(4006), true, 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailsID", "Amount", "ArticleID", "Discount", "OrderID", "Price" },
                values: new object[,]
                {
                    { 1, 7, 1, 5m, 1, 230m },
                    { 2, 7, 1, 5m, 2, 777m },
                    { 4, 11, 2, 5m, 4, 23m },
                    { 3, 6, 3, 5m, 3, 66m }
                });

            migrationBuilder.InsertData(
                table: "ProcurementDetails",
                columns: new[] { "ProcurementDetailID", "Amount", "ArticleID", "Price", "ProcurementID" },
                values: new object[,]
                {
                    { 1, 2, 1, 230m, 1 },
                    { 2, 2, 3, 321m, 2 },
                    { 3, 3, 2, 322m, 3 },
                    { 4, 1, 1, 323m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingID", "ArticleID", "ClientID", "RatingDate", "RatingGrade" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(507), 5 },
                    { 2, 1, 2, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(1654), 4 },
                    { 3, 2, 3, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(1687), 3 },
                    { 4, 3, 4, new DateTime(2021, 2, 8, 23, 21, 6, 900, DateTimeKind.Local).AddTicks(1691), 2 }
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
