using Domain.Core.Repo.Interfaces;
using AppService.Interfaces.Pedido;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Delivery.Web.Pdv.Helper;
using AppService.UseCases;

namespace AppService.Pedido
{
    public class ProcessPedido : IProcessPedido
    {
        private readonly IPedidoValidation _validation;
        private readonly IRepoPedido _repoPedido;
        public ProcessPedido(IRepoPedido Repo, IPedidoValidation _validation)
        {
            _repoPedido = Repo;
            this._validation = _validation;
        }
        public int SalvarPedido(PedidoRequest pedido)
        {
            pedido.pedidoData = DateTime.UtcNow;
            DwpHelper.Normalizar(pedido.pedidoNome);
            return _repoPedido.SalvarPedido(PedidoMapper.FromPedidoRequest(pedido));
        }
        public PedidoResponse? PegarPedidoById  (int id)
        {
            var GetPedido = _repoPedido.SelectPedidoById(id);
            return PedidoMapper.ToPedidoResponse(GetPedido);
        }
        public IList<PedidoResponse> PegarPedidoAll()
        {
            /* criando uma lista do tipo pedidoresponse e instanciando ela */
            List<PedidoResponse> pedidoResponses = new();
            /* criando uma ilist do tipo pedido 'data' e atribuind todos os elementos do retorno do
             repository para ela
            */
            IList<Domain.Core.Entities.Pedido> data = _repoPedido.SelectPedidoAll();
            foreach (var itemData in data)
            {
               pedidoResponses.Add(PedidoMapper.ToPedidoResponse(itemData));
            }
            return pedidoResponses;
        }

        public PedidoResponse? PegarPedidoByNome(string nome)
        {
            var pedidoByNome = PedidoMapper.ToPedidoResponse(_repoPedido.SelectPedidoByNome(nome));
            return pedidoByNome;
        }

        public bool AtualizarPedidoById   (PedidoRequest Atualizado, int id)
        {
            var FromId = _repoPedido.PutPedidoById(PedidoMapper.FromPedidoRequest(Atualizado), id);
            return FromId;
        }
        public bool RemoverPedidoById(int id)
        {
            return _repoPedido.DeletePedidoById(id);
        }

    }
}