using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaVirtualAPI.Domain
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string? Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
    }
}
