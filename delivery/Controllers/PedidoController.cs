using Domain.Core.Entities;
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
        [Route("{id}")] //api/pessoas/12
        public IActionResult Get(int id)
        {
            return Ok("");
        }

        [HttpGet]
        [Route("porcpf/{cpf}")] //api/pessoas/12
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
        public IActionResult Post(Pedido obj)
        {
            return Ok();
        }

        [HttpPost] //api/pedido/person
        [Route("person")]
        public IActionResult PostPerson(Pedido obj)
        {
            return Ok();
        }

        //editar
        [HttpPut] //api/pedido/12
        [Route("{id}")]
        public IActionResult put([FromRoute] int id,  [FromBody] Pedido obj)
        {
            return Ok();
        }

    }
}
