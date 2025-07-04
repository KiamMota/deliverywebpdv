using Domain.Core.Entities.Endereco;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Mappers
{
    public class EnderecoMapper : IMapperBase<Domain.Core.Entities.Endereco.Endereco, Infra.Data.DataModels.DataEndereco>
    {
        public DataEndereco ToData(Endereco domain)
        {
            return new Infra.Data.DataModels.DataEndereco
            {
                Rua = domain.Rua.Nome,
                Estado = domain.Estado.Nome,
                Bairro = domain.Bairro.Nome,
                Numero = endereco.Numero,
                Cidade = domain.Cidade.Nome,
                Id = domain.Id
            }; 
        }

        public Endereco ToDomain(DataEndereco data)
        {
            throw new NotImplementedException();
        }
    }
}
