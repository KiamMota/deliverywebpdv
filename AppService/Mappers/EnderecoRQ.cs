using Contracts.RequestModels;
using Contracts.ResponseModels;
using Domain.Core.Entities.Endereco;

namespace AppService.Mappers
{
    public class EnderecoRQ
    {
        public static EnderecoResponse RqToRp(EnderecoRequest enderecoRequest)
        {
            if (enderecoRequest == null) return null;
            return new EnderecoResponse
            {
                Rua = enderecoRequest.Rua,
                Bairro = enderecoRequest.Bairro,
                Estado = enderecoRequest.Estado,
                Cidade = enderecoRequest.Cidade,
                Numero = enderecoRequest.Numero
            };
        }
        public static Endereco RequestToDomain(Contracts.RequestModels.EnderecoRequest request)
        {
            if (request == null) return null;
            return new Domain.Core.Entities.Endereco.Endereco(
                rua: request.Rua,
                bairro: request.Bairro,
                estado: request.Estado,
                cidade: request.Cidade,
                numero: request.Numero
            );
        }

        public static Endereco ResponseToDomain(EnderecoResponse response)
        {
            if (response == null) return null;
            return new Endereco(
                response.Rua,
                response.Bairro,
                response.Estado,
                response.Cidade,
                response.Numero
            );
        }




    }
}
