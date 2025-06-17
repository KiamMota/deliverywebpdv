using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories.User
{
    public class RepoUser : IRepoUser
    {
        private readonly AppDbContext _dbctx;
        public RepoUser(AppDbContext DbContext) { 
            _dbctx = DbContext;
        }
        public async Task<bool> ValidarUsuario(string Nome, string Password)
        {
            var validar = await _dbctx.Users.FirstOrDefaultAsync(u => u.Password == Password && u.Nome == Nome);
            await _dbctx.SaveChangesAsync();
            return validar != null;
        }

        public async Task<int> SalvarUsuario(Domain.Core.Entities.User user)
        {
            await _dbctx.Users.AddAsync(user);
            await _dbctx.SaveChangesAsync();
            return user.Id;
        }

        public async Task<Domain.Core.Entities.User>? GetUserByName(string name)
        {
            var result = await _dbctx.Users.FirstOrDefaultAsync(u => u.Nome == name);
            return result;
        }

        public async Task<Domain.Core.Entities.User>? GetUserByEmail(string Email)
        {
            var result = await _dbctx.Users.FirstOrDefaultAsync(u => u.Email == Email);
            _dbctx.SaveChangesAsync();
            return result;
        }
    }
}
