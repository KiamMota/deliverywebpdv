using Domain.Core.Interfaces.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.Entities
{
    public class Pedido : IPedido
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nomePedido { get; set; } = "";
        [Required]
        public decimal valorPedido { get; set; }
        [Required]
        [Range(1, 99)]
        public int quantidadePedido { get; set; }
    }
}
