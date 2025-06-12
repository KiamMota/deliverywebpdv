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
            var salvar = EstabelecimentoMapper.FromEstbRequest(estabelecimento);
            return _repoEstabelecimento.SaveEstabelecimento(salvar);                
        }
        public bool DeleteEstabelecimentoById(int id)
        {
            return _repoEstabelecimento.DeleteEstabelecimentoById(id);
        }
        public bool DeleteEstabelecimentoByNome(string nome)
        {
            return _repoEstabelecimento.DeleteEstabelecimentoByNome(nome);
        }
        public EstabelecimentoResponse? GetEstabelecimentoByNome(string nome)
        {
            var resultado = EstabelecimentoMapper.ToEstbResponse(_repoEstabelecimento.GetEstabelecimentoByNome(nome));
            return resultado;
        }

        public EstabelecimentoResponse? GetEstabelecimentoByCategoria(string categorias)
        {
            var resultado = EstabelecimentoMapper.ToEstbResponse(_repoEstabelecimento.GetEstabelecimentoByCategorias(categorias));
            return resultado;
        }

        public EstabelecimentoResponse? GetEstabelecimentoById(int id)
        {
            var resultado = EstabelecimentoMapper.ToEstbResponse(_repoEstabelecimento.GetEstabelecimentoById(id));
            return resultado;
        }
    }
}
