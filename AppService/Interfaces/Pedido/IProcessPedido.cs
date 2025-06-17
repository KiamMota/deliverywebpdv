using Domain.Core.Entities;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;

namespace AppService.Interfaces.Pedido
{
    public interface IProcessPedido
    {
        /* retorna o pedidoData */
        Task<int> SalvarPedido(PedidoRequest pedido);
        /* retorna o objeto */
        Task<PedidoResponse?> PegarPedidoById(int id);
        /* predicate */
        Task<PedidoResponse?> PegarPedidoByNome(string pedido_nome);

        Task<bool> AlterarPedidoById(PedidoRequest Atualizado, int id);
        Task<IList<PedidoResponse>> PegarPedidoAll();
        /* predicate */
        Task<bool> RemoverPedidoById(int id);
    }
}

