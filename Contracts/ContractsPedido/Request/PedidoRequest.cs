using Contracts.PedidoContracts.Base;

namespace Contracts.PedidoContracts.Request
{
    public class PedidoRequest : PedidoBase
    {
        public DateTime data { get; set; }
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
    }
}
