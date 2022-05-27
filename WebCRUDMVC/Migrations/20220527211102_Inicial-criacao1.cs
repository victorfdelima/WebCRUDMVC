using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUDMVC.Migrations
{
    public partial class Inicialcriacao1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Número da OAB",
                table: "Advogados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Número da OAB",
                table: "Advogados");
        }
    }
}
