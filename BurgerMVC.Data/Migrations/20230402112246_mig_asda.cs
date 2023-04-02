using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class mig_asda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 14, 22, 45, 652, DateTimeKind.Local).AddTicks(7783));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(257));

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
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(260));

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
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 2, 12, 35, 17, 683, DateTimeKind.Local).AddTicks(134));

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
    }
}
