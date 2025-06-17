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
        public async Task<bool> ValidationPassword(string Nome, string Password)
        {
            return await _repoUser.ValidarUsuario(Nome, Password);    
        }

        public async Task<int> SalvarUsuario(UserRequest user)
        {
            return await _repoUser.SalvarUsuario(UserMapper.FromRequest(user));
        }

        public async Task<UserResponse>? GetUserByName(string name)
        {
            var resu = await _repoUser.GetUserByName(name);
            if (resu == null) return null;
            return UserMapper.UserToReponse(resu);
        }

        public async Task<UserResponse> GetUserByEmail(string email)
        {
            var resu = await _repoUser.GetUserByEmail(email);
            return UserMapper.UserToReponse(resu);

        }

    }
}
