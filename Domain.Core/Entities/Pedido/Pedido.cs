using Domain.Core.Entities.Interfaces;

namespace Domain.Core.Entities.Pedido
{
    public sealed class Pedido : IAggregateRoot, IEntity<long>
    {
        public long Id { get; set; }
        public long ProdutoId { get; private set; }
        public long ClienteId { get; private set; }

        public Pedido(long ProdutoId, long ClienteId)
        {
            this.ProdutoId = ProdutoId;
            this.ClienteId = ClienteId;
        }
    }
}
