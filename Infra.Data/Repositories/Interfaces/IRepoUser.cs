using Domain.Core.Entities;

namespace Infra.Data.Repositories.Interfaces
{
    public interface IRepoUser
    {
        Task<bool> ValidarUsuario(string Nome, string Password);
        Task<int> SalvarUsuario(Domain.Core.Entities.User user);
        Task<Domain.Core.Entities.User>? GetUserByName(string name);
        Task<Domain.Core.Entities.User>? GetUserByEmail(string email);
    }
}
