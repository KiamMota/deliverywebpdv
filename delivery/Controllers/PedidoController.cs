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
        [Route("{id}")] 
        public IActionResult GetById(int id) => Ok(_apps.PegarPedidoById(id));
        
        
        //[HttpGet]
        //[Route("porcpf/{cpf}")]
        //public IActionResult GetByCpf(string cpf)
        //{
        //    return Ok("");
        //}

        [HttpGet]
        //api/pedido
        public IActionResult GetAll()
        {
            return Ok(_apps.PegarPedidoBy);
        }

        [HttpGet]
        [Route("pessoas")] //api/pedido/pessoas
        public IActionResult GetPersons()
        {
            return Ok(new List<string>());
        }

        [HttpPost] //api/pedido


        [HttpPost] //api/pedido/person
        [Route("person")]
        public IActionResult PostPerson(PedidoRequest obj)
        {
            return Ok();
        }

        //editar
        [HttpPut] //api/pedido/12
        [Route("{id}")]
        public IActionResult put([FromRoute] int id,  [FromBody] PedidoRequest obj)
        {
            return Ok();
        }

    }
}
