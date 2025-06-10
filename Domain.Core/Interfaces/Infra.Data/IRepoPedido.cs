using Domain.Core.Entities.Pedido;

namespace Domain.Core.Repo.Interfaces
{
    public interface IRepoPedido
    {
        int SalvarPedido(DomainPedido pedido);
        IList<DomainPedido> SelectPedidoAll();
        DomainPedido? SelectPedidoById(int id);
        DomainPedido? SelectPedidoByNome(string nome);
        bool PutPedidoById(DomainPedido Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}