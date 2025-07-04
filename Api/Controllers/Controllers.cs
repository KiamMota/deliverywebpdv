
using AppService;
using AppService.Interfaces;
using Contracts.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoGravar _enderecoGravar;
        public EnderecoController(IEnderecoGravar enderecoGravar)
        {
            _enderecoGravar = enderecoGravar;
        }
        [HttpPost]
        public IActionResult Post([FromBody] EnderecoRequest endereco)
        {
            return Ok(_enderecoGravar.Salvar(endereco));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var enderecos = _enderecoGravar.GetAll();
            if (enderecos == null || !enderecos.Any())
            {
                return NotFound("Nenhum endereço encontrado.");
            }
            return Ok(enderecos);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (_enderecoGravar.DeleteById(id))
            {
                return Ok("Endereço excluído com sucesso.");
            }
            return NotFound($"Endereço com ID {id} não encontrado.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var endereco = _enderecoGravar.GetById(id);
            if (endereco == null)
            {
                return NotFound($"Endereço com ID {id} não encontrado.");
            }
            return Ok(endereco);
        }
        [HttpPut("{id}")]
        public IActionResult PutById(long id, [FromBody] EnderecoRequest endereco)
        {
            if (_enderecoGravar.PutById(endereco, id))
            {
                return Ok("Endereço atualizado com sucesso.");
            }
            return NotFound($"Endereço com ID {id} não encontrado.");
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteGravar _clienteGravar;
        public ClienteController(IClienteGravar clienteGravar)
        {
            _clienteGravar = clienteGravar;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteRequest cliente)
        {
            return Ok(_clienteGravar.Salvar(cliente));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var clientes = _clienteGravar.GetAll();
            if (clientes == null || !clientes.Any())
            {
                return NotFound("Nenhum cliente encontrado.");
            }
            return Ok(clientes);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (_clienteGravar.DeleteById(id))
            {
                return Ok("Cliente excluído com sucesso.");
            }
            return NotFound($"Cliente com ID {id} não encontrado.");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var cliente = _clienteGravar.GetById(id);
            if (cliente == null)
            {
                return NotFound($"Cliente com ID {id} não encontrado.");
            }
            return Ok(cliente);
        }
        [HttpPut("{id}")]
        public IActionResult PutById(long id, [FromBody] ClienteRequest cliente)
        {
            if (_clienteGravar.PutById(cliente, id))
            {
                return Ok("Cliente atualizado com sucesso.");
            }
            return NotFound($"Cliente com ID {id} não encontrado.");
        }

    }

}