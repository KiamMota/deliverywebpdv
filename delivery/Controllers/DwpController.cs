using Microsoft.AspNetCore.Mvc;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.AppService;


namespace delivery.Controllers
{
    [ApiController]
    [Route("dwpapi/[controller]")]
    public class ControllerClass : ControllerBase
    {
        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto pedidodto)
        {
            if(DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False)
                return BadRequest();
            AppService.ParaPedido(pedidodto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPedido([FromQuery] int id)
        {
            //todo
            return Ok(200);
        }
    }
}
