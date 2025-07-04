using Contracts.RequestModels;
using Contracts.ResponseModels;
using Domain.Core.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Mappers
{
    public class ClienteAppMap
    {
        public static ClienteRequest RpToRq(ClienteRequest enderecoRequest)
        {
            if (enderecoRequest == null) return null;
            return new ClienteRequest
            {
                Nome = enderecoRequest.Nome,
                Email = enderecoRequest.Email,
                CPF = enderecoRequest.CPF,
                Senha = enderecoRequest.Senha
            };
        }
        public static Cliente RequestToDomain(ClienteRequest request)
        {
            if (request == null) return null;
            return new Cliente
               (nome: request.Nome,
                EnderecoId: request.EnderecoId,
                email: request.Email,
                cpf: request.CPF,
                senha: request.Senha
                );
        }

        public static ClienteRequest ResponseToDomain(ClienteRequest response)
        {
            if (response == null) return null;
            return new ClienteRequest
            {
                Nome = response.Nome,
                Email = response.Email,
                CPF = response.CPF,
                Senha = response.Senha
            };
        }

        public static Contracts.ResponseModels.ClienteResponse DomainToResponse(Cliente cliente)
        {
            if (cliente == null) return null;
            return new ClienteResponse
            {
                Id = cliente.Id,
                Nome = cliente.Nome.nome,
                Email = cliente.Email.email,
                CPF = cliente.CPF.cpf,
                Senha = cliente.Senha
            };
        }

    }

}
