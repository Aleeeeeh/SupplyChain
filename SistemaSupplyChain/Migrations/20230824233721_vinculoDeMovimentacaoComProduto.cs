using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaSupplyChain.Migrations
{
    public partial class vinculoDeMovimentacaoComProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Produtos_IdProdutoId",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Saidas_Produtos_IdProdutoId",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Saidas_IdProdutoId",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_IdProdutoId",
                table: "Entradas");

            migrationBuilder.RenameColumn(
                name: "IdProdutoId",
                table: "Saidas",
                newName: "ProdutoID");

            migrationBuilder.RenameColumn(
                name: "IdProdutoId",
                table: "Entradas",
                newName: "ProdutoID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Produtos_ProdutoID",
                table: "Entradas",
                column: "ProdutoID",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saidas_Produtos_ProdutoID",
                table: "Saidas",
                column: "ProdutoID",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entradas_Produtos_ProdutoID",
                table: "Entradas");

            migrationBuilder.DropForeignKey(
                name: "FK_Saidas_Produtos_ProdutoID",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Saidas_ProdutoID",
                table: "Saidas");

            migrationBuilder.DropIndex(
                name: "IX_Entradas_ProdutoID",
                table: "Entradas");

            migrationBuilder.RenameColumn(
                name: "ProdutoID",
                table: "Saidas",
                newName: "IdProdutoId");

            migrationBuilder.RenameColumn(
                name: "ProdutoID",
                table: "Entradas",
                newName: "IdProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Saidas_IdProdutoId",
                table: "Saidas",
                column: "IdProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Entradas_IdProdutoId",
                table: "Entradas",
                column: "IdProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entradas_Produtos_IdProdutoId",
                table: "Entradas",
                column: "IdProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Saidas_Produtos_IdProdutoId",
                table: "Saidas",
                column: "IdProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
