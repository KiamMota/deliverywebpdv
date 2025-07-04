using Domain.Core.Entities.Pedido;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories
{
    public class PedidoRepo : IPedidoRepo
    {
        private readonly ICrudBase<Pedido, PedidoDb> _crPedido;
        public PedidoRepo(ICrudBase<Pedido, PedidoDb> crPedido)
        {
            _crPedido = crPedido ?? throw new ArgumentNullException(nameof(crPedido), "O repositório não pode ser nulo.");
        }
        public bool DeleteById(long id)
        {
            return _crPedido.DeleteById(id);
        }

        public Pedido? GetById(long id)
        {
            return _crPedido.ReadById(id) ?? throw new Exception("O ID não pode ser nulo ou não encontrado.");
        }

        public bool PutById(Pedido entity, long id)
        {
            return _crPedido.UpdateById(entity, id);
        }

        public IList<Pedido> ReadAll()
        {
            return _crPedido.ReadAll() ?? new List<Pedido>();
        }

        public long Salvar(Pedido entity)
        {
            return _crPedido.Create(entity);
        }
    }
}
