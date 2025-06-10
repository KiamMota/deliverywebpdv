using Domain.Core.Entities.Pedido;

namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        int SalvarPedido(Entities.Pedido.Domain pedido);
        IList<Entities.Pedido.Domain> SelectPedidoAll();
        Entities.Pedido.Domain? SelectPedidoById(int id);
        Entities.Pedido.Domain? SelectPedidoByNome(string nome);
        bool PutPedidoById(Entities.Pedido.Domain Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}