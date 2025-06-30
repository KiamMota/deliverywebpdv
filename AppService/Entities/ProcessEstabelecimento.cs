using AppService.Mappers;
using AppService.UseCases.Interfaces;
using Contracts.VModels.ContractsEstabelecimento.Request;
using Contracts.VModels.ContractsEstabelecimento.Response;
using Domain.Core.Entities;
using Infra.Data.Repositories.Interfaces;

namespace AppService.UseCases
{
    public class ProcessEstabelecimento : IProcessEstabelecimento
    {
        private readonly ICrudBase<Estabelecimento> _CrudEstabelecimento;
        public ProcessEstabelecimento(ICrudBase<Estabelecimento> _CrudEstabelecimento)
        {
            this._CrudEstabelecimento = _CrudEstabelecimento;
        }
        public long? SalvarEstabelecimento(EstabelecimentoRequest estabelecimento)
        {
            var result = _CrudEstabelecimento.Create(EstabelecimentoMapper.FromEstbRequest(estabelecimento));
            if (result == null) return -1;
            return result;
        }

        public bool DeleteEstabelecimentoById(int id)
        {
            return _CrudEstabelecimento.DeleteById(id);
        }

        public bool PutEstabelecimentoById(EstabelecimentoRequest estabelecimentoNovo, int id)
        {
            var result = _CrudEstabelecimento.UpdateById(EstabelecimentoMapper.FromEstbRequest(estabelecimentoNovo), id);
            return result;
        }

        public EstabelecimentoResponse? GetEstabelecimentoById(int id)
        {
            var resultado = _CrudEstabelecimento.ReadById(id);
            return EstabelecimentoMapper.ToEstbResponse(resultado);
        }

        public EstabelecimentoResponse? GetEstabelecimentoByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEstabelecimentoByNome(string nome)
        {
            throw new NotImplementedException();
        }

    }
}
