﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Persistence.Context;

#nullable disable

namespace OrderManagement.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240718120942_mig1_UpdateUser")]
    partial class mig1_UpdateUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderManagement.Domain.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("LastUpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Companies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9450a960-4f4c-4967-84c7-1e9f5781dd00"),
                            CreatedDate = new DateTime(2024, 7, 18, 12, 9, 42, 6, DateTimeKind.Utc).AddTicks(7318),
                            Description = "Bu bir örnek şirkettir",
                            LastUpdateDate = new DateTime(2024, 7, 18, 12, 9, 42, 6, DateTimeKind.Utc).AddTicks(7318),
                            Name = "Örnek Şirket",
                            UserId = new Guid("3e7d477c-7b2b-4bd1-b120-89b3f189340e")
                        });
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime>("LastUpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrderCount")
                        .HasColumnType("int");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ee423d32-2a02-49c0-a70d-eeaeadfcf5c2"),
                            CompanyId = new Guid("9450a960-4f4c-4967-84c7-1e9f5781dd00"),
                            CreatedDate = new DateTime(2024, 7, 18, 12, 9, 42, 8, DateTimeKind.Utc).AddTicks(8346),
                            LastUpdateDate = new DateTime(2024, 7, 18, 12, 9, 42, 8, DateTimeKind.Utc).AddTicks(8347),
                            Name = "Örnek Sipariş",
                            OrderCount = 5,
                            OrderStatus = 0,
                            ProductId = new Guid("9e60eb9a-9e7f-4a3d-8bbc-611bd5798a18"),
                            UnitPrice = 10.5m,
                            UserId = new Guid("3e7d477c-7b2b-4bd1-b120-89b3f189340e")
                        });
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("LastUpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StockCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9e60eb9a-9e7f-4a3d-8bbc-611bd5798a18"),
                            CompanyId = new Guid("9450a960-4f4c-4967-84c7-1e9f5781dd00"),
                            CreatedDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(5328),
                            Description = "Bu bir örnek üründür",
                            LastUpdateDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(5328),
                            Name = "Örnek Ürün",
                            Price = 50.0m,
                            ProductCategoryId = new Guid("5e378b2e-0b75-4a4f-b4f1-881419799561"),
                            StockCount = 100
                        });
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("LastUpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e378b2e-0b75-4a4f-b4f1-881419799561"),
                            CreatedDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(157),
                            Description = "Bu bir örnek kategoridir",
                            LastUpdateDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(158),
                            Name = "Örnek Kategori"
                        });
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AuthenticatorType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("LastUpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e7d477c-7b2b-4bd1-b120-89b3f189340e"),
                            AuthenticatorType = 0,
                            CreatedDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(7325),
                            Description = "Bu bir örnek kullanıcıdır",
                            Email = "Test@gmail.com",
                            FirstName = "Test",
                            LastName = "Test",
                            LastUpdateDate = new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(7326),
                            Name = "Örnek Kullanıcı",
                            PasswordHash = new byte[0],
                            PasswordSalt = new byte[0],
                            Status = false
                        });
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Company", b =>
                {
                    b.HasOne("OrderManagement.Domain.Entities.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Order", b =>
                {
                    b.HasOne("OrderManagement.Domain.Entities.Company", "Company")
                        .WithMany("Orders")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderManagement.Domain.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OrderManagement.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Product", b =>
                {
                    b.HasOne("OrderManagement.Domain.Entities.Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrderManagement.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Company", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OrderManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
