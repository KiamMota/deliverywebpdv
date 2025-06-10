using AppService.Interfaces.Pedido;
using Contracts.PedidoContracts.Request;
using Microsoft.AspNetCore.Mvc;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        /* eu usei expression bodied em todos os sistemas aqui, 
         * já que a lógica adicional está no appservice que herda do domain 
         */
        private readonly IProcessPedido _apps;
        /* construtor */
        public PedidosController(IProcessPedido apsP) => _apps = apsP;
        [HttpPost]
        public IActionResult Post(PedidoRequest obj) => Ok(_apps.SalvarPedido(obj));
        /* área get */
        [HttpGet]
        [Route("nome/{pedido_nome}")]
        public IActionResult GetByNome(string pedido_nome)
        {
            return Ok(_apps.PegarPedidoByNome(pedido_nome));
        }
        /* by id */
        [HttpGet]
        [Route("id/{id}")]
        public IActionResult GetById(int id) {
            
            return Ok(_apps.PegarPedidoById(id));
        }
        /* all */
        [HttpGet]
        public IActionResult GetAll() {

            return Ok(_apps.PegarPedidoAll());
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PedidoRequest obj) => Ok(_apps.AlterarPedidoById(obj, id));
    }
}
