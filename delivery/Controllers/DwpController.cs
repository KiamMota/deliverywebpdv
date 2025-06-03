using Microsoft.AspNetCore.Mvc;
using Delivery.Web.Pdv.Contracts;
using Delivery.Web.Pdv.AppService;
using Microsoft.AspNetCore.Mvc.Routing;

namespace delivery.Controllers
{
    [ApiController]
    [Route("deliveryWPDV/[controller]")]
    public class ControllerClass : ControllerBase
    {
        [HttpPost]
        public IActionResult Request(PedidoRequest pedidoR)
        {






            return BadRequest();
        }




    }
}
