using Domain.Core.Repo.Interfaces;
using Domain.Core.Entities;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Repositories
{
    public class RepoPedido
    {
        private readonly ICrudBase<Pedido> _crudPedido;
        public RepoPedido(ICrudBase<Pedido> _crudPedido)
        {
            this._crudPedido = _crudPedido;
        }

        public bool Save(Pedido estabelecimento)
        {
            return _crudPedido.Create(estabelecimento);
        }

        public IList<Pedido> GetAll()
        {
            return _crudPedido.ReadAll();
        }
        public Pedido GetById(int id)
        {
            return _crudPedido.ReadById(id);
        }

        public bool DeleteById(int id)
        {
            return _crudPedido.DeleteById(id);
        }

        public bool UpdateById(Pedido novo, int id)
        {
            return _crudPedido.UpdateById(novo, id);
        }
    }
}