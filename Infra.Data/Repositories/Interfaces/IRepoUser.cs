using Domain.Core.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IRepoUser
    {
        bool ValidarUsuario(string Nome, string Password);
        int SalvarUsuario(Domain.Core.Entities.User user);
        Domain.Core.Entities.User? GetUserByName(string name);
        Domain.Core.Entities.User? GetUserByEmail(string email);
    }
}
