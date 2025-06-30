using Contracts.VModels.User;

namespace AppService.UseCases.Interfaces
{
    public interface IProcessUser
    {
        public bool ValidationPassword(string Nome, string Password);
        public long? SalvarUsuario(UserRequest user);
        public UserResponse? GetUserByName(string name);

    }
}
