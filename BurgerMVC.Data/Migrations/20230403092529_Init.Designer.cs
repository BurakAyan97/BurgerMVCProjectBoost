﻿// <auto-generated />
using System;
using BurgerMVC.DataLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    [DbContext(typeof(BurgerDbContext))]
    [Migration("20230403092529_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Dessert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Dessert");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9476),
                            Image = "/ProjeResimler/Cikolata.png",
                            Name = "Çikolata Cookie",
                            Price = 10m,
                            Status = true,
                            Stock = 50
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9477),
                            Image = "/ProjeResimler/Dondurma.png",
                            Name = "Dondurma",
                            Price = 10m,
                            Status = true,
                            Stock = 10
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9479),
                            Image = "/ProjeResimler/Elmali.png",
                            Name = "Elmalı Turta",
                            Price = 25m,
                            Status = true,
                            Stock = 70
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9481),
                            Image = "/ProjeResimler/sufle.png",
                            Name = "Sufle",
                            Price = 30m,
                            Status = true,
                            Stock = 45
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9483),
                            Image = "/ProjeResimler/sundae.png",
                            Name = "Sundae",
                            Price = 17m,
                            Status = true,
                            Stock = 100
                        });
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Drink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9495),
                            Image = "/ProjeResimler/Ayran.png",
                            Name = "Ayran",
                            Price = 12m,
                            Status = true,
                            Stock = 250
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9497),
                            Image = "/ProjeResimler/Cola.png",
                            Name = "Kola",
                            Price = 16m,
                            Status = true,
                            Stock = 450
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9499),
                            Image = "/ProjeResimler/Fanta.png",
                            Name = "Fanta",
                            Price = 16m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9522),
                            Image = "/ProjeResimler/Icetea.png",
                            Name = "Ice Tea",
                            Price = 14m,
                            Status = true,
                            Stock = 270
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9524),
                            Image = "/ProjeResimler/MeyveSuyu.png",
                            Name = "Meyve Suyu",
                            Price = 10m,
                            Status = true,
                            Stock = 400
                        },
                        new
                        {
                            ID = 6,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9526),
                            Image = "/ProjeResimler/Sprite.png",
                            Name = "Sprite",
                            Price = 14m,
                            Status = true,
                            Stock = 130
                        });
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Extra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Extras");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9453),
                            Image = "/ProjeResimler/Patates.jpg",
                            Name = "Patates Kızartması",
                            Price = 12m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9455),
                            Image = "/ProjeResimler/Tender.png",
                            Name = "Tavuk Tender",
                            Price = 20m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9457),
                            Image = "/ProjeResimler/sogan.jpg",
                            Name = "Soğan Halkası",
                            Price = 17m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9458),
                            Image = "/ProjeResimler/Nugget.png",
                            Name = "Nugget",
                            Price = 16m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9460),
                            Image = "/ProjeResimler/Citir.png",
                            Name = "Çıtır Tavuk",
                            Price = 22m,
                            Status = true,
                            Stock = 350
                        });
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9317),
                            Description = "Burger(Balık+Domates+Peynir+Turşu)+Patates(200 gr)+İçecek(Kola)",
                            Image = "/ProjeResimler/BalikBurger.jpg",
                            Name = "Balık Burger Menu",
                            Price = 100m,
                            Status = true,
                            Stock = 250
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9319),
                            Description = "Burger(2 Köfte+Marul+Peynir+Mayonez)+Patates(200gr)+İçecek(Ice Tea)",
                            Image = "/ProjeResimler/DoubleBurger.jpg",
                            Name = "Double Burger Menu",
                            Price = 95m,
                            Status = true,
                            Stock = 250
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9321),
                            Description = "Burger(Tavuk+Marul+Domates+Çıtır Soğan)+Patates(200gr)+İçecek(Ayran)",
                            Image = "/ProjeResimler/TavukBurger.jpg",
                            Name = "Tavuk Burger Menu",
                            Price = 55m,
                            Status = true,
                            Stock = 250
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9323),
                            Description = "Burger(Siyah Ekmek+240gr Köfte+Turşu+Karamelize Soğan)+Patates(200gr)+İçecek(Fanta)",
                            Image = "/ProjeResimler/BlackBurger.jpg",
                            Name = "Black Burger Menu",
                            Price = 120m,
                            Status = true,
                            Stock = 250
                        });
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<string>("AppUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderID");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailsID"), 1L, 1);

                    b.Property<int?>("DessertID")
                        .HasColumnType("int");

                    b.Property<int>("DrinkID")
                        .HasColumnType("int");

                    b.Property<int?>("ExtraID")
                        .HasColumnType("int");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("SauceID")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsID");

                    b.HasIndex("DessertID");

                    b.HasIndex("DrinkID");

                    b.HasIndex("ExtraID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.HasIndex("SauceID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Sauce", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Sauce");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9427),
                            Image = "/ProjeResimler/Ketcap.png",
                            Name = "Ketçap",
                            Price = 3m,
                            Status = true,
                            Stock = 250
                        },
                        new
                        {
                            ID = 2,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9429),
                            Image = "/ProjeResimler/Acisos.png",
                            Name = "Acı Sos",
                            Price = 3m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 3,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9430),
                            Image = "/ProjeResimler/Barbakü.png",
                            Name = "Barbekü Sosu",
                            Price = 3m,
                            Status = true,
                            Stock = 350
                        },
                        new
                        {
                            ID = 4,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9432),
                            Image = "/ProjeResimler/Buffalo.png",
                            Name = "Buffalo Sosu",
                            Price = 3m,
                            Status = true,
                            Stock = 400
                        },
                        new
                        {
                            ID = 5,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9434),
                            Image = "/ProjeResimler/Hardal.png",
                            Name = "Hardal Sosu",
                            Price = 3m,
                            Status = true,
                            Stock = 150
                        },
                        new
                        {
                            ID = 6,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9436),
                            Image = "/ProjeResimler/Ranch.png",
                            Name = "Ranch Sosu",
                            Price = 3m,
                            Status = true,
                            Stock = 650
                        },
                        new
                        {
                            ID = 7,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9437),
                            Image = "/ProjeResimler/Mayonez.png",
                            Name = "Mayonez",
                            Price = 3m,
                            Status = true,
                            Stock = 220
                        },
                        new
                        {
                            ID = 8,
                            CreatedTime = new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9439),
                            Image = "/ProjeResimler/Sarımsaklı.png",
                            Name = "Sarımsaklı Mayonez",
                            Price = 3m,
                            Status = true,
                            Stock = 345
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Order", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.OrderDetails", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Dessert", "Dessert")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DessertID");

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Drink", "Drink")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DrinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Extra", "Extra")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ExtraID");

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Menu", "Menu")
                        .WithMany("OrderDetails")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.Sauce", "Sauce")
                        .WithMany("OrderDetails")
                        .HasForeignKey("SauceID");

                    b.Navigation("Dessert");

                    b.Navigation("Drink");

                    b.Navigation("Extra");

                    b.Navigation("Menu");

                    b.Navigation("Order");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BurgerMVC.EntityLayer.Concrete.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.AppUser", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Dessert", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Drink", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Extra", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Menu", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BurgerMVC.EntityLayer.Concrete.Sauce", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}