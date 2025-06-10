using Contracts.Base;

namespace Contracts.Request
{
    public class PedidoRequest : PedidoBase
    {
        public DateTime data { get; set; } = DateTime.UtcNow;
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
    }
}
