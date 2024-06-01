using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotPotToYou.Infrastructure.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "UtensilDetai",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "UtensilDetai",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "UtensilDetai",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "UtensilDetai",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "UtensilDetai",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "UtensilDetai",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Utensil",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Utensil",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Utensil",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Utensil",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Utensil",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "Utensil",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "User",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "User",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "User",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "User",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "User",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "User",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "UntensilPackage",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "UntensilPackage",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "UntensilPackage",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "UntensilPackage",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "UntensilPackage",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "UntensilPackage",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Role",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Role",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Role",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Role",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Role",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "Role",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Payment",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Payment",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Payment",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Payment",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Payment",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "Payment",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "OrderUtensil",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "OrderUtensil",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "OrderUtensil",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "OrderUtensil",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "OrderUtensil",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "OrderUtensil",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "OrderActivity",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "OrderActivity",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "OrderActivity",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "OrderActivity",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "OrderActivity",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "OrderActivity",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Order",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Order",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Order",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Order",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Order",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "Order",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "IngredientGroup",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "IngredientGroup",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "IngredientGroup",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "IngredientGroup",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "IngredientGroup",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "IngredientGroup",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Ingredient",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Ingredient",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Ingredient",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Ingredient",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Ingredient",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "Ingredient",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "HotPotUtensilType",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "HotPotUtensilType",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "HotPotUtensilType",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "HotPotUtensilType",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "HotPotUtensilType",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotUtensilType",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "HotPotType",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "HotPotType",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "HotPotType",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "HotPotType",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "HotPotType",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "HotPotType",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "HotPotPackage",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "HotPotPackage",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "HotPotPackage",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "HotPotPackage",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "HotPotPackage",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotPackage",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "HotPotIngredient",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "HotPotIngredient",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "HotPotIngredient",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "HotPotIngredient",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "HotPotIngredient",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPotIngredient",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "HotPot",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "HotPot",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "HotPot",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "HotPot",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "HotPot",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "HotPot",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "Customer",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "Customer",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "Customer",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "Customer",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "Customer",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhatCuoi",
                table: "Customer",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "NguoiXoaID",
                table: "ActivityType",
                newName: "UpdateByID");

            migrationBuilder.RenameColumn(
                name: "NguoiTaoID",
                table: "ActivityType",
                newName: "DeleteByID");

            migrationBuilder.RenameColumn(
                name: "NguoiCapNhatID",
                table: "ActivityType",
                newName: "CreateByID");

            migrationBuilder.RenameColumn(
                name: "NgayXoa",
                table: "ActivityType",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "ActivityType",
                newName: "DeleteDate");

            migrationBuilder.RenameColumn(
                name: "NgayCapNhat",
                table: "ActivityType",
                newName: "CreateDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "UtensilDetai",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "UtensilDetai",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "UtensilDetai",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "UtensilDetai",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "UtensilDetai",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "UtensilDetai",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Utensil",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Utensil",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Utensil",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Utensil",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Utensil",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Utensil",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "User",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "User",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "User",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "User",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "User",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "User",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "UntensilPackage",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "UntensilPackage",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "UntensilPackage",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "UntensilPackage",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "UntensilPackage",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "UntensilPackage",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Role",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Role",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Role",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Role",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Role",
                newName: "NgayCapNhat");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Role",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Payment",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Payment",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Payment",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Payment",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Payment",
                newName: "NgayCapNhat");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Payment",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "OrderUtensil",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "OrderUtensil",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "OrderUtensil",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "OrderUtensil",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "OrderUtensil",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "OrderUtensil",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "OrderActivity",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "OrderActivity",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "OrderActivity",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "OrderActivity",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "OrderActivity",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "OrderActivity",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Order",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Order",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Order",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Order",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Order",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Order",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "IngredientGroup",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "IngredientGroup",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "IngredientGroup",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "IngredientGroup",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "IngredientGroup",
                newName: "NgayCapNhat");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "IngredientGroup",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Ingredient",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Ingredient",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Ingredient",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Ingredient",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Ingredient",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Ingredient",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "HotPotUtensilType",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "HotPotUtensilType",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "HotPotUtensilType",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "HotPotUtensilType",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "HotPotUtensilType",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "HotPotUtensilType",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "HotPotType",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "HotPotType",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "HotPotType",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "HotPotType",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "HotPotType",
                newName: "NgayCapNhat");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "HotPotType",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "HotPotPackage",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "HotPotPackage",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "HotPotPackage",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "HotPotPackage",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "HotPotPackage",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "HotPotPackage",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "HotPotIngredient",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "HotPotIngredient",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "HotPotIngredient",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "HotPotIngredient",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "HotPotIngredient",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "HotPotIngredient",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "HotPot",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "HotPot",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "HotPot",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "HotPot",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "HotPot",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "HotPot",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Customer",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "Customer",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "Customer",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "Customer",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Customer",
                newName: "NgayCapNhatCuoi");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "Customer",
                newName: "NguoiCapNhatID");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "ActivityType",
                newName: "NgayXoa");

            migrationBuilder.RenameColumn(
                name: "UpdateByID",
                table: "ActivityType",
                newName: "NguoiXoaID");

            migrationBuilder.RenameColumn(
                name: "DeleteDate",
                table: "ActivityType",
                newName: "NgayTao");

            migrationBuilder.RenameColumn(
                name: "DeleteByID",
                table: "ActivityType",
                newName: "NguoiTaoID");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "ActivityType",
                newName: "NgayCapNhat");

            migrationBuilder.RenameColumn(
                name: "CreateByID",
                table: "ActivityType",
                newName: "NguoiCapNhatID");
        }
    }
}
