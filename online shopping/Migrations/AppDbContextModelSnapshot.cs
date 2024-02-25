﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using soft.Data;

#nullable disable

namespace soft.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("soft.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("soft.Models.CartItems", b =>
                {
                    b.Property<int>("CartItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemsId"));

                    b.Property<int?>("CartsId")
                        .HasColumnType("int");

                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_pic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("product_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CartItemsId");

                    b.HasIndex("CartsId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("soft.Models.Carts", b =>
                {
                    b.Property<int>("CartsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartsId"));

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("CartsId");

                    b.HasIndex("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("soft.Models.Categories", b =>
                {
                    b.Property<int>("category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("category_Id"));

                    b.Property<string>("category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("category_Id");

                    b.ToTable("Categories1");
                });

            modelBuilder.Entity("soft.Models.Deliveries", b =>
                {
                    b.Property<int>("deliveries_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("deliveries_Id"));

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deliveries_Id");

                    b.HasIndex("Id");

                    b.ToTable("Deliveries1");
                });

            modelBuilder.Entity("soft.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("login");
                });

            modelBuilder.Entity("soft.Models.Payment", b =>
                {
                    b.Property<int>("payment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("payment_Id"));

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("order_Id")
                        .HasColumnType("int");

                    b.Property<double>("totalprice")
                        .HasColumnType("float");

                    b.HasKey("payment_Id");

                    b.HasIndex("order_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("soft.Models.ProductSold", b =>
                {
                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("productsold_Id")
                        .HasColumnType("int");

                    b.HasKey("product_Id", "Id");

                    b.HasIndex("Id");

                    b.ToTable("ProductSolds");
                });

            modelBuilder.Entity("soft.Models.ShoppingOrder", b =>
                {
                    b.Property<int>("order_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("order_Id"));

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("order_Id");

                    b.HasIndex("Id");

                    b.ToTable("ShoppingOrders");
                });

            modelBuilder.Entity("soft.Models.TransactionReports", b =>
                {
                    b.Property<int>("Report_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Report_Id"));

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("order_Id")
                        .HasColumnType("int");

                    b.Property<int>("payment_Id")
                        .HasColumnType("int");

                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.HasKey("Report_Id");

                    b.HasIndex("Id");

                    b.HasIndex("order_Id");

                    b.HasIndex("payment_Id");

                    b.HasIndex("product_Id");

                    b.ToTable("TransactionReports1");
                });

            modelBuilder.Entity("soft.Models.productVSshoppingorder", b =>
                {
                    b.Property<int>("product_Id")
                        .HasColumnType("int");

                    b.Property<int>("order_Id")
                        .HasColumnType("int");

                    b.HasKey("product_Id", "order_Id");

                    b.HasIndex("order_Id");

                    b.ToTable("productVSshoppingorder1");
                });

            modelBuilder.Entity("soft.Models.products", b =>
                {
                    b.Property<int>("product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("product_Id"));

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("category_Id")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product_pic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("product_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("product_state")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("product_Id");

                    b.HasIndex("category_Id");

                    b.ToTable("products1");
                });

            modelBuilder.Entity("soft.Models.userData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("usersData");
                });

            modelBuilder.Entity("soft.Models.CartItems", b =>
                {
                    b.HasOne("soft.Models.Carts", null)
                        .WithMany("Items")
                        .HasForeignKey("CartsId");
                });

            modelBuilder.Entity("soft.Models.Carts", b =>
                {
                    b.HasOne("soft.Models.userData", "userData")
                        .WithMany("MyCarts")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userData");
                });

            modelBuilder.Entity("soft.Models.Deliveries", b =>
                {
                    b.HasOne("soft.Models.userData", "userData")
                        .WithMany("Deliveries")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userData");
                });

            modelBuilder.Entity("soft.Models.Payment", b =>
                {
                    b.HasOne("soft.Models.ShoppingOrder", "MyshoppingOrder")
                        .WithMany()
                        .HasForeignKey("order_Id");

                    b.Navigation("MyshoppingOrder");
                });

            modelBuilder.Entity("soft.Models.ProductSold", b =>
                {
                    b.HasOne("soft.Models.userData", "userData")
                        .WithMany("ProductSold")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("soft.Models.products", "products")
                        .WithMany("ProductSold")
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");

                    b.Navigation("userData");
                });

            modelBuilder.Entity("soft.Models.ShoppingOrder", b =>
                {
                    b.HasOne("soft.Models.userData", "userData")
                        .WithMany("ShoppingOrders")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("userData");
                });

            modelBuilder.Entity("soft.Models.TransactionReports", b =>
                {
                    b.HasOne("soft.Models.userData", "userData")
                        .WithMany("TransactionReports")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("soft.Models.ShoppingOrder", "ShoppingOrder")
                        .WithMany("TransactionReports")
                        .HasForeignKey("order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("soft.Models.Payment", "Payment")
                        .WithMany("TransactionReports")
                        .HasForeignKey("payment_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("soft.Models.products", "Products")
                        .WithMany("TransactionReports")
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("Products");

                    b.Navigation("ShoppingOrder");

                    b.Navigation("userData");
                });

            modelBuilder.Entity("soft.Models.productVSshoppingorder", b =>
                {
                    b.HasOne("soft.Models.ShoppingOrder", "Myshoppingorder")
                        .WithMany("productVSshoppingorder")
                        .HasForeignKey("order_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("soft.Models.products", "Myproducts")
                        .WithMany("productVSshoppingorder")
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Myproducts");

                    b.Navigation("Myshoppingorder");
                });

            modelBuilder.Entity("soft.Models.products", b =>
                {
                    b.HasOne("soft.Models.Categories", "Categories")
                        .WithMany("products")
                        .HasForeignKey("category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("soft.Models.Carts", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("soft.Models.Categories", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("soft.Models.Payment", b =>
                {
                    b.Navigation("TransactionReports");
                });

            modelBuilder.Entity("soft.Models.ShoppingOrder", b =>
                {
                    b.Navigation("TransactionReports");

                    b.Navigation("productVSshoppingorder");
                });

            modelBuilder.Entity("soft.Models.products", b =>
                {
                    b.Navigation("ProductSold");

                    b.Navigation("TransactionReports");

                    b.Navigation("productVSshoppingorder");
                });

            modelBuilder.Entity("soft.Models.userData", b =>
                {
                    b.Navigation("Deliveries");

                    b.Navigation("MyCarts");

                    b.Navigation("ProductSold");

                    b.Navigation("ShoppingOrders");

                    b.Navigation("TransactionReports");
                });
#pragma warning restore 612, 618
        }
    }
}
