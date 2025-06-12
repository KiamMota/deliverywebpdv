using Contracts.PedidoContracts.Base;
using System.ComponentModel.DataAnnotations;

namespace Contracts.PedidoContracts.Request
{
    public class PedidoRequest : PedidoBase
    {
        public DateTime data { get; set; }
        [Required]
        public string nomePedido { get; set; } = "";
        [Required]
        public decimal valorPedido { get; set; }
        [Required]
        public int quantidadePedido { get; set; }
    }
}