using Domain.Core.Entities;
using Infra.Data.Repositories.Base;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Infra.Data.Repositories
{
    public class RepoUser
    {
        private readonly ICrudBase<User> _crudUser;
        public RepoUser(ICrudBase<User> _userCrud)
        {
            this._crudUser = _userCrud;
        }

        public bool Save(User user)
        {
            return _crudUser.Create(user);
        }

        public IList<User> GetAll()
        {
            return _crudUser.ReadAll();
        }
        public User GetById(int id)
        {
            return _crudUser.ReadById(id);
        }

        public bool DeleteById(int id)
        {
            return _crudUser.DeleteById(id);
        }

        public bool UpdateById(User novo, int id)
        {
            return _crudUser.UpdateById(novo, id);
        }

    }
}
