using Microsoft.AspNetCore.Mvc;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.AppService;
using Microsoft.AspNetCore.Mvc.Routing;

namespace delivery.Controllers
{
    [ApiController]
    [Route("deliveryWPDV/[controller]")]
    
    public class PedidoFromJson : ControllerBase
    {
        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto pedido)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok();
        }
        [HttpGet]
        public IActionResult GetPedido([FromHeader] PedidoDto pedido)
        {

        }
    }
}
