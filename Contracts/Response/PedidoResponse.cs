using System;

namespace Contracts.Response
{
    public class PedidoResponse
    {
        public int id { get; set; }
        public DateTime data { get; set; } = DateTime.UtcNow;
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
    }
}
