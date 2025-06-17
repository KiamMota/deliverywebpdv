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
        public async Task<int> SalvarEstabelecimento(EstabelecimentoRequest estabelecimento)
        {
            if(estabelecimento == null) return -1;
            var salvar = await _repoEstabelecimento.SaveEstabelecimento(EstabelecimentoMapper.FromEstbRequest(estabelecimento));
            return salvar;
        }
        public async Task<bool> DeleteEstabelecimentoById(int id)
        {
            var result = await _repoEstabelecimento.DeleteEstabelecimentoById(id);
            return result;
        }
        public async Task<bool> DeleteEstabelecimentoByNome(string nome)
        {
            var result = await _repoEstabelecimento.DeleteEstabelecimentoByNome(nome);
            return result;
        }
        public async Task<EstabelecimentoResponse?> GetEstabelecimentoByNome(string nome)
        {
            var resultado = await _repoEstabelecimento.GetEstabelecimentoByNome(nome);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }

        public async Task<EstabelecimentoResponse?> GetEstabelecimentoByCategoria(string categorias)
        {
            var resultado = await _repoEstabelecimento.GetEstabelecimentoByCategorias(categorias);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }

        public async Task<EstabelecimentoResponse?> GetEstabelecimentoById(int id)
        {
            var resultado = await _repoEstabelecimento.GetEstabelecimentoById(id);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }
    }
}
