using Domain.Core.Entities.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Core.Entities.Pedido
{
    public class Pedido : IAggregateBase
    {
        public long Id { get; set; }
        public Nome? Nome { get; private set; }
        public Quantidade? Quantidade { get; private set; }
        public DateTime pedidoData { get; private set; }
        public Valor? Valor { get; private set; }
    }
}
