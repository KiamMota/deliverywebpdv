using AppService;
using Contracts.Request;
using Contracts.Response;
using Microsoft.AspNetCore.Mvc;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly AppService.ApsPedido _apps;
        public PedidoController(ApsPedido apsP)
        {
            _apps = apsP;
        }
        [HttpPost]
        public IActionResult Post(PedidoRequest obj) => Ok(_apps.SalvarPedido(obj));

        [HttpGet]
        [Route("{id}")]                         /* => return */
        public IActionResult GetById(int id) => Ok(_apps.PegarPedidoById(id));
        
        
        //[HttpGet]
        //[Route("porcpf/{cpf}")]
        //public IActionResult GetByCpf(string cpf)
        //{
        //    return Ok("");
        //}

        [HttpGet]
        
        public IActionResult GetAll() => Ok(_apps.PegarPedidoAll());
        [HttpPut] //api/pedido/12
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id,  [FromBody] PedidoRequest obj)
        {
            return Ok(_apps.AlterarPedidoById(obj, id));
        }

    }
}
