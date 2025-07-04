using Contracts.RequestModels;
using Contracts.ResponseModels;
using Domain.Core.Entities.Endereco;

namespace AppService.Mappers
{
    public class EnderecoAppMap
    {
        public static EnderecoResponse RpToRq(EnderecoRequest enderecoRequest)
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

        public static Contracts.ResponseModels.EnderecoResponse DomainToResponse(Endereco endereco)
        {
            if (endereco == null) return null;
            return new Contracts.ResponseModels.EnderecoResponse
            {
                Rua = endereco.Rua.Nome,
                Bairro = endereco.Bairro.Nome,
                Estado = endereco.Estado.Nome,
                Cidade = endereco.Cidade.Nome,
                Numero = endereco.Numero
            };
        }   




    }
}
