using Domain.Core.Entities;

namespace Infra.Data.Interfaces
{
    public interface IPedidoRepository
    {
        bool SalvarPedido(Pedido pedido);
        IList<Pedido> SelectPedidoAll();
        Pedido? SelectPedidoById(int id);
        bool PutPedidoById(Pedido Atualizado, int id);
        bool DeletePedidoById(int id);
    }
}