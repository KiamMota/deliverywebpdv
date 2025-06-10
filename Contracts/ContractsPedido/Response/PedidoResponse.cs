using System;

namespace Contracts.PedidoContracts.Response
{
    public class PedidoResponse
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string nome { get; set; } = "";
        public decimal valor { get; set; }
        public int quantidade { get; set; }
    }
}
