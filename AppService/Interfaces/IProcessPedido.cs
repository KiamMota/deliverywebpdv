using Contracts.Response;
using Domain.Core.Entities;

namespace AppService.Interfaces;

public interface IProcessPedido
{
    /* retorna o id */
    int SalvarPedido(Pedido pedido);
    /* retorna o objeto */
    PedidoResponse? PegarPedidoById(int id);
    /* predicate */
    bool AlterarPedidoById(Pedido Atualizado, int id);
    /* predicate */
    bool RemoverPedidoById(int id);
}
