using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_CustomerOrders_CustomerOrderID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_Inventories_InventoryID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnProduct_Products_ProductID",
                table: "ReturnProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_Customers_CustomerID",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_Inventories_InventoryID",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_SupplierOrders_SupplierOrderID",
                table: "ReturnSupplierOrders");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierOrderID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InventoryID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderedOn",
                table: "ReturnSupplierOrders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "ReturnSupplierOrders",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ReturnProduct",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "ReturnProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerOrderID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_CustomerOrders_CustomerOrderID",
                table: "ReturnCustomerOrder",
                column: "CustomerOrderID",
                principalTable: "CustomerOrders",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_Inventories_InventoryID",
                table: "ReturnCustomerOrder",
                column: "InventoryID",
                principalTable: "Inventories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnProduct_Products_ProductID",
                table: "ReturnProduct",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_Customers_CustomerID",
                table: "ReturnSupplierOrders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_Inventories_InventoryID",
                table: "ReturnSupplierOrders",
                column: "InventoryID",
                principalTable: "Inventories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_SupplierOrders_SupplierOrderID",
                table: "ReturnSupplierOrders",
                column: "SupplierOrderID",
                principalTable: "SupplierOrders",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_CustomerOrders_CustomerOrderID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_Inventories_InventoryID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnProduct_Products_ProductID",
                table: "ReturnProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_Customers_CustomerID",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_Inventories_InventoryID",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ReturnSupplierOrders_SupplierOrders_SupplierOrderID",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropColumn(
                name: "OrderedOn",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "ReturnSupplierOrders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ReturnProduct");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierOrderID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "ReturnSupplierOrders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "ReturnProduct",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InventoryID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerOrderID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_CustomerOrders_CustomerOrderID",
                table: "ReturnCustomerOrder",
                column: "CustomerOrderID",
                principalTable: "CustomerOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_Inventories_InventoryID",
                table: "ReturnCustomerOrder",
                column: "InventoryID",
                principalTable: "Inventories",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnProduct_Products_ProductID",
                table: "ReturnProduct",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_Customers_CustomerID",
                table: "ReturnSupplierOrders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_Inventories_InventoryID",
                table: "ReturnSupplierOrders",
                column: "InventoryID",
                principalTable: "Inventories",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnSupplierOrders_SupplierOrders_SupplierOrderID",
                table: "ReturnSupplierOrders",
                column: "SupplierOrderID",
                principalTable: "SupplierOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
