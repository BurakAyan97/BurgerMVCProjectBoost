using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMVC.DataLayer.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 26, 55, 924, DateTimeKind.Local).AddTicks(183));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Dessert",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Sauce",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2023, 4, 3, 12, 25, 28, 791, DateTimeKind.Local).AddTicks(9439));
        }
    }
}
