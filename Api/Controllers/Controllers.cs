
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
    }
}