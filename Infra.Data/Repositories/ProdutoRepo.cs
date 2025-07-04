using Domain.Core.Entities.Produto;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories
{
    public class ProdutoRepo : IProdutoRepo
    {
        private readonly ICrudBase<Produto, ProdutoDb> _crProduto;
        public ProdutoRepo(ICrudBase<Produto, ProdutoDb> crProduto)
        {
            _crProduto = crProduto ?? throw new ArgumentNullException(nameof(crProduto), "O repositório não pode ser nulo.");
        }
        public bool DeleteById(long id)
        {
            return _crProduto.DeleteById(id);
        }

        public Produto? GetById(long id)
        {
            return _crProduto.ReadById(id);
        }

        public bool PutById(Produto entity, long id)
        {
            return _crProduto.UpdateById(entity, id);
        }

        public IList<Produto> ReadAll()
        {
            return _crProduto.ReadAll() ?? new List<Produto>();
        }

        public long Salvar(Produto entity)
        {
            return _crProduto.Create(entity);
        }
    }
}
