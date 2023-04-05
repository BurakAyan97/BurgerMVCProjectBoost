using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ce9e927-2d41-4770-9816-edf5129fa0cc"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "61cd752d-8458-4234-a1ba-07fa91455e84", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5df094ba-45be-4736-a78e-935f949fa388"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "2e5c9736-71cc-45e5-b19d-5351129cf9e7", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 6, 46, 877, DateTimeKind.Local).AddTicks(2086));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ce9e927-2d41-4770-9816-edf5129fa0cc"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "72567888-45f1-4a8c-a19a-590ab74ac638", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5df094ba-45be-4736-a78e-935f949fa388"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "7a0a2c0a-1b78-4a82-828c-87fa2bd4dc8a", null });

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 16, 4, 35, 77, DateTimeKind.Local).AddTicks(592));
        }
    }
}
