using Domain.Core.Interfaces.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.Entities
{
    public class Pedido : IPedido
    {
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
