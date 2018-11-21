using Microsoft.EntityFrameworkCore.Migrations;

namespace Repaso_RCV.Migrations
{
    public partial class AgregoPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Productos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                nullable: true);
        }
    }
}
