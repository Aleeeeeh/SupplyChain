using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaSupplyChain.Migrations
{
    public partial class configDataEHora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Saidas");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Entradas");

            migrationBuilder.RenameColumn(
                name: "DataSaida",
                table: "Saidas",
                newName: "DataEHora");

            migrationBuilder.RenameColumn(
                name: "DataEntrada",
                table: "Entradas",
                newName: "DataEHora");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataEHora",
                table: "Saidas",
                newName: "DataSaida");

            migrationBuilder.RenameColumn(
                name: "DataEHora",
                table: "Entradas",
                newName: "DataEntrada");

            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "Saidas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "Entradas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
