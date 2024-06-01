using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotPotToYou.Infrastructure.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "UtensilDetai",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "UtensilDetai",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "UtensilDetai",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "UtensilDetai",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "UtensilDetai",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "UtensilDetai",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "Utensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Utensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Utensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Utensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Utensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Utensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "UntensilPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "UntensilPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "UntensilPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "UntensilPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "UntensilPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "UntensilPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "OrderUtensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "OrderUtensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "OrderUtensil",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "OrderUtensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "OrderUtensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "OrderUtensil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtensilID",
                table: "OrderUtensil",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "OrderActivity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "OrderActivity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "OrderActivity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "OrderActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "OrderActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "OrderActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "IngredientGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "IngredientGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "IngredientGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "IngredientGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "IngredientGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "IngredientGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "Ingredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Ingredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Ingredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "HotPotUtensilType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HotPotUtensilType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "HotPotUtensilType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "HotPotUtensilType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "HotPotUtensilType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "HotPotUtensilType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "HotPotType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HotPotType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "HotPotType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "HotPotType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "HotPotType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "HotPotType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "HotPotPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HotPotPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "HotPotPackage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "HotPotPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "HotPotPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "HotPotPackage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "HotPotIngredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HotPotIngredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "HotPotIngredient",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "HotPotIngredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "HotPotIngredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "HotPotIngredient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "HotPot",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HotPot",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "HotPot",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "HotPot",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "HotPot",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "HotPot",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhatCuoi",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayCapNhat",
                table: "ActivityType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "ActivityType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXoa",
                table: "ActivityType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiCapNhatID",
                table: "ActivityType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiTaoID",
                table: "ActivityType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiXoaID",
                table: "ActivityType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderUtensil_UtensilID",
                table: "OrderUtensil",
                column: "UtensilID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUtensil_Utensil_UtensilID",
                table: "OrderUtensil",
                column: "UtensilID",
                principalTable: "Utensil",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderUtensil_Utensil_UtensilID",
                table: "OrderUtensil");

            migrationBuilder.DropIndex(
                name: "IX_OrderUtensil_UtensilID",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "UtensilDetai");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Utensil");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "UntensilPackage");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "UtensilID",
                table: "OrderUtensil");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "OrderActivity");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "IngredientGroup");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "HotPotUtensilType");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "HotPotType");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "HotPotPackage");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "HotPotIngredient");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "HotPot");

            migrationBuilder.DropColumn(
                name: "NgayCapNhatCuoi",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "NgayCapNhat",
                table: "ActivityType");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "ActivityType");

            migrationBuilder.DropColumn(
                name: "NgayXoa",
                table: "ActivityType");

            migrationBuilder.DropColumn(
                name: "NguoiCapNhatID",
                table: "ActivityType");

            migrationBuilder.DropColumn(
                name: "NguoiTaoID",
                table: "ActivityType");

            migrationBuilder.DropColumn(
                name: "NguoiXoaID",
                table: "ActivityType");
        }
    }
}
