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
        public int SaveEstabelecimento(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            if (estabelecimento == null) return -1;
            _dbcntx.estabelecimentos.Add(estabelecimento);
            _dbcntx.SaveChanges();
            return estabelecimento.estabId;
        }
        public bool DeleteEstabelecimentoById(int id)
        {
            var estabelecimentoId = _dbcntx.estabelecimentos.FirstOrDefault(est => est.estabId == id);
            if (estabelecimentoId == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoId);
            return _dbcntx.SaveChanges() > 0;
        }
        public bool DeleteEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estName => estName.estabNome == nome);
            if(estabelecimentoByNome == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoByNome);
            return _dbcntx.SaveChanges() > 0;
        }
        public Estabelecimento? GetEstabelecimentoByCategorias(string categorias)
        {
            var EstabelecimentoByCategorias = _dbcntx.estabelecimentos.FirstOrDefault(e => e.estabCategorias.Any(l => l == categorias));
            if (EstabelecimentoByCategorias == null) return null;
            _dbcntx.SaveChanges();
            return EstabelecimentoByCategorias;
        }
        public Estabelecimento? GetEstabelecimentoById(int id)
        {
            var estabelecimentoIdConsulta = _dbcntx.estabelecimentos.FirstOrDefault(estid => estid.estabId == id);
            if (estabelecimentoIdConsulta == null) return null;
            return estabelecimentoIdConsulta;
        }
        public Estabelecimento? GetEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estNome => estNome.estabNome == nome);
            if (estabelecimentoByNome == null) return null;
            return estabelecimentoByNome;
        }
    }
}
