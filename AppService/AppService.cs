using Contracts.Response;
using Contracts.Request;
using Domain.Core.Entities;
using Domain.Core.Validation;
using Domain.Core.Repo.Interfaces;
using AppService.Interfaces;


namespace AppService
{
    public class ApsPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        private IRepoPedido _repopedido;

        public ApsPedido(IRepoPedido Repo) { _repopedido = Repo; }
        public int SalvarPedido(PedidoRequest pedido) => _repopedido.SalvarPedido(ObjectsConverter.FromPedidoRequest(pedido));
        public PedidoResponse? PegarPedidoById(int id) => ObjectsConverter.ToPedidoResponse(_repopedido.SelectPedidoById(id));

        public IList<PedidoResponse> PegarPedidoAll()
        {
            /* criando uma lista do tipo pedidoresponse e instanciando ela */
            List<PedidoResponse> pedidoResponses = new();
            /* criando uma ilist do tipo pedido 'data' e atribuind todos os elementos do retorno do
             repository para ela
            */
            IList<Pedido> data = _repopedido.SelectPedidoAll();
            foreach (var itemData in data) pedidoResponses.Add(ObjectsConverter.ToPedidoResponse(itemData));
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