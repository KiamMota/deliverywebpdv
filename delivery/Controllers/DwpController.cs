using Delivery.Web.Pdv.AppService;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.Helper;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;


namespace delivery.Controllers
{
    [ApiController]
    [Route("dwp/pedidos")]

    public class ControllerClass : ControllerBase
    {
        private readonly IAppService _appService;
        public ControllerClass(IAppService ap)
        {
            _appService = ap;
        } 

        [HttpPost]
        public IActionResult PostPedido([FromBody] PedidoDto pedidodto)
        {
            if (DwpHelper.ObjIsValidAll(pedidodto) is DwpHelper.BigBoolean.False) return BadRequest();
            return Ok(_appService.CriarPedido(pedidodto));
            Console.WriteLine("mandado post");
        }

        [HttpGet("{id}")]
        public ActionResult<PedidoDto> GetPedido(int id)
        {
            return Ok(_appService.EntregarPedidoById(id));
        }

        [HttpPut("{id}")]
        public IActionResult PutPedido(PedidoDto pedidodto)
        {
            if (DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False) { return BadRequest(); }
            return Ok(_appService.AtualizarPedido(pedidodto));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePedido(PedidoDto pedidodto) {
            if (DwpHelper.ObjIsValidAll(pedidodto) == DwpHelper.BigBoolean.False) { return BadRequest(); }
            return Ok(_appService.RemoverPedido(pedidodto));
        }
    }
}
