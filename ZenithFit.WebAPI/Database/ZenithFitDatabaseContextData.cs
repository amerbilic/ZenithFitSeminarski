using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithFit.WebAPI.Database
{
    public partial class ZenithFitDatabaseContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouses>().HasData(
            new Warehouses() { WarehouseName = "Warehouse1", WarehouseId = 1, WarehouseAddress = "Address1", WarehouseNote = "This is a note" },
            new Warehouses() { WarehouseName = "Warehouse2", WarehouseId = 2, WarehouseAddress = "Address1", WarehouseNote = "This is a note" },
            new Warehouses() { WarehouseName = "Pre-Warehouse3", WarehouseId = 3, WarehouseAddress = "Address3", WarehouseNote = "This is a note" },
            new Warehouses() { WarehouseName = "Fat-Warehouse4", WarehouseId = 4, WarehouseAddress = "Address4", WarehouseNote = "This is a note" });

            modelBuilder.Entity<Categories>().HasData(
            new Categories() { CategoryName = "Proteini", CategoryId = 1 },
            new Categories() { CategoryName = "WeightGainer", CategoryId = 2 },
            new Categories() { CategoryName = "Pre-workout", CategoryId = 3 },
            new Categories() { CategoryName = "Fat-burner", CategoryId = 4 });

            modelBuilder.Entity<Manufacturers>().HasData(
            new Manufacturers() { ManufacturerName = "Olymp", ManufacturerId = 1 },
            new Manufacturers() { ManufacturerName = "MyProtein", ManufacturerId = 2 },
            new Manufacturers() { ManufacturerName = "IronMaxx", ManufacturerId = 3 },
            new Manufacturers() { ManufacturerName = "RedWeiller", ManufacturerId = 4 });

            modelBuilder.Entity<Articles>().HasData(
            new Articles() { ArticleName = "Protein1", ArticleCode = "2314", ArticleId = 1, ArticlePrice = 300, ArticleStatus = true, CategoryId = 1, ManufacturerId = 1 },
            new Articles() { ArticleName = "Protein2", ArticleCode = "2312541", ArticleId = 2, ArticlePrice = 321, ArticleStatus = true, CategoryId = 1, ManufacturerId = 1 },
            new Articles() { ArticleName = "Weight3", ArticleCode = "42312", ArticleId = 3, ArticlePrice = 232, ArticleStatus = true, CategoryId = 2, ManufacturerId = 2 },
            new Articles() { ArticleName = "Weight2", ArticleCode = "23121", ArticleId = 4, ArticlePrice = 664, ArticleStatus = true, CategoryId = 2, ManufacturerId = 2 },
            new Articles() { ArticleName = "Random3", ArticleCode = "5675", ArticleId = 5, ArticlePrice = 213, ArticleStatus = true, CategoryId = 3, ManufacturerId = 2 },
            new Articles() { ArticleName = "Item7", ArticleCode = "756543", ArticleId = 6, ArticlePrice = 421, ArticleStatus = true, CategoryId = 3, ManufacturerId = 3 },
            new Articles() { ArticleName = "Something3", ArticleCode = "123115", ArticleId = 7, ArticlePrice = 122, ArticleStatus = true, CategoryId = 3, ManufacturerId = 4 });

            modelBuilder.Entity<Clients>().HasData(
            new Clients() { ClientId = 1, ClientFirstName = "Amer", ClientLastName = "Bilic", ClientRegisterDate = DateTime.Now.AddDays(-5), ClientEmail = "testing1@email.com", ClientPhone = "1233455", ClientUsername = "mobile", PasswordHash = "qEkPhwY9P2FiDqx1Rgg26GoapxE=", PasswordSalt = "fVZy3b4Z1cvYNep/oXc7aA==" },
            new Clients() { ClientId = 2, ClientFirstName = "Denis", ClientLastName = "Bajrektarevic", ClientRegisterDate = DateTime.Now.AddDays(-5), ClientEmail = "testing2@email.com", ClientPhone = "312314", ClientUsername = "hajfo", PasswordHash = "r577PsUb6lkHEs32NUsQHbqEhqc=", PasswordSalt = "jpiaSiCqXBnw1z4lUnuRww==" },
            new Clients() { ClientId = 3, ClientFirstName = "Ajdin", ClientLastName = "Muftic", ClientRegisterDate = DateTime.Now.AddDays(-5), ClientEmail = "testing3@email.com", ClientPhone = "4133211", ClientUsername = "zake123", PasswordHash = "ZnhzTGY3bXxC4FoYf7FEzHB+w/c=", PasswordSalt = "hx1Yw2OJcF/dQGfUKNhQgg==" },
            new Clients() { ClientId = 4, ClientFirstName = "Beze", ClientLastName = "Kaljic", ClientRegisterDate = DateTime.Now.AddDays(-5), ClientEmail = "testing4@email.com", ClientPhone = "5141231", ClientUsername = "tarke321", PasswordHash = "r577PsUb6lkHEs32NUsQHbqEhqc=", PasswordSalt = "jpiaSiCqXBnw1z4lUnuRww==" });


            modelBuilder.Entity<Orders>().HasData(
            new Orders() { OrderId = 1, OrderNumber = "N00-212315412", OrderStatus = true, OrderCancelled = false, OrderPriceNoTax = 466, OrderPriceTax = 545, WarehouseId = 1, ClientId = 1, UserId = 1 },
            new Orders() { OrderId = 2, OrderNumber = "N00-212315413", OrderStatus = true, OrderCancelled = false, OrderPriceNoTax = 555, OrderPriceTax = 777, WarehouseId = 1, ClientId = 1, UserId = 1 },
            new Orders() { OrderId = 3, OrderNumber = "N00-212315444", OrderStatus = true, OrderCancelled = false, OrderPriceNoTax = 666, OrderPriceTax = 888, WarehouseId = 2, ClientId = 2, UserId = 1 },
            new Orders() { OrderId = 4, OrderNumber = "N00-212315463", OrderStatus = true, OrderCancelled = false, OrderPriceNoTax = 777, OrderPriceTax = 999, WarehouseId = 3, ClientId = 3, UserId = 1 });

            modelBuilder.Entity<OrderDetails>().HasData(
            new OrderDetails() { OrderDetailsId = 1, OrderId = 1, Amount = 7, Price = 230, Discount = 5, ArticleId = 1 },
            new OrderDetails() { OrderDetailsId = 2, OrderId = 2, Amount = 7, Price = 777, Discount = 5, ArticleId = 1 },
            new OrderDetails() { OrderDetailsId = 3, OrderId = 3, Amount = 6, Price = 66, Discount = 5, ArticleId = 3 },
            new OrderDetails() { OrderDetailsId = 4, OrderId = 4, Amount = 11, Price = 23, Discount = 5, ArticleId = 2 });

            modelBuilder.Entity<Suppliers>().HasData(
            new Suppliers() { SupplierId = 1, SupplierAddress = "Random address", SupplierBankAccount = "12315125", SupplierContact = "supcontact", SupplierEmail = "supplier1@email.com", SupplierName = "Supplier", SupplierNote = "He is a supplier", SupplierPhone = "12312541", SupplierStatus = true, SupplierWeb = "www.supplier.com" },
            new Suppliers() { SupplierId = 2, SupplierAddress = "Random address2", SupplierBankAccount = "123151254", SupplierContact = "supcontact2", SupplierEmail = "supplier2@email.com", SupplierName = "Supplier2", SupplierNote = "He is a supplier", SupplierPhone = "123125412", SupplierStatus = true, SupplierWeb = "www.supplier2.com" },
            new Suppliers() { SupplierId = 3, SupplierAddress = "Random address3", SupplierBankAccount = "123151251", SupplierContact = "supcontact3", SupplierEmail = "supplier3@email.com", SupplierName = "Supplier3", SupplierNote = "He is a supplier", SupplierPhone = "123125413", SupplierStatus = true, SupplierWeb = "www.supplier22.com" },
            new Suppliers() { SupplierId = 4, SupplierAddress = "Random address4", SupplierBankAccount = "123151252", SupplierContact = "supcontact4", SupplierEmail = "supplier4@email.com", SupplierName = "Supplier4", SupplierNote = "He is a supplier", SupplierPhone = "123125414", SupplierStatus = true, SupplierWeb = "www.supplier222.com" });


            modelBuilder.Entity<Procurements>().HasData(
           new Procurements() { ProcurementId = 1, ProcurementNumber = "2132152", ProcurementDate = DateTime.Now, ProcurementAccountAmount = 230, ProcurementTax = 5, ProcurementNote = "This is a procurement", WarehouseId = 1, UserId = 1, SupplierId = 1 },
           new Procurements() { ProcurementId = 2, ProcurementNumber = "2132132", ProcurementDate = DateTime.Now, ProcurementAccountAmount = 23, ProcurementTax = 5, ProcurementNote = "This is a procurement1", WarehouseId = 1, UserId = 1, SupplierId = 1 },
           new Procurements() { ProcurementId = 3, ProcurementNumber = "2132162", ProcurementDate = DateTime.Now, ProcurementAccountAmount = 24, ProcurementTax = 5, ProcurementNote = "This is a procurement2", WarehouseId = 2, UserId = 2, SupplierId = 2 },
           new Procurements() { ProcurementId = 4, ProcurementNumber = "2132182", ProcurementDate = DateTime.Now, ProcurementAccountAmount = 25, ProcurementTax = 5, ProcurementNote = "This is a procurement3", WarehouseId = 3, UserId = 3, SupplierId = 3 });

            modelBuilder.Entity<ProcurementDetails>().HasData(
            new ProcurementDetails() { ProcurementDetailId = 1, ProcurementId = 1, Price = 230, Amount = 2, ArticleId = 1 },
            new ProcurementDetails() { ProcurementDetailId = 2, ProcurementId = 2, Price = 321, Amount = 2, ArticleId = 3 },
            new ProcurementDetails() { ProcurementDetailId = 3, ProcurementId = 3, Price = 322, Amount = 3, ArticleId = 2 },
            new ProcurementDetails() { ProcurementDetailId = 4, ProcurementId = 4, Price = 323, Amount = 1, ArticleId = 1 });

            modelBuilder.Entity<Ratings>().HasData(
            new Ratings() { RatingId = 1, RatingDate = DateTime.Now, ClientId = 1, RatingGrade = 5, ArticleId = 1 },
            new Ratings() { RatingId = 2, RatingDate = DateTime.Now, ClientId = 2, RatingGrade = 4, ArticleId = 1 },
            new Ratings() { RatingId = 3, RatingDate = DateTime.Now, ClientId = 3, RatingGrade = 3, ArticleId = 2 },
            new Ratings() { RatingId = 4, RatingDate = DateTime.Now, ClientId = 4, RatingGrade = 2, ArticleId = 3 });

            modelBuilder.Entity<CompleteOrder>().HasData(
            new CompleteOrder() { CompleteOrderId = 1, ClientId = 1, UserId = 1, CompleteOrderDate = DateTime.Now, CompleteOrderSent = true, OrderId = 1 },
            new CompleteOrder() { CompleteOrderId = 2, ClientId = 2, UserId = 2, CompleteOrderDate = DateTime.Now, CompleteOrderSent = true, OrderId = 2 },
            new CompleteOrder() { CompleteOrderId = 3, ClientId = 3, UserId = 3, CompleteOrderDate = DateTime.Now, CompleteOrderSent = true, OrderId = 3 },
            new CompleteOrder() { CompleteOrderId = 4, ClientId = 4, UserId = 1, CompleteOrderDate = DateTime.Now, CompleteOrderSent = true, OrderId = 4 });

            modelBuilder.Entity<Roles>().HasData(
           new Roles() { RoleId = 1, RoleName = "Admin", RoleNote = "Administrator" },
           new Roles() { RoleId = 2, RoleName = "Employee", RoleNote = "Employee" });

            modelBuilder.Entity<UserRoles>().HasData(
           new UserRoles() { UserRoleId = 1, UserId = 1, RoleId = 1, ChangeDate = DateTime.Now },
           new UserRoles() { UserRoleId = 2, UserId = 2, RoleId = 2, ChangeDate = DateTime.Now },
           new UserRoles() { UserRoleId = 3, UserId = 3, RoleId = 2, ChangeDate = DateTime.Now });

            modelBuilder.Entity<Users>().HasData(
           new Users() { UserId = 1, UserFirstName = "Amer", UserLastName = "Hajfic", UserEmail = "testing33@email.com",UserPhone="3213215",UserUsername="admin",PasswordHash= "qEkPhwY9P2FiDqx1Rgg26GoapxE=", PasswordSalt= "fVZy3b4Z1cvYNep/oXc7aA==" },
           new Users() { UserId = 2, UserFirstName = "Denis", UserLastName = "Beso", UserEmail = "testing333@email.com", UserPhone = "32132154", UserUsername = "denje", PasswordHash = "qEkPhwY9P2FiDqx12gg26GoapxE=", PasswordSalt = "fVZy3b4Z1cvYNep/oXc7dA==" },
           new Users() { UserId = 3, UserFirstName = "Imad", UserLastName = "Spahic", UserEmail = "testing343@email.com", UserPhone = "32132157", UserUsername = "samar", PasswordHash = "qEkPhwY9P2FiDqx17gg26GoapxE=", PasswordSalt = "fVZy3b4Z1cvYNep/oXc7wA==" });



        }
    }
}
