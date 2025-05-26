using System.ComponentModel.DataAnnotations;

namespace LojaVirtualAPI.Domain
{
    public class Loja
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(80)]
        public string? Cidade { get; set; }

        public ICollection<Venda>? Vendas { get; set; }
    }
}
