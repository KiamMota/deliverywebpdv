using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Helper;
using Delivery.Web.Pdv.Infra;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;


namespace delivery.Controllers
{
    [ApiController]
    [Route("pedidos")]

    public class ControllerClass : ControllerBase
    {
        private Log log = Log.Instance;
        private readonly IAppService _appService;
        public ControllerClass(IAppService ap)
        {
            _appService = ap;
        } 

        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto pedidodto)
        {
            if (DwpHelper.ObjIsValidAll(pedidodto) is DwpHelper.BigBoolean.False) return BadRequest();
            return Ok(_appService.EntregarPedido(pedidodto));
        }

        [HttpGet("{id}")]
        public IActionResult GetPedido(int id)
        {
            var pedidoDto = _appService.EntregarPedido(pedido);
            return Ok(pedidoDto);
        }

        [HttpPut]
        public IActionResult PutPedido(PedidoDto pedidodto)
        {
            if (DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False) { return BadRequest(); }
            return Ok(_appService.EntregarPedido(pedidodto));
        }

        [HttpDelete]
        public IActionResult DeletePedido(PedidoDto pedidodto) {
            if (DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False) { return BadRequest(); }
            return Ok(_appService.RemoverPedido(pedidodto));
        }
    }
}
