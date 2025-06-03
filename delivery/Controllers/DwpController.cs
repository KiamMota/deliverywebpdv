using Microsoft.AspNetCore.Mvc;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Core.Entity;
using Delivery.Web.Pdv.AppService;


namespace delivery.Controllers
{
    [ApiController]
    [Route("dwpapi/[controller]")]
    public class ControllerClass : ControllerBase
    {
        [HttpPost]
        public IActionResult PostPedido([FromBody] Pedido pedidodto)
        {
            if(DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False)
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
