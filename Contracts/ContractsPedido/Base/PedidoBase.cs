using Domain.Core.Pedido.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Contracts.PedidoContracts.Base
{
    public class PedidoBase : IPedido
    {
        [Required]
        public DateTime pedidoData { get; set; }
        [Key]
        public int pedidoId { get; set; }
        [Required]
        public string pedidoNome { get; set; } = "";
        [Required]
        public decimal pedidoValor { get; set; }
        [Range(1, 9999)]
        public int pedidoQuantidade { get; set; }
    }
}
