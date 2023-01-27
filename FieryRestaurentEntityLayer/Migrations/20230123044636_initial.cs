using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieryRestaurent.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Suppliers_SupplierID",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Buisnesses_Suppliers_SupplierID",
                table: "Buisnesses");

            migrationBuilder.DropIndex(
                name: "IX_Buisnesses_SupplierID",
                table: "Buisnesses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_SupplierID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Buisnesses");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuisnessID",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddressId",
                table: "Suppliers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_BuisnessID",
                table: "Suppliers",
                column: "BuisnessID");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Addresses_AddressId",
                table: "Suppliers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_Buisnesses_BuisnessID",
                table: "Suppliers",
                column: "BuisnessID",
                principalTable: "Buisnesses",
                principalColumn: "BuisnessID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Addresses_AddressId",
                table: "Suppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_Buisnesses_BuisnessID",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_AddressId",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Suppliers_BuisnessID",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "BuisnessID",
                table: "Suppliers");

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierID",
                table: "Buisnesses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierID",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Buisnesses_SupplierID",
                table: "Buisnesses",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_SupplierID",
                table: "Addresses",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Suppliers_SupplierID",
                table: "Addresses",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buisnesses_Suppliers_SupplierID",
                table: "Buisnesses",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "SupplierID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
