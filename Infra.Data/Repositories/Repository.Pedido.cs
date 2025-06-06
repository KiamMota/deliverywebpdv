using System;
using Domain.Core.Entities;

namespace Infra.Data.Repositories
{
    public interface PedidoRepository
    {
        bool SetPedido(Pedido pedido);
        Pedido SelectPedidoAll();
        Pedido SelectPedidoById(int id);
        bool PutPedidoById(int id);
        bool DeletePedidoById(int id);
    }
}
