using Contracts.User;

namespace AppService.Interfaces
{
    public interface IProcessUser
    {
        public bool ValidationPassword(string Nome, string Password);
        public int SalvarUsuario(UserRequest user);
        public UserResponse? GetUserByName(string name);

    }
}
