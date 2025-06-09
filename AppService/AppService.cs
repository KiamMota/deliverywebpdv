using Domain.Core.Validation;
using Domain.Core.Interfaces.AppService;
using Domain.Core.Entities;
using Infra.Data.Repositories;

namespace AppService
{
    public class ApsPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        private RepoPedido _repopedido;

        public ApsPedido(RepoPedido Repo)
        {
            Repo = _repopedido;
        }
        public int SalvarPedido(Pedido pedido)
        {
            return _repopedido.SalvarPedido(pedido);
        }
        public Pedido? PegarPedidoById(int id)
        {
            return _repopedido.SelectPedidoById(id);
        }
        public bool AlterarPedidoById(Pedido Atualizado, int id)
        {
            return _repopedido.PutPedidoById(Atualizado, id);
        }
        public bool RemoverPedidoById(int id)
        {
            return _repopedido.DeletePedidoById(id);
        }

    }
}