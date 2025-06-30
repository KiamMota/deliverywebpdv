using System;

namespace Contracts.VModels.ContractsPedido.Response
{
    public class PedidoResponse
    {
        public long id { get; set; }
        public DateTime data { get; set; }
        public string nome { get; set; } = "";
        public decimal valor { get; set; }
        public int quantidade { get; set; }
    }
}
