using Contracts.RequestModels;
using Contracts.ResponseModels;

namespace AppService.Interfaces
{
    public interface IEnderecoGravar
    {
        long Salvar(EnderecoRequest entity);
        EnderecoResponse GetById(long id);
        bool PutById(EnderecoRequest entity, long id);
        bool DeleteById(long id);
        IList<EnderecoResponse> GetAll();
    }
}
