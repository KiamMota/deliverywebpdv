using Domain.Core.Entities;
using Infra.Data.Database;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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
            return estabelecimento.EstabelecimentoId;
        }
        public bool DeleteEstabelecimentoById(int id)
        {
            var estabelecimentoId = _dbcntx.estabelecimentos.FirstOrDefault(est => est.EstabelecimentoId == id);
            if (estabelecimentoId == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoId);
            return _dbcntx.SaveChanges() > 0;
        }
        public bool DeleteEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estName => estName.EstabelecimentoNome== nome);
            if(estabelecimentoByNome == null) return false;
            _dbcntx.estabelecimentos.Remove(estabelecimentoByNome);
            return _dbcntx.SaveChanges() > 0;
        }
        public Estabelecimento? GetEstabelecimentoByCategorias(string categorias)
        {
            var EstabelecimentoByCategorias = _dbcntx.estabelecimentos.FirstOrDefault(e => e.EstabelecimentoCategorias.Any(l => l == categorias));
            if (EstabelecimentoByCategorias == null) return null;
            _dbcntx.SaveChanges();
            return EstabelecimentoByCategorias;
        }
        public bool PutEstabelecimentoById(Estabelecimento estabelecimentoNovo, int id)
        {
                var get = _dbcntx.estabelecimentos.FirstOrDefault(es => es.EstabelecimentoId == id); 
                if (get == null) return false;
                else
                {
                bool updated = false;
                if (estabelecimentoNovo.EstabelecimentoNome != null)
                {
                    get.EstabelecimentoNome = estabelecimentoNovo.EstabelecimentoNome;
                    updated = true;                    
                }
                if(estabelecimentoNovo.EstabelecimentoLocal != null)
                {
                    get.EstabelecimentoLocal = estabelecimentoNovo.EstabelecimentoLocal;
                    updated = true;
                }
                if (estabelecimentoNovo.EstabelecimentoDescricao != null)
                {
                    get.EstabelecimentoDescricao = estabelecimentoNovo.EstabelecimentoDescricao;
                    updated = true;
                }
                if (updated)
                {
                    _dbcntx.SaveChanges();
                    return true;
                }

                }
            return false;
        }

        public Estabelecimento? GetEstabelecimentoById(int id)
        {
            var estabelecimentoIdConsulta = _dbcntx.estabelecimentos.FirstOrDefault(estid => estid.EstabelecimentoId== id);
            if (estabelecimentoIdConsulta == null) return null;
            return estabelecimentoIdConsulta;
        }
        public Estabelecimento? GetEstabelecimentoByNome(string nome)
        {
            var estabelecimentoByNome = _dbcntx.estabelecimentos.FirstOrDefault(estNome => estNome.EstabelecimentoNome== nome);
            if (estabelecimentoByNome == null) return null;
            return estabelecimentoByNome;
        }
    }
}
