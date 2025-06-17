using Contracts.User;

namespace AppService.Interfaces.User
{
    public interface IProcessUser
    {
        public Task<bool> ValidationPassword(string Nome, string Password);
        public Task<int> SalvarUsuario(UserRequest user);
        public Task<UserResponse>? GetUserByName(string name);
        public Task<UserResponse>? GetUserByEmail(string email);
       
    }
}
