using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class MyDataContext : DbContext
    {
        public MyDataContext()
        {
        }

        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GiftCards> GiftCards { get; set; }
        public virtual DbSet<OederDetail> OederDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"S:\\כתה יב\\מדעי המחשב\\מורה\\פרויקט הדגמא\\dataBase\\dataBaseJewelryStore.mdf\";Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerNum)
                    .HasName("PK__tmp_ms_x__C942F407B0C252A2");

                entity.Property(e => e.CustomerNum).HasColumnName("customerNum");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerId")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<GiftCards>(entity =>
            {
                entity.HasKey(e => e.GiftCardId)
                    .HasName("PK__tmp_ms_x__9FBB0CE1C78C4ED7");

                entity.Property(e => e.GiftCardId).HasColumnName("GiftCardID");

                entity.Property(e => e.ExpirationDate).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OederDetail>(entity =>
            {
                entity.HasKey(e => new { e.CodeProdect, e.CodeOrder })
                    .HasName("PK__OederDet__E7F604E658047297");

                entity.Property(e => e.CodeProdect).HasColumnName("codeProdect");

                entity.Property(e => e.CodeOrder).HasColumnName("codeOrder");

                entity.Property(e => e.DiscibeAddition)
                    .HasColumnName("discibeAddition")
                    .HasMaxLength(50);

                entity.Property(e => e.PriceAddition).HasColumnName("priceAddition");

                //entity.HasOne(d => d.CodeOrderNavigation)
                //    .WithMany(p => p.OederDetail)
                //    .HasForeignKey(d => d.CodeOrder)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_OederDetail_ToTable");

                //entity.HasOne(d => d.CodeProdectNavigation)
                //    .WithMany(p => p.OederDetail)
                //    .HasForeignKey(d => d.CodeProdect)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_OederDetail_ToTable_1");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tmp_ms_x__C3905BAFC5F1BDA7");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerNum).HasColumnName("customerNum");

                entity.Property(e => e.OrderDate).HasMaxLength(50);

                entity.Property(e => e.ShippingId).HasColumnName("ShippingID ");

                //entity.HasOne(d => d.CustomerNumNavigation)
                //    .WithMany(p => p.Orders)
                //    .HasForeignKey(d => d.CustomerNum)
                //    .HasConstraintName("FK_Orders_ToTable");

                //entity.HasOne(d => d.GiftCardNavigation)
                //    .WithMany(p => p.Orders)
                //    .HasForeignKey(d => d.GiftCard)
                //    .HasConstraintName("FK_Orders_ToTable_2");

                //entity.HasOne(d => d.Shipping)
                //    .WithMany(p => p.Orders)
                //    .HasForeignKey(d => d.ShippingId)
                //    .HasConstraintName("FK_Orders_ToTable_1");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__tmp_ms_x__B40CC6ED52C81B46");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Material).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Stock).HasColumnName("Stock ");
            });

            modelBuilder.Entity<Shipping>(entity =>
            {
                entity.Property(e => e.ShippingId).HasColumnName("ShippingID");

                entity.Property(e => e.ShippingDate).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusServer).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
