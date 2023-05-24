using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropTable(
                name: "ReturnProduct");

            migrationBuilder.DropIndex(
                name: "IX_ReturnCustomerOrder_CustomerID",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "ReturnCustomerOrder");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderedOn",
                table: "ReturnCustomerOrder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "ReturnCustomerOrder",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "ReturnCustomerProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnCustomerOrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnCustomerProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnCustomerProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnCustomerProducts_ReturnCustomerOrder_ReturnCustomerOrderID",
                        column: x => x.ReturnCustomerOrderID,
                        principalTable: "ReturnCustomerOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ReturnSupplierProducts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnSupplierOrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnSupplierProducts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnSupplierProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnSupplierProducts_ReturnSupplierOrders_ReturnSupplierOrderID",
                        column: x => x.ReturnSupplierOrderID,
                        principalTable: "ReturnSupplierOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnCustomerProducts_ProductID",
                table: "ReturnCustomerProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnCustomerProducts_ReturnCustomerOrderID",
                table: "ReturnCustomerProducts",
                column: "ReturnCustomerOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSupplierProducts_ProductID",
                table: "ReturnSupplierProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnSupplierProducts_ReturnSupplierOrderID",
                table: "ReturnSupplierProducts",
                column: "ReturnSupplierOrderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReturnCustomerProducts");

            migrationBuilder.DropTable(
                name: "ReturnSupplierProducts");

            migrationBuilder.DropColumn(
                name: "OrderedOn",
                table: "ReturnCustomerOrder");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "ReturnCustomerOrder");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "ReturnCustomerOrder",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReturnProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    ReturnCustomerOrderID = table.Column<int>(type: "int", nullable: false),
                    ReturnSupplierOrderID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnProduct_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReturnProduct_ReturnCustomerOrder_ReturnCustomerOrderID",
                        column: x => x.ReturnCustomerOrderID,
                        principalTable: "ReturnCustomerOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReturnProduct_ReturnSupplierOrders_ReturnSupplierOrderID",
                        column: x => x.ReturnSupplierOrderID,
                        principalTable: "ReturnSupplierOrders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReturnCustomerOrder_CustomerID",
                table: "ReturnCustomerOrder",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnProduct_ProductID",
                table: "ReturnProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnProduct_ReturnCustomerOrderID",
                table: "ReturnProduct",
                column: "ReturnCustomerOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnProduct_ReturnSupplierOrderID",
                table: "ReturnProduct",
                column: "ReturnSupplierOrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReturnCustomerOrder_Customers_CustomerID",
                table: "ReturnCustomerOrder",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");
        }
    }
}
