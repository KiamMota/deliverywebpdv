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
        private readonly IAppService _appService = new AppService();

        public ControllerClass(IAppService ap)
        {
            _appService = ap;
        } 

        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto pedidodto)
        {
            if(DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False)
                return BadRequest();
            
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetPedido([FromQuery] int id)
        {
            return Ok(200);
        }
    }
}
