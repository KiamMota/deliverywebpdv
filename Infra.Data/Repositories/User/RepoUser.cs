using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories.User
{
    public class RepoUser : IRepoUser
    {
        private readonly AppDbContext _dbctx;
        public RepoUser(AppDbContext DbContext) { 
            _dbctx = DbContext;
        }
        public bool ValidarUsuario(string Nome, string Password)
        {
            var validar = _dbctx.Users.FirstOrDefault(u => u.Password == Password && u.Nome == Nome);
            _dbctx.SaveChanges();
            return validar != null;
        }

        public int SalvarUsuario(Domain.Core.Entities.User user)
        {
            _dbctx.Users.Add(user);
            _dbctx.SaveChanges();
            return user.Id;
        }

        public Domain.Core.Entities.User? GetUserByName(string name)
        {
            var result = _dbctx.Users.FirstOrDefault(u => u.Nome == name);
            return result;
        }
    }
}
