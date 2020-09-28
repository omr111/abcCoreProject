using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class isActivesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "supplies");

            migrationBuilder.AlterColumn<string>(
                name: "passwordSalt",
                table: "users",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "passwordHash",
                table: "users",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "supplies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "discountCoupons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isActive",
                table: "users");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "supplies");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "products");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "discountCoupons");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "categories");

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordSalt",
                table: "users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "passwordHash",
                table: "users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "supplies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
