using Domain.Core.Interfaces.Entities.Pedido;
using System.ComponentModel.DataAnnotations;

namespace Contracts.PedidoContracts.Base
{
    public class PedidoBase : IPedido
    {
        [Required]
        public DateTime data { get; set; }
        [Key]

        public int id { get; set; }
        [Required]

        public string nome { get; set; } = "";
        [Required]
        public decimal valor { get; set; }
        [Range(1, 9999)]
        public int quantidade { get; set; }
    }
}
