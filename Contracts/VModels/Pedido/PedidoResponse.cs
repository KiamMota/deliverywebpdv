using System;

namespace Contracts.VModels.Pedido
{
    public class PedidoResponse
    {
        public long Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; } = "";
        public decimal Valor { get; set; }
        public short Quantidade { get; set; }
    }
}
