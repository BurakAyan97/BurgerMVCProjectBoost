using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class delete_tilde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7933), "/ProjeResimler/Cikolata.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7935), "/ProjeResimler/Dondurma.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7937), "/ProjeResimler/Elmali.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7939), "/ProjeResimler/sufle.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7941), "/ProjeResimler/sundae.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7957), "/ProjeResimler/Ayran.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7958), "/ProjeResimler/Cola.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7960), "/ProjeResimler/Fanta.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7962), "/ProjeResimler/Icetea.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7964), "/ProjeResimler/MeyveSuyu.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7966), "/ProjeResimler/Sprite.png" });

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
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7912), "/ProjeResimler/Tender.png" });

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
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7915), "/ProjeResimler/Nugget.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7917), "/ProjeResimler/Citir.png" });

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
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7881), "/ProjeResimler/Ketcap.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7883), "/ProjeResimler/Acisos.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7885), "/ProjeResimler/Barbakü.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7886), "/ProjeResimler/Buffalo.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7888), "/ProjeResimler/Hardal.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7890), "/ProjeResimler/Ranch.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7892), "/ProjeResimler/Mayonez.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 33, 0, 529, DateTimeKind.Local).AddTicks(7893), "/ProjeResimler/Sarımsaklı.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2925), "~/ProjeResimler/Cikolata.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2927), "~/ProjeResimler/Dondurma.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2929), "~/ProjeResimler/Elmali.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2931), "~/ProjeResimler/sufle.png" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2932), "~/ProjeResimler/sundae.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2946), "~/ProjeResimler/Ayran.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2948), "~/ProjeResimler/Cola.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2949), "~/ProjeResimler/Fanta.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2951), "~/ProjeResimler/Icetea.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2953), "~/ProjeResimler/MeyveSuyu.png" });

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2955), "~/ProjeResimler/Sprite.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2878), "~/ProjeResimler/Patates.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2880), "~/ProjeResimler/Tender.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2882), "~/ProjeResimler/sogan.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2884), "~/ProjeResimler/Nugget.png" });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2908), "~/ProjeResimler/Citir.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2742), "~/ProjeResimler/BalikBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2744), "~/ProjeResimler/DoubleBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2746), "~/ProjeResimler/TavukBurger.png" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2748), "~/ProjeResimler/BlackBurger.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2850), "~/ProjeResimler/Ketcap.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2852), "~/ProjeResimler/Acisos.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2854), "~/ProjeResimler/Barbakü.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2856), "~/ProjeResimler/Buffalo.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2857), "~/ProjeResimler/Hardal.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2859), "~/ProjeResimler/Ranch.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2861), "~/ProjeResimler/Mayonez.png" });

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedTime", "Image" },
                values: new object[] { new DateTime(2023, 4, 2, 12, 31, 46, 471, DateTimeKind.Local).AddTicks(2863), "~/ProjeResimler/Sarımsaklı.png" });
        }
    }
}
