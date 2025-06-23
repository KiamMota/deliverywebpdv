using AppService.Interfaces.Estabelecimento;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;
using Infra.Data.Repositories.Interfaces;

namespace AppService.Estabelecimento
{
    public class ProcessEstabelecimento : IProcessEstabelecimento
    {
        private readonly IRepoEstabelecimento _repoEstabelecimento;
        public ProcessEstabelecimento(IRepoEstabelecimento repo)
        {
            _repoEstabelecimento = repo;
        }
        public int SalvarEstabelecimento(EstabelecimentoRequest estabelecimento)
        {
            if(estabelecimento == null) return -1;
            var salvar = _repoEstabelecimento.SaveEstabelecimento(EstabelecimentoMapper.FromEstbRequest(estabelecimento));
            return salvar;
        }
        public bool DeleteEstabelecimentoById(int id)
        {
            var result = _repoEstabelecimento.DeleteEstabelecimentoById(id);
            return result;
        }
        public bool DeleteEstabelecimentoByNome(string nome)
        {
            var result = _repoEstabelecimento.DeleteEstabelecimentoByNome(nome);
            return result;
        }
        public EstabelecimentoResponse? GetEstabelecimentoByNome(string nome)
        {
            var resultado = _repoEstabelecimento.GetEstabelecimentoByNome(nome);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }

        public EstabelecimentoResponse? GetEstabelecimentoByCategoria(string categorias)
        {
            var resultado = _repoEstabelecimento.GetEstabelecimentoByCategorias(categorias);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }

        public EstabelecimentoResponse? GetEstabelecimentoById(int id)
        {
            var resultado = _repoEstabelecimento.GetEstabelecimentoById(id);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }
    }
}
