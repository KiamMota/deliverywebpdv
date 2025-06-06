using Contracts.Request;
using Contracts.Response;

namespace AppService.Interfaces
{
    public interface IProcessPedido
    {
        /* retorna o id */
        int SalvarPedido(PedidoRequest pedido);
        /* retorna o objeto */
        PedidoResponse PegarPedidoById(int id);
        /* predicate */
        bool AlterarPedidoById(int id);
        /* predicate */
        bool RemoverPedidoById(int id);
    }
}
