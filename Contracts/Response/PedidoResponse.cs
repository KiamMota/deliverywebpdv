using System;

namespace Contracts.Response
{
    public class PedidoResponse
    {
        int id { get; set; }
        public string nomePedido { get; set; } = "";
        public decimal valorPedido { get; set; }
        public int quantidadePedido { get; set; }
    }
}
