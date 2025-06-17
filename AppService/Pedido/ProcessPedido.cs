using Domain.Core.Repo.Interfaces;
using AppService.Interfaces.Pedido;
using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using Delivery.Web.Pdv.Helper;

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
        public async Task<int> SalvarPedido(PedidoRequest pedido)
        {
            pedido.pedidoData = DateTime.UtcNow;
            DwpHelper.Normalizar(pedido.pedidoNome);
            return await _repoPedido.SalvarPedido(PedidoMapper.FromPedidoRequest(pedido));
        }
        public async Task<PedidoResponse?> PegarPedidoById(int id)
        {
            var GetPedido = await _repoPedido.SelectPedidoById(id);
            return PedidoMapper.ToPedidoResponse(GetPedido);
        }
        public async Task<IList<PedidoResponse>> PegarPedidoAll()
        {
            /* criando uma lista do tipo pedidoresponse e instanciando ela */
            List<PedidoResponse> pedidoResponses = new();
            /* criando uma ilist do tipo pedido 'data' e atribuind todos os elementos do retorno do
             repository para ela
            */
            IList<Domain.Core.Entities.Pedido> data = await _repoPedido.SelectPedidoAll();
            foreach (var itemData in data)
            {
               pedidoResponses.Add(PedidoMapper.ToPedidoResponse(itemData));
            }
            return await Task.FromResult<IList<PedidoResponse>>(pedidoResponses);
        }

        public async Task<PedidoResponse>? PegarPedidoByNome(string nome)
        {
            var pedidoByNome = PedidoMapper.ToPedidoResponse(await _repoPedido.SelectPedidoByNome(nome));
            return pedidoByNome;
        }

        public async Task<bool> AlterarPedidoById(PedidoRequest Atualizado, int id)
        {
            var FromId = await _repoPedido.PutPedidoById(PedidoMapper.FromPedidoRequest(Atualizado), id);
            return FromId;
        }
        public async Task<bool> RemoverPedidoById(int id)
        {
            return await _repoPedido.DeletePedidoById(id);
        }

    }
}