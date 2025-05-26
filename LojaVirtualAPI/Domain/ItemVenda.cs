using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtualAPI.Domain
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Venda")]
        public int IdVenda { get; set; }
        [Required]
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal ValorTotal { get; set; }

        public Produto? Produto { get; set; }
        public Venda? Venda { get; set; }
    }
}
