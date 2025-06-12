using AppService.Interfaces.Pedido;
using Contracts.PedidoContracts.Request;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api.Delivery.Controllers
{
    [Route("Pedidos/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        /* DI constructor */
        private readonly IProcessPedido _apps;
        public PedidosController(IProcessPedido apsP)
        {
            _apps = apsP;
        }
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
        public IActionResult GetById([Required] int id) 
        {
            
            return Ok(_apps.PegarPedidoById(id));
        }
        /* all */
        [HttpGet]
        public IActionResult GetAll() {

            return Ok(_apps.PegarPedidoAll());
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PedidoRequest obj)
        {
            return Ok(_apps.AlterarPedidoById(obj, id));
        }
    }
    [Route("EstabelecimentoRequest/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        


    }
}
