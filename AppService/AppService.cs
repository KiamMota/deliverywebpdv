using Contracts.Response;
using Contracts.Request;
using Domain.Core.Repo.Interfaces;
using AppService.Interfaces;
using Domain.Core.Entities.Pedido;


namespace AppService
{
    public class ApsPedido : IProcessPedido
    {
        private PedidoValidation _validation = new PedidoValidation();
        private IRepoPedido _repoPedido;
        public ApsPedido(IRepoPedido Repo) { _repoPedido = Repo; }
        public int SalvarPedido(PedidoRequest pedido) => _repoPedido.SalvarPedido(ObjectsConverter.FromPedidoRequest(pedido));
        public PedidoResponse? PegarPedidoById(int id) => ObjectsConverter.ToPedidoResponse(_repoPedido.SelectPedidoById(id));

        public IList<PedidoResponse> PegarPedidoAll()
        {
            /* criando uma lista do tipo pedidoresponse e instanciando ela */
            List<PedidoResponse> pedidoResponses = new();
            /* criando uma ilist do tipo pedido 'data' e atribuind todos os elementos do retorno do
             repository para ela
            */
            IList<DomainPedido> data = _repoPedido.SelectPedidoAll();
            foreach (var itemData in data)
            {
                pedidoResponses.Add(ObjectsConverter.ToPedidoResponse(itemData));
            }
            return pedidoResponses;
        }

        public PedidoResponse? PegarPedidoByNome(string nome)
        {
            var pedidoByNome = ObjectsConverter.ToPedidoResponse(_repoPedido.SelectPedidoByNome(nome));
            return pedidoByNome;
        }

        public bool AlterarPedidoById(PedidoRequest Atualizado, int id)
        {
            return _repoPedido.PutPedidoById(ObjectsConverter.FromPedidoRequest(Atualizado), id);
        }
        public bool RemoverPedidoById(int id)
        {
            return _repoPedido.DeletePedidoById(id);
        }

    }
}