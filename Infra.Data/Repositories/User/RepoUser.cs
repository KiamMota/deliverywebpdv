using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Infra.Data.Repositories.User
{
    public class RepoUser : IRepoUser
    {
        private readonly AppDbContext _dbctx;
        public RepoUser(AppDbContext DbContext) {_dbctx = DbContext;}
        public bool ValidarUsuario(string Nome, string Password)
        {
            var validar = _dbctx.Users.FirstOrDefaultAsync(u => u.Password == Password && u.Nome == Nome);
            _dbctx.SaveChangesAsync();
            return validar != null;
        }

        public int SalvarUsuario(Domain.Core.Entities.User user)
        {
            try
            {
            _dbctx.Users.Add(user);
            _dbctx.SaveChanges();
                return user.Id;
            }
            catch (Exception ex)
            {
                var erro = ex.InnerException;
                Console.WriteLine(ex.InnerException.ToString);
                throw;
            }
        }

        public Domain.Core.Entities.User? GetUserByName(string name)
        {
            var result = _dbctx.Users.FirstOrDefault(u => u.Nome == name);
            return result;
        }

        public Domain.Core.Entities.User? GetUserByEmail(string Email)
        {
            var result = _dbctx.Users.FirstOrDefault(u => u.Email == Email);
            _dbctx.SaveChangesAsync();
            return result;
        }
    }
}
