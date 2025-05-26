using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaVirtualAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjusteColunas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Produtos_ProdutoId",
                table: "ItensVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Vendas_VendaId",
                table: "ItensVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Lojas_LojaId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_LojaId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVenda_ProdutoId",
                table: "ItensVenda");

            migrationBuilder.DropIndex(
                name: "IX_ItensVenda_VendaId",
                table: "ItensVenda");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "LojaId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItensVenda");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "ItensVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_IdCliente",
                table: "Vendas",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_IdLoja",
                table: "Vendas",
                column: "IdLoja");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_IdProduto",
                table: "ItensVenda",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_IdVenda",
                table: "ItensVenda",
                column: "IdVenda");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Produtos_IdProduto",
                table: "ItensVenda",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Vendas_IdVenda",
                table: "ItensVenda",
                column: "IdVenda",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_IdCliente",
                table: "Vendas",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Lojas_IdLoja",
                table: "Vendas",
                column: "IdLoja",
                principalTable: "Lojas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Produtos_IdProduto",
                table: "ItensVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Vendas_IdVenda",
                table: "ItensVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_IdCliente",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Lojas_IdLoja",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_IdCliente",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_IdLoja",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVenda_IdProduto",
                table: "ItensVenda");

            migrationBuilder.DropIndex(
                name: "IX_ItensVenda_IdVenda",
                table: "ItensVenda");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LojaId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ItensVenda",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "ItensVenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_LojaId",
                table: "Vendas",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_ProdutoId",
                table: "ItensVenda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVenda_VendaId",
                table: "ItensVenda",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Produtos_ProdutoId",
                table: "ItensVenda",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Vendas_VendaId",
                table: "ItensVenda",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClienteId",
                table: "Vendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Lojas_LojaId",
                table: "Vendas",
                column: "LojaId",
                principalTable: "Lojas",
                principalColumn: "Id");
        }
    }
}
