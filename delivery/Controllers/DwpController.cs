using Microsoft.AspNetCore.Mvc;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Helper;


namespace delivery.Controllers
{
    [ApiController]
    [Route("delwpdv/[controller]")]
    public class ControllerClass : ControllerBase
    {
        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto Ppedido)
        {
            if(DwpHelper.IsValidAll(Ppedido) == DwpHelper.BigBoolean.False)
                return BadRequest();
            return Ok(200);
        }

        [HttpGet("{id}")]
        public IActionResult GetPedido([FromQuery] int id)
        {
            return Ok(200);
        }
    }
}
