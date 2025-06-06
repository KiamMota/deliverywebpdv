
using Contracts.Request;
using AppService;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        
        [HttpGet]
        [Route("{id}")] 
        public IActionResult Get(int id)
        {
            return Ok();  
        }

        [HttpGet]
        [Route("porcpf/{cpf}")]
        public IActionResult GetByCpf(string cpf)
        {
            return Ok("");
        }

        [HttpGet]
        //api/pedido
        public IActionResult GetAll()
        {
            return Ok(new List<string>());
        }

        [HttpGet]
        [Route("pessoas")] //api/pedido/pessoas
        public IActionResult GetPersons()
        {
            return Ok(new List<string>());
        }

        [HttpPost] //api/pedido
        public IActionResult Post(PedidoRequest obj)
        {
            return Ok();
        }

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
