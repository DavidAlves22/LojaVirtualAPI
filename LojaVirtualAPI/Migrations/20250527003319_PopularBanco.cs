using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaVirtualAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopularBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Lojas",
                columns: new[] { "Id", "Nome", "Cidade" },
                values: new object[] { 1, "Centauro", "Araras" }
            );

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome", "Email", "Telefone", "DataCadastro" },
                values: new object[] { 1, "David Alves", "david@exemplo.com", "11999999999", DateTime.UtcNow }
            );

            migrationBuilder.InsertData(
                table: "Vendas",
                columns: new[] { "Id", "IdCliente", "IdLoja", "ValorTotal", "DataVenda" },
                values: new object[] { 1, 1, 1, 199.80m, DateTime.UtcNow }
            );

            migrationBuilder.InsertData(
                table: "ItensVenda",
                columns: new[] { "Id", "IdVenda", "IdProduto", "Quantidade", "Valor", "ValorTotal" },
                values: new object[] { 1, 1, 1, 1, 2, 100.00m }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItensVenda",
                keyColumn: "Id",
                keyValue: 1
            );

            migrationBuilder.DeleteData(
                table: "Vendas",
                keyColumn: "Id",
                keyValue: 1
            );

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1
            );

            migrationBuilder.DeleteData(
                table: "Lojas",
                keyColumn: "Id",
                keyValue: 1
            );

        }
    }
}
