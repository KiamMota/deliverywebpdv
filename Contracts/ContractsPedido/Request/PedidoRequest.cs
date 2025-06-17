using Contracts.PedidoContracts.Base;
using System.ComponentModel.DataAnnotations;

namespace Contracts.PedidoContracts.Request
{
    public class PedidoRequest : PedidoBase
    {
        public DateTime pedidoData { get; set; }
        [Required]
        public string pedidoNome { get; set; } = "";
        [Required]
        public decimal pedidoValor{ get; set; }
        [Required]
        public int pedidoQuantidade { get; set; }
    }
}