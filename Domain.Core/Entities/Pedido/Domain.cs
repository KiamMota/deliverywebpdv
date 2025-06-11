using Domain.Core.Interfaces.Entities.Pedido;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.Entities.Pedido
{
    public class Domain : IPedido
    {

        public DateTime data { get; set; } = DateTime.UtcNow;
        public int id { get; set; }
        public string nome { get; set; } = "";
        public decimal valor { get; set; }
        public int quantidade { get; set; }
    }
}
