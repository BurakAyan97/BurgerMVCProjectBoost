using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 20, 26, 322, DateTimeKind.Local).AddTicks(2083));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 0, 13, 28, 738, DateTimeKind.Local).AddTicks(1137));
        }
    }
}
