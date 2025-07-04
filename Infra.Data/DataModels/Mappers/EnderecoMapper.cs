using Domain.Core.Entities.Endereco;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Mappers
{
    public class EnderecoMapper : IMapperBase<Domain.Core.Entities.Endereco.Endereco, Infra.Data.DataModels.EnderecoDb>
    {
        public EnderecoDb ToData(Endereco domain)
        {
            return new Infra.Data.DataModels.EnderecoDb
            {
                Rua = domain.Rua.Nome,
                Estado = domain.Estado.Nome,
                Bairro = domain.Bairro.Nome,
                Numero = domain.Numero,
                Cidade = domain.Cidade.Nome,
                Id = domain.Id
            }; 
        }

        public Endereco ToDomain(EnderecoDb data)
        {
            throw new NotImplementedException();
        }
    }
}
