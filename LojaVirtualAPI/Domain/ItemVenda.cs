using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LojaVirtualAPI.Domain
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Venda")]
        [JsonIgnore]
        public int IdVenda { get; set; }
        [Required]
        [ForeignKey("Produto")]
        [JsonIgnore]
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
