using AppService.Mappers;
using AppService.UseCases.Interfaces;
using Contracts.VModels.User;
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

        public UserResponse? GetUserByName(string name)
        {
            var Result = _CrudUser.ReadByString(name);
            if (Result == null) return null;
            return UserMapper.UserToReponse(Result);
        }

        public long? SalvarUsuario(UserRequest user)
        {
            var save = _CrudUser.Create(UserMapper.FromRequest(user));
            if(save == null) return 0;
            return save;
        }

        public bool ValidationPassword(string Nome, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
