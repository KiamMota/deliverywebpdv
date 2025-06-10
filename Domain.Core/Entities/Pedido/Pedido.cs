using Domain.Core.Interfaces.Entities.Pedido;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.Entities.Pedido
{
    public class Pedido : IPedido
    {
        [Required]
        public DateTime data { get; set; } = DateTime.UtcNow;
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; } = "";
        [Required]
        public decimal valor { get; set; }
        [Required]
        [Range(1, 99)]
        public int quantidade { get; set; }
    }
}
