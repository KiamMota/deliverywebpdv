using Domain.Core.Pedido.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Contracts.PedidoContracts.Base
{
    public class PedidoBase : IPedido
    {
        public DateTime pedidoData { get; set; }
        public int pedidoId { get; set; }
        public string pedidoNome { get; set; } = "";
        public decimal pedidoValor { get; set; }
        public int pedidoQuantidade { get; set; }
    }
}
