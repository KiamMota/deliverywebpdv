namespace AppService.Mappers
{
    public class EnderecoMapper
    {
        public static Infra.Data.DataModels.DataEndereco EnderecoData(Domain.Core.Entities.Endereco.Endereco endereco)
        {
            return new Infra.Data.DataModels.DataEndereco
            {
                Rua = endereco.Rua.Nome,
                Estado = endereco.Estado.Nome,
                Bairro = endereco.Bairro.Nome,
                Numero = endereco.Numero,
                Id = endereco.Id
            };
        }
    }
}
