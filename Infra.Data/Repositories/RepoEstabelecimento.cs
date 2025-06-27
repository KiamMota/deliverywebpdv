using Domain.Core.Entities;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Repositories
{
    public class RepoEstabelecimento 
    {
        private readonly ICrudBase<Estabelecimento> _crudEstabelecimento;
        public RepoEstabelecimento(ICrudBase<Estabelecimento> _userCrud)
        {
            this._crudEstabelecimento = _userCrud;
        }

        public bool Save(Estabelecimento estabelecimento)
        {
            return _crudEstabelecimento.Create(estabelecimento);
        }

        public IList<Estabelecimento> GetAll()
        {
            return _crudEstabelecimento.ReadAll();
        }
        public Estabelecimento GetById(int id)
        {
            return _crudEstabelecimento.ReadById(id);
        }
        
        public bool DeleteById(int id)
        {
            return _crudEstabelecimento.DeleteById(id);
        }

        public bool UpdateById(Estabelecimento novo, int id)
        {
            return _crudEstabelecimento.UpdateById(novo, id);
        }
        
    }
}
