using Domain.Core.Repo.Interfaces;
using AppService.Interfaces.Pedido;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Domain.Core;
using Delivery.Web.Pdv.Helper;

namespace AppService
{
    public class AppPedido : IProcessPedido
    {
        private IPedidoValidation _validation;
        private IRepoPedido _repoPedido;
        public AppPedido(IRepoPedido Repo, IPedidoValidation _validation) 
        { 
            _repoPedido = Repo;
            this._validation = _validation;
        }
        public int SalvarPedido(PedidoRequest pedido)
        {
            pedido.data = DateTime.UtcNow;
            DwpHelper.Normalizar(pedido.nomePedido);   
            return _repoPedido.SalvarPedido(ObjectsConverter.FromPedidoRequest(pedido));
        }
        public PedidoResponse? PegarPedidoById(int id)
        {
            return ObjectsConverter.ToPedidoResponse(_repoPedido.SelectPedidoById(id));
        }
        public IList<PedidoResponse> PegarPedidoAll()
        {
            /* criando uma lista do tipo pedidoresponse e instanciando ela */
            List<PedidoResponse> pedidoResponses = new();
            /* criando uma ilist do tipo pedido 'data' e atribuind todos os elementos do retorno do
             repository para ela
            */
            IList<Domain.Core.Entities.Domain> data = _repoPedido.SelectPedidoAll();
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