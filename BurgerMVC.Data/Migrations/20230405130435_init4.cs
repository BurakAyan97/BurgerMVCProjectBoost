using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1ce9e927-2d41-4770-9816-edf5129fa0cc"), "72567888-45f1-4a8c-a19a-590ab74ac638", "Admin", null },
                    { new Guid("5df094ba-45be-4736-a78e-935f949fa388"), "7a0a2c0a-1b78-4a82-828c-87fa2bd4dc8a", "Customer", null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1ce9e927-2d41-4770-9816-edf5129fa0cc"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5df094ba-45be-4736-a78e-935f949fa388"));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 5, 15, 48, 26, 307, DateTimeKind.Local).AddTicks(5071));
        }
    }
}
