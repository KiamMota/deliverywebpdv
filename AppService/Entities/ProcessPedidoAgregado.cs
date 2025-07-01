using AppService.UseCases.Interfaces;
using AppService.Mappers;
using Contracts.VModels.Pedido;
using Domain.Core.Entities;
using Infra.Data.Repositories;
using Infra.Data.Repositories.Interfaces;

namespace AppService.UseCases
{
    public class ProcessPedidoAgregado : IProcessPedido
    {
        private readonly ICrudBase<Domain.Core.Entities.Pedido, Id, Name> _CrudPedido;
        public ProcessPedidoAgregado(ICrudBase<Domain.Core.Entities.Pedido, Id, Name> crud)
        {
            this._CrudPedido = crud;
        }
        public long? SalvarPedido(PedidoRequest pedido)
        {
            pedido.Data = DateTime.UtcNow;
            PedidoHelper.Normalizar(pedido.Name);
            var data = _CrudPedido.Create(PedidoMapper.FromPedidoRequest(pedido));
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
            _CrudPedido.ReadByString(name: nome);
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