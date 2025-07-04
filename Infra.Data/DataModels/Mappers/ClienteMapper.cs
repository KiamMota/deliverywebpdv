using Domain.Core.Entities.Cliente;
using Domain.Core.Kel;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Interfaces;

namespace Infra.Data.Mappers
{
    public class ClienteMapper : IMapperBase<Domain.Core.Entities.Cliente.Cliente, DataModels.DataCliente>
    {

        public DataCliente ToData(Domain.Core.Entities.Cliente.Cliente domain)
        {
            return new DataModels.DataCliente
            {
                Nome = domain.Nome.nome,
                Email = domain.Email.email,
                CPF = domain.CPF.cpf,
                Senha = domain.Senha,
                Id = domain.Id,
            };
        }

        public Domain.Core.Entities.Cliente.Cliente ToDomain(DataCliente data)
        {
            throw new NotImplementedException();
        }
    }
}
