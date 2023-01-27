using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FieryRestaurent.Dal.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKey2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "Buisnesses");

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Active",
                table: "Suppliers");

            migrationBuilder.AddColumn<bool>(
                name: "Is_Active",
                table: "Buisnesses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
