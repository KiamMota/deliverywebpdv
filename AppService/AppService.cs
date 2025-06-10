using Contracts.Response;
using Contracts.Request;
using Domain.Core.Validation;
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
        public int SalvarPedido(PedidoRequest pedido) => _repopedido.SalvarPedido(ObjectsConverter.FromPedidoRequest(pedido));
        
        public PedidoResponse? PegarPedidoById(int id) => ObjectsConverter.ToPedidoResponse(_repopedido.SelectPedidoById(id));

        public IList<PedidoResponse> PegarPedidoAll()
        {
            //faz uma lista de pedidoresponse 
            List<PedidoResponse> pedidoResponses = new();
            var data = _repopedido.SelectPedidoAll();

            foreach (var itemData in data)
            {
                var pedidoResponse = ObjectsConverter.ToPedidoResponse(itemData);
                pedidoResponses.Add(pedidoResponse);
            }
            return pedidoResponses;
        }

        public bool AlterarPedidoById(PedidoRequest Atualizado, int id) {
            return _repopedido.PutPedidoById(ObjectsConverter.FromPedidoRequest(Atualizado), id);
        }
        public bool RemoverPedidoById(int id)
        {
            return _repopedido.DeletePedidoById(id);
        }

    }
}