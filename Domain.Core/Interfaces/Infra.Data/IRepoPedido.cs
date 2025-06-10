using Domain.Core.Entities;

namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        int SalvarPedido(Pedido pedido);
        IList<Pedido> SelectPedidoAll();
        Pedido? SelectPedidoById(int id);
        Pedido? SelectPedidoByNome(string nome);
        bool PutPedidoById(Pedido Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}