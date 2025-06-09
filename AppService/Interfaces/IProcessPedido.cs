using Contracts.Response;
using Contracts.Request;
using Domain.Core.Entities;

namespace AppService.Interfaces;

public interface IProcessPedido
{
    /* retorna o id */
    int SalvarPedido(PedidoRequest pedido);
    /* retorna o objeto */
    PedidoResponse? PegarPedidoById(int id);
    /* predicate */
    bool AlterarPedidoById(PedidoRequest Atualizado, int id);
    /* predicate */
    bool RemoverPedidoById(int id);
}
