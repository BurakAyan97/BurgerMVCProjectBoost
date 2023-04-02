using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class jpg_png : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(257), "/ProjeResimler/Patates.jpg" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(260), "/ProjeResimler/sogan.jpg" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(104), "/ProjeResimler/BalikBurger.jpg" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(107), "/ProjeResimler/DoubleBurger.jpg" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(132), "/ProjeResimler/TavukBurger.jpg" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(134), "/ProjeResimler/BlackBurger.jpg" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(239));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7910), "/ProjeResimler/Patates.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7914), "/ProjeResimler/sogan.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7720), "/ProjeResimler/BalikBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7723), "/ProjeResimler/DoubleBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7725), "/ProjeResimler/TavukBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7726), "/ProjeResimler/BlackBurger.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7893));
        }
    }
}
