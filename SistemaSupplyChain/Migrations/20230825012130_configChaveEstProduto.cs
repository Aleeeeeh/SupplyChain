using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaSupplyChain.Migrations
{
    public partial class configChaveEstProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Saidas_ProdutoID",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_ProdutoID",
                table: "Entradas");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_ProdutoID",
                table: "Saidas",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_ProdutoID",
                table: "Entradas",
                column: "ProdutoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Saidas_ProdutoID",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_ProdutoID",
                table: "Entradas");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_ProdutoID",
                table: "Saidas",
                column: "ProdutoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_ProdutoID",
                table: "Entradas",
                column: "ProdutoID",
                unique: true);
        }
    }
}
