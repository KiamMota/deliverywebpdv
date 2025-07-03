namespace Infra.Data.Mappers
{
    public class ClienteMapper
    {
        public static DataModels.DataCliente ClienteData(Domain.Core.Entities.Cliente.Cliente cliente)
        {
            return new DataModels.DataCliente
            {
                Nome = cliente.Nome.nome,
                Email = cliente.Email.email,
                CPF = cliente.CPF.cpf,
                Senha = cliente.Senha,
                Id = cliente.Id,
            };
        }
    }
}
