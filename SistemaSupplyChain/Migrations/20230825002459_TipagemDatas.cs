using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaSupplyChain.Migrations
{
    public partial class TipagemDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Saidas");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Entradas");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataSaida",
                table: "Saidas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEntrada",
                table: "Entradas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataSaida",
                table: "Saidas");

            migrationBuilder.DropColumn(
                name: "DataEntrada",
                table: "Entradas");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Saidas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Entradas",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
