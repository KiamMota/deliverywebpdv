using Domain.Core.Entities;
using Domain.Core.Interfaces;


namespace Domain.Core.Interfaces.AppService
{
    public interface IProcessPedido
    {
        /* retorna o id */
        int SalvarPedido(Pedido pedido);
        /* retorna o objeto */
        Pedido? PegarPedidoById(int id);
        /* predicate */
        bool AlterarPedidoById(Pedido Atualizado, int id);
        /* predicate */
        bool RemoverPedidoById(int id);
    }
}
