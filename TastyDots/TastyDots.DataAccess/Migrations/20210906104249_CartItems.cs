using Microsoft.EntityFrameworkCore.Migrations;

namespace TastyDots.DataAccess.Migrations
{
    public partial class CartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuList_Orders_OrderId",
                table: "MenuList");

            migrationBuilder.DropIndex(
                name: "IX_MenuList_OrderId",
                table: "MenuList");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "MenuList");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "cartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cartItems_OrderId",
                table: "cartItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_cartItems_Orders_OrderId",
                table: "cartItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cartItems_Orders_OrderId",
                table: "cartItems");

            migrationBuilder.DropIndex(
                name: "IX_cartItems_OrderId",
                table: "cartItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "cartItems");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "MenuList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuList_OrderId",
                table: "MenuList",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuList_Orders_OrderId",
                table: "MenuList",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
