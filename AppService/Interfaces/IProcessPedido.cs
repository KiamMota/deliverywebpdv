using Contracts.Request;
using Contracts.Response;

namespace AppService.Interfaces
{
    public interface IProcessPedido
    {
        PedidoResponse SalvarPedido(PedidoRequest pedido);
        PedidoResponse PegarPedidoById(int id);
        PedidoResponse AlterarPedidoById(int id);
        bool RemoverPedidoById(int id);
    }
}
