using LojaVirtualAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace LojaVirtualAPI.Context
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) : base(options)
        {
        }

        public DbSet<Loja>? Lojas { get; set; }
        public DbSet<Venda>? Vendas { get; set; }
        public DbSet<ItemVenda>? ItensVenda { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
    }
}
