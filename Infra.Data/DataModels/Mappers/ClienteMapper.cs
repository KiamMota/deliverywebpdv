using Domain.Core.Entities.Cliente;
using Domain.Core.Kel;
using Infra.Data.DataModels;
using Infra.Data.Repositories.Base;

namespace Infra.Data.Mappers
{
    public class ClienteMapper : IMapperBase<Domain.Core.Entities.Cliente.Cliente, DataModels.ClienteDb>
    {

        public ClienteDb ToData(Domain.Core.Entities.Cliente.Cliente domain)
        {
            return new DataModels.ClienteDb
            {
                Nome = domain.Nome.nome,
                Email = domain.Email.email,
                CPF = domain.CPF.cpf,
                Senha = domain.Senha,
                Id = domain.Id,
            };
        }

        public Domain.Core.Entities.Cliente.Cliente ToDomain(ClienteDb data)
        {
            throw new NotImplementedException();
        }
    }
}
