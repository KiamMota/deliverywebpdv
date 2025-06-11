using Domain.Core.Entities;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;

namespace AppService.Interfaces.Pedido;

public interface IProcessPedido
{
    /* retorna o id */
    int SalvarPedido(PedidoRequest pedido);
    /* retorna o objeto */
    PedidoResponse? PegarPedidoById(int id);
    /* predicate */
    PedidoResponse? PegarPedidoByNome(string pedido_nome);

    bool AlterarPedidoById(PedidoRequest Atualizado, int id);
    IList<PedidoResponse> PegarPedidoAll();
    /* predicate */
    bool RemoverPedidoById(int id);
}
