using Contracts.Response;
using Contracts.Request;
using Domain.Core.Validation;
using Domain.Core.Entities;
using Infra.Data.Repositories;
using AppService.Interfaces;


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
        public int SalvarPedido(PedidoRequest pedido)
        {
            return _repopedido.SalvarPedido(pedido);
        }
        public PedidoResponse? PegarPedidoById(int id)
        {
        }
        public bool AlterarPedidoById(PedidoRequest Atualizado, int id)
        {
            return _repopedido.PutPedidoById(Atualizado, id);
        }
        public bool RemoverPedidoById(int id)
        {
            return _repopedido.DeletePedidoById(id);
        }

    }
}