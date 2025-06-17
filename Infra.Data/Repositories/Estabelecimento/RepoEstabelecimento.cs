using Domain.Core.Entities;
using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories.RepoEstabelecimento
{
    public class RepoEstabelecimento : IRepoEstabelecimento
    {
        private readonly AppDbContext _dbcntx;
        public RepoEstabelecimento(AppDbContext context)
        {
            _dbcntx = context;
        }
        public async Task<int> SaveEstabelecimento(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) return -1;
            await _dbcntx.estabelecimentos.AddAsync(estabelecimento);
            await _dbcntx.SaveChangesAsync();
            return estabelecimento.estabId;
        }
        public async Task<bool> DeleteEstabelecimentoById(int id)
        {
            var estabelecimentoId = await _dbcntx.estabelecimentos.FirstOrDefaultAsync(est => est.estabId == id);
            if (estabelecimentoId == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoId);
            return await _dbcntx.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = await _dbcntx.estabelecimentos.FirstOrDefaultAsync(estName => estName.estabNome == nome);
            if(estabelecimentoByNome == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoByNome);
            return await _dbcntx.SaveChangesAsync() > 0;
        }
        public async Task<Estabelecimento>? GetEstabelecimentoByCategorias(string categorias)
        {
            var EstabelecimentoByCategorias = await _dbcntx.estabelecimentos.FirstOrDefaultAsync(e => e.estabCategorias.Any(l => l == categorias));
            if (EstabelecimentoByCategorias == null) return null;
            await _dbcntx.SaveChangesAsync();
            return EstabelecimentoByCategorias;
        }
        public async Task<Estabelecimento>? GetEstabelecimentoById(int id)
        {
            var estabelecimentoIdConsulta = await _dbcntx.estabelecimentos.FirstOrDefaultAsync(estid => estid.estabId == id);
            if (estabelecimentoIdConsulta == null) return null;
            return estabelecimentoIdConsulta;
        }
        public async Task<Estabelecimento>? GetEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = await _dbcntx.estabelecimentos.FirstOrDefaultAsync(estNome => estNome.estabNome == nome);
            if (estabelecimentoByNome == null) return null;
            return estabelecimentoByNome;
        }
    }
}
