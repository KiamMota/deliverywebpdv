using Contracts.Base;

namespace Contracts.Request
{
    public class PedidoRequest : PedidoBase
    {
        public int id { get; set; }
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
    }
}
