using Domain.Core.Entities;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;

namespace AppService.UseCases
{
    public interface IProcessPedido
    {
        /* retorna o pedidoData */
        int SalvarPedido(PedidoRequest pedido);
        /* retorna o objeto */
        PedidoResponse? PegarPedidoById(int id);
        /* predicate */
        PedidoResponse? PegarPedidoByNome(string pedido_nome);

        bool AtualizarPedidoById(PedidoRequest Atualizado, int id);
        IList<PedidoResponse> PegarPedidoAll();
        /* predicate */
        bool RemoverPedidoById(int id);
    }
}

