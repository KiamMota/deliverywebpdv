using AppService.Mappers;
using AppService.UseCases.Interfaces;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.ContractsEstabelecimento.Response;
using Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace AppService.UseCases
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
            if (estabelecimento == null) return -1;
            var salvar = _repoEstabelecimento.SaveEstabelecimento(EstabelecimentoMapper.FromEstbRequest(estabelecimento));
            if (salvar is null) return -1;
            return 1;
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

        public bool PutEstabelecimentoById(EstabelecimentoRequest estabelecimentoNovo, int id)
        {
            var result = _repoEstabelecimento.PutEstabelecimentoById(EstabelecimentoMapper.FromEstbRequest(estabelecimentoNovo), id);
            return result;
        }

        public EstabelecimentoResponse? GetEstabelecimentoById(int id)
        {
            var resultado = _repoEstabelecimento.GetEstabelecimentoById(id);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }
    }
}
