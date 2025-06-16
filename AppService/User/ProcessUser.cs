using AppService.Interfaces.User;
using AppService.Pedido;
using Contracts.User;
using Infra.Data.Repositories.Interfaces;

namespace AppService.User
{
    public class ProcessUser : IProcessUser
    {
        private readonly IRepoUser _repoUser;
        public ProcessUser(IRepoUser repoUser)
            => _repoUser = repoUser;

        public bool ValidationPassword(string Nome, string Password)
        {
            return _repoUser.ValidarUsuario(Nome, Password);    
        }

        public int SalvarUsuario(UserRequest user)
        {
            return _repoUser.SalvarUsuario(UserMapper.FromRequest(user));
        }

        public UserResponse? GetUserByName(string name)
        {
            return UserMapper.UserToReponse(_repoUser.GetUserByName(name));
        }
    }
}
