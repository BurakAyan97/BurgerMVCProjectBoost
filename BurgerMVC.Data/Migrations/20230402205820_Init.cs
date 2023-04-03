using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dessert",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dessert", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sauce",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    SauceID = table.Column<int>(type: "int", nullable: true),
                    ExtraID = table.Column<int>(type: "int", nullable: true),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    DessertID = table.Column<int>(type: "int", nullable: true),
                    DrinkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Dessert_DessertID",
                        column: x => x.DessertID,
                        principalTable: "Dessert",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Drinks_DrinkID",
                        column: x => x.DrinkID,
                        principalTable: "Drinks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Extras_ExtraID",
                        column: x => x.ExtraID,
                        principalTable: "Extras",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OrderDetails_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sauce_SauceID",
                        column: x => x.SauceID,
                        principalTable: "Sauce",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Dessert",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1122), "/ProjeResimler/Cikolata.png", "Çikolata Cookie", 10m, true, 50, null },
                    { 2, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1124), "/ProjeResimler/Dondurma.png", "Dondurma", 10m, true, 10, null },
                    { 3, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1126), "/ProjeResimler/Elmali.png", "Elmalı Turta", 25m, true, 70, null },
                    { 4, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1127), "/ProjeResimler/sufle.png", "Sufle", 30m, true, 45, null },
                    { 5, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1129), "/ProjeResimler/sundae.png", "Sundae", 17m, true, 100, null }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1141), "/ProjeResimler/Ayran.png", "Ayran", 12m, true, 250, null },
                    { 2, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1143), "/ProjeResimler/Cola.png", "Kola", 16m, true, 450, null },
                    { 3, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1145), "/ProjeResimler/Fanta.png", "Fanta", 16m, true, 350, null },
                    { 4, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1147), "/ProjeResimler/Icetea.png", "Ice Tea", 14m, true, 270, null },
                    { 5, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1149), "/ProjeResimler/MeyveSuyu.png", "Meyve Suyu", 10m, true, 400, null },
                    { 6, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1151), "/ProjeResimler/Sprite.png", "Sprite", 14m, true, 130, null }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1098), "/ProjeResimler/Patates.jpg", "Patates Kızartması", 12m, true, 350, null },
                    { 2, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1100), "/ProjeResimler/Tender.png", "Tavuk Tender", 20m, true, 350, null },
                    { 3, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1102), "/ProjeResimler/sogan.jpg", "Soğan Halkası", 17m, true, 350, null },
                    { 4, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1103), "/ProjeResimler/Nugget.png", "Nugget", 16m, true, 350, null },
                    { 5, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1105), "/ProjeResimler/Citir.png", "Çıtır Tavuk", 22m, true, 350, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "CreatedTime", "Description", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(967), "Burger(Balık+Domates+Peynir+Turşu)+Patates(200 gr)+İçecek(Kola)", "/ProjeResimler/BalikBurger.jpg", "Balık Burger Menu", 100m, true, 250, null },
                    { 2, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(969), "Burger(2 Köfte+Marul+Peynir+Mayonez)+Patates(200gr)+İçecek(Ice Tea)", "/ProjeResimler/DoubleBurger.jpg", "Double Burger Menu", 95m, true, 250, null },
                    { 3, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(971), "Burger(Tavuk+Marul+Domates+Çıtır Soğan)+Patates(200gr)+İçecek(Ayran)", "/ProjeResimler/TavukBurger.jpg", "Tavuk Burger Menu", 55m, true, 250, null },
                    { 4, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(973), "Burger(Siyah Ekmek+240gr Köfte+Turşu+Karamelize Soğan)+Patates(200gr)+İçecek(Fanta)", "/ProjeResimler/BlackBurger.jpg", "Black Burger Menu", 120m, true, 250, null }
                });

            migrationBuilder.InsertData(
                table: "Sauce",
                columns: new[] { "ID", "CreatedTime", "Image", "Name", "Price", "Status", "Stock", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1070), "/ProjeResimler/Ketcap.png", "Ketçap", 3m, true, 250, null },
                    { 2, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1072), "/ProjeResimler/Acisos.png", "Acı Sos", 3m, true, 350, null },
                    { 3, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1074), "/ProjeResimler/Barbakü.png", "Barbekü Sosu", 3m, true, 350, null },
                    { 4, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1075), "/ProjeResimler/Buffalo.png", "Buffalo Sosu", 3m, true, 400, null },
                    { 5, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1077), "/ProjeResimler/Hardal.png", "Hardal Sosu", 3m, true, 150, null },
                    { 6, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1079), "/ProjeResimler/Ranch.png", "Ranch Sosu", 3m, true, 650, null },
                    { 7, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1081), "/ProjeResimler/Mayonez.png", "Mayonez", 3m, true, 220, null },
                    { 8, new DateTime(2023, 4, 2, 23, 58, 19, 723, DateTimeKind.Local).AddTicks(1082), "/ProjeResimler/Sarımsaklı.png", "Sarımsaklı Mayonez", 3m, true, 345, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AppUserID",
                table: "Order",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DessertID",
                table: "OrderDetails",
                column: "DessertID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DrinkID",
                table: "OrderDetails",
                column: "DrinkID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ExtraID",
                table: "OrderDetails",
                column: "ExtraID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MenuID",
                table: "OrderDetails",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SauceID",
                table: "OrderDetails",
                column: "SauceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Dessert");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Sauce");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
