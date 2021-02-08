using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZenithFit.WebAPI.Database
{
    public partial class ZenithFitDatabaseContext : DbContext
    {
        public ZenithFitDatabaseContext()
        {
        }

        public ZenithFitDatabaseContext(DbContextOptions<ZenithFitDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<CompleteOrder> CompleteOrder { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Notices> Notices { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProcurementDetails> ProcurementDetails { get; set; }
        public virtual DbSet<Procurements> Procurements { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<RequestDetails> RequestDetails { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Warehouses> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J8RJI72\\SQLEXPRESS;Database = ZenithFitDatabase;Trusted_Connection = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK__Articles__9C6270C826A134A7");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleName).HasMaxLength(100);

                entity.Property(e => e.ArticlePrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Articles__Catego__4E88ABD4");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Articles__Manufa__4D94879B");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Categori__19093A2B0E46F8E4");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK__Clients__E67E1A044D08DA90");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientEmail).HasMaxLength(100);

                entity.Property(e => e.ClientFirstName).HasMaxLength(100);

                entity.Property(e => e.ClientLastName).HasMaxLength(100);

                entity.Property(e => e.ClientPhone).HasMaxLength(100);

                entity.Property(e => e.ClientUsername).HasMaxLength(30);

                entity.Property(e => e.PasswordHash).HasMaxLength(200);

                entity.Property(e => e.PasswordSalt).HasMaxLength(200);
            });

            modelBuilder.Entity<CompleteOrder>(entity =>
            {
                entity.Property(e => e.CompleteOrderId).HasColumnName("CompleteOrderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CompleteOrder)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompleteO__Clien__693CA210");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CompleteOrder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompleteO__Order__6B24EA82");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CompleteOrder)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CompleteO__UserI__6A30C649");
            });

            modelBuilder.Entity<Manufacturers>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("PK__Manufact__357E5CA1584EC634");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ManufacturerName).HasMaxLength(100);
            });

            modelBuilder.Entity<Notices>(entity =>
            {
                entity.HasKey(e => e.NoticeId)
                    .HasName("PK__Notices__CE83CB858F8BDC96");

                entity.Property(e => e.NoticeId).HasColumnName("NoticeID");

                entity.Property(e => e.NoticeTitle).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Notices__UserID__3C69FB99");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.Property(e => e.OrderDetailsId).HasColumnName("OrderDetailsID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK__OrderDeta__Artic__66603565");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAF4AE8A624");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrderNumber).HasMaxLength(100);

                entity.Property(e => e.OrderPriceNoTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderPriceTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__ClientID__628FA481");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserID__6383C8BA");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__Warehous__619B8048");
            });

            modelBuilder.Entity<ProcurementDetails>(entity =>
            {
                entity.HasKey(e => e.ProcurementDetailId)
                    .HasName("PK__Procurem__67666710DC9D5C2B");

                entity.Property(e => e.ProcurementDetailId).HasColumnName("ProcurementDetailID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProcurementId).HasColumnName("ProcurementID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ProcurementDetails)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Procureme__Artic__5EBF139D");

                entity.HasOne(d => d.Procurement)
                    .WithMany(p => p.ProcurementDetails)
                    .HasForeignKey(d => d.ProcurementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Procureme__Procu__5DCAEF64");
            });

            modelBuilder.Entity<Procurements>(entity =>
            {
                entity.HasKey(e => e.ProcurementId)
                    .HasName("PK__Procurem__95B4518CAA2BF8FB");

                entity.Property(e => e.ProcurementId).HasColumnName("ProcurementID");

                entity.Property(e => e.ProcurementAccountAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProcurementNote).HasMaxLength(500);

                entity.Property(e => e.ProcurementNumber).HasMaxLength(100);

                entity.Property(e => e.ProcurementTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Procurements)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Procureme__Suppl__5AEE82B9");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Procurements)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Procureme__UserI__59FA5E80");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Procurements)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Procureme__Wareh__59063A47");
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__Ratings__FCCDF85CE0628B79");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__Article__5629CD9C");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__ClientI__5535A963");
            });

            modelBuilder.Entity<RequestDetails>(entity =>
            {
                entity.Property(e => e.RequestDetailsId).HasColumnName("RequestDetailsID");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RequestDe__Reque__47DBAE45");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RequestDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RequestDe__UserI__48CFD27E");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__Requests__33A8519A648FA1C5");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.RequestDescription).HasMaxLength(200);

                entity.Property(e => e.RequestTitle).HasMaxLength(100);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Requests__Client__44FF419A");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__Roles__8AFACE3A32FDA6D3");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK__Supplier__4BE66694FF6CCDB0");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierAddress).HasMaxLength(100);

                entity.Property(e => e.SupplierBankAccount).HasMaxLength(100);

                entity.Property(e => e.SupplierContact).HasMaxLength(100);

                entity.Property(e => e.SupplierEmail).HasMaxLength(30);

                entity.Property(e => e.SupplierName).HasMaxLength(100);

                entity.Property(e => e.SupplierPhone).HasMaxLength(30);

                entity.Property(e => e.SupplierWeb).HasMaxLength(100);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK__UserRole__3D978A55393233A9");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserRoles__RoleI__52593CB8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserRoles__Chang__5165187F");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CCAC54B38ACA");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.PasswordHash).HasMaxLength(200);

                entity.Property(e => e.PasswordSalt).HasMaxLength(200);

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserFirstName).HasMaxLength(100);

                entity.Property(e => e.UserLastName).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(100);

                entity.Property(e => e.UserUsername).HasMaxLength(30);
            });

            modelBuilder.Entity<Warehouses>(entity =>
            {
                entity.HasKey(e => e.WarehouseId)
                    .HasName("PK__Warehous__2608AFD92D3BBDD6");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.Property(e => e.WarehouseAddress).HasMaxLength(200);

                entity.Property(e => e.WarehouseName).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
