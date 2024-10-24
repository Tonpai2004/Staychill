﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Staychill.Data;

#nullable disable

namespace Staychill.Migrations
{
    [DbContext(typeof(StaychillDbContext))]
    [Migration("20241023175921__cart05")]
    partial class _cart05
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Staychill.Models.BankModel.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("BankPicsData")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("BankTransferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankTransferId");

                    b.ToTable("BankAccDB");
                });

            modelBuilder.Entity("Staychill.Models.BankModel.BankTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BankNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankTransferDB");
                });

            modelBuilder.Entity("Staychill.Models.BankModel.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiredDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOnCard")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreditCardsDB");
                });

            modelBuilder.Entity("Staychill.Models.BankModel.QRData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("QRPicData")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("QRDataDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.HasKey("CartId");

                    b.ToTable("CartDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("CartItemId");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartitemsDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.DiscountModel.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiscountAmount")
                        .HasColumnType("int");

                    b.Property<string>("DiscountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiscountDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Instock")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<float?>("Price")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.ProductImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Image1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image4")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductImagesDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.RetainCartItem", b =>
                {
                    b.Property<int>("ReCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReCartItemId"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ReCartId")
                        .HasColumnType("int");

                    b.Property<int>("RetainCartId")
                        .HasColumnType("int");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("ReCartItemId");

                    b.HasIndex("ProductId");

                    b.HasIndex("RetainCartId");

                    b.ToTable("RetainCartItems");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.RetainCarts", b =>
                {
                    b.Property<int>("ReCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReCartId"));

                    b.Property<int?>("TrackingId")
                        .HasColumnType("int");

                    b.HasKey("ReCartId");

                    b.HasIndex("TrackingId");

                    b.ToTable("RetaincartsDB");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.TrackingModel.Tracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ShipmentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrackingDB");
                });

            modelBuilder.Entity("Staychill.Models.UserModel.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Alley")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Housenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Road")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subdistrict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("AddressDB");
                });

            modelBuilder.Entity("Staychill.Models.UserModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("UserDB");
                });

            modelBuilder.Entity("Staychill.ViewModel.ShipmentViewModel", b =>
                {
                    b.Property<string>("SelectedCartItemIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipmentCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.ToTable("ShipmentViewModel");
                });

            modelBuilder.Entity("Staychill.ViewModel.UserViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alley")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Road")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subdistrict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserViewModel");
                });

            modelBuilder.Entity("Staychill.Models.BankModel.BankAccount", b =>
                {
                    b.HasOne("Staychill.Models.BankModel.BankTransfer", null)
                        .WithMany("Accounts")
                        .HasForeignKey("BankTransferId");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.CartItem", b =>
                {
                    b.HasOne("Staychill.Models.ProductModel.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staychill.Models.ProductModel.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.ProductImages", b =>
                {
                    b.HasOne("Staychill.Models.ProductModel.Product", "Product")
                        .WithOne("Images")
                        .HasForeignKey("Staychill.Models.ProductModel.ProductImages", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.RetainCartItem", b =>
                {
                    b.HasOne("Staychill.Models.ProductModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Staychill.Models.ProductModel.RetainCarts", "RetainCart")
                        .WithMany("RetainCartItems")
                        .HasForeignKey("RetainCartId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("RetainCart");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.RetainCarts", b =>
                {
                    b.HasOne("Staychill.Models.ProductModel.TrackingModel.Tracking", "Tracking")
                        .WithMany("RetainCarts")
                        .HasForeignKey("TrackingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Tracking");
                });

            modelBuilder.Entity("Staychill.Models.UserModel.User", b =>
                {
                    b.HasOne("Staychill.Models.UserModel.Address", "Address")
                        .WithMany("UsersInfo")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Staychill.Models.BankModel.BankTransfer", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.RetainCarts", b =>
                {
                    b.Navigation("RetainCartItems");
                });

            modelBuilder.Entity("Staychill.Models.ProductModel.TrackingModel.Tracking", b =>
                {
                    b.Navigation("RetainCarts");
                });

            modelBuilder.Entity("Staychill.Models.UserModel.Address", b =>
                {
                    b.Navigation("UsersInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
