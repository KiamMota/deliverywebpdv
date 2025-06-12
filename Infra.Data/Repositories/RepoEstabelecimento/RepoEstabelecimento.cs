using Domain.Core.Entities;
using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Repositories.RepoEstabelecimento
{
    public class RepoEstabelecimento : IRepoEstabelecimento
    {
        private AppDbContext _dbcntx;
        public int SaveEstabelecimento(Domain.Core.Entities.Estabelecimento estabelecimento)
        {
            _dbcntx.estabelecimentos.Add(estabelecimento);
            _dbcntx.SaveChanges();
            return estabelecimento.id;
        }
        public bool DeleteEstabelecimentoById(int id)
        {
            var estabelecimentoId = _dbcntx.estabelecimentos.FirstOrDefault(est => est.id == id);
            if (estabelecimentoId == null) return false;
            return true;
        }
        public bool DeleteEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estName => estName.nome == nome);
            if(estabelecimentoByNome == null) return false;
            return true;
        }
        public Estabelecimento? GetEstabelecimentoByCategorias(string categorias)
        {
            return _dbcntx.estabelecimentos.FirstOrDefault(estCat => estCat.categorias.Any(c => c == categorias));
        }
        public Estabelecimento? GetEstabelecimentoById(int id)
        {
            var estabelecimentoIdConsulta = _dbcntx.estabelecimentos.FirstOrDefault(estid => estid.id == id);
            if (estabelecimentoIdConsulta == null) return null;
            return estabelecimentoIdConsulta;
        }
        public Estabelecimento? GetEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estNome => estNome.nome == nome);
            if (estabelecimentoByNome == null) return null;
            return estabelecimentoByNome;
        }
    }
}
