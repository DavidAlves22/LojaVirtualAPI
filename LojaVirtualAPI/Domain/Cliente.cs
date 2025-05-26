using System.ComponentModel.DataAnnotations;

namespace LojaVirtualAPI.Domain
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(80)]
        public string? Email { get; set; }
        [Required]
        [StringLength(15)]
        public string? Telefone { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }

        public ICollection<Venda>? Vendas { get; set; }
    }
}
