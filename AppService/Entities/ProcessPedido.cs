using Contracts.PedidoContracts.Request;
using Contracts.PedidoContracts.Response;
using AppService.UseCases.Interfaces;
using AppService.Mappers;
using Domain.Core.Entities;
using Infra.Data.Repositories.Interfaces;

namespace AppService.UseCases
{
    public class ProcessPedido : IProcessPedido
    {
        private readonly ICrudBase<Pedido> _CrudPedido;
        public ProcessPedido(ICrudBase<Pedido> crud)
        {
            this._CrudPedido = crud;
        }
        public long? SalvarPedido(PedidoRequest pedido)
        {
            pedido.pedidoData = DateTime.UtcNow;
            PedidoHelper.Normalizar(pedido.pedidoNome);
            return _CrudPedido.Create(PedidoMapper.FromPedidoRequest(pedido));
        }
        public PedidoResponse? PegarPedidoById(int id)
        {
            var GetPedido = _CrudPedido.ReadById(id);
            return PedidoMapper.ToPedidoResponse(GetPedido);
        }
        public IList<PedidoResponse>? PegarPedidoAll()
        {
            var GetAll = _CrudPedido.ReadAll();
            List<PedidoResponse> pedidoResp = new();

            foreach (var item in GetAll)
            {
                var conversion = PedidoMapper.ToPedidoResponse(item);
                pedidoResp.Add(conversion);
            }

            return pedidoResp;
        }

        public PedidoResponse? PegarPedidoByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool? AtualizarPedidoById(PedidoRequest Atualizado, int id)
        {
            var FromId = _CrudPedido.UpdateById(PedidoMapper.FromPedidoRequest(Atualizado), id);
            return FromId;
        }
        public bool RemoverPedidoById(int id)
        {
            return _CrudPedido.DeleteById(id);
        }

    }
}