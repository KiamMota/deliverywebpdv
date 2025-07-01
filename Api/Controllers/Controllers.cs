using AppService.UseCases.Interfaces;
using Contracts.VModels.Estabelecimento;
using Contracts.VModels.Pedido;
using Contracts.VModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly AppService.UseCases.Interfaces.IProcessPedido _apps;
        public PedidosController(IProcessPedido apsP)
        {
            _apps = apsP;
        }

        [HttpPost]
        public IActionResult Post(PedidoRequest obj)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(_apps.SalvarPedido(obj));
        }

        [HttpGet("nome/{PedidoNome}")]
        public IActionResult GetByNome(string PedidoNome)
        {
            return Ok(_apps.PegarPedidoByNome(PedidoNome));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(_apps.PegarPedidoAll());
        }

        [HttpGet("id/{id}")]
        public IActionResult GetId(int id)
        {
            return Ok(_apps.PegarPedidoById(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PedidoRequest obj)
        {
            return Ok(_apps.AtualizarPedidoById(obj, id));
        }
        public async Task<IActionResult> DeleteById(int id)
        {
            return Ok(_apps.RemoverPedidoById(id));
        }
    }
}