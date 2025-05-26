using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtualAPI.Domain
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [Required]
        [ForeignKey("Loja")]
        public int IdLoja { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [Required]
        public decimal ValorTotal { get; set; }
        [Required]
        public DateTime DataVenda { get; set; }
        
        // Navigation properties
        public Loja? Loja { get; set; }
        public Cliente? Cliente { get; set; }
        public ICollection<ItemVenda>? ItensVenda { get; set; }
    }
}
