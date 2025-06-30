using AppService.Mappers;
using AppService.UseCases.Interfaces;
using Contracts.User;
using Infra.Data.Repositories.Interfaces;

namespace AppService.UseCases
{
    public sealed class ProcessUser : IProcessUser
    {
        private readonly ICrudBase<Domain.Core.Entities.User> _CrudUser;
        public ProcessUser(ICrudBase<Domain.Core.Entities.User> _CrudUser)
        {
            this._CrudUser = _CrudUser;
        }

        public long? SalvarUsuario(UserRequest user)
        {
            var result = _CrudUser.Create(UserMapper.FromRequest(user));
            return result;
        }

        public UserResponse? GetUserByName(string name)
        {
            var Result = _CrudUser.ReadByString(name);
            if (Result == null) return null;
            return UserMapper.UserToReponse(Result);
        }

        public bool ValidationPassword(string Nome, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
