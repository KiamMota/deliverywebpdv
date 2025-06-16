using AppService.Interfaces.Estabelecimento;
using AppService.Interfaces.Pedido;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.PedidoContracts.Request;
using Microsoft.AspNetCore.Mvc;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        /* DI constructor */
        private readonly IProcessPedido _apps;
        public PedidosController(IProcessPedido apsP)
        {
            _apps = apsP;
        }
        [HttpPost]
        public IActionResult Post(PedidoRequest obj) => Ok(_apps.SalvarPedido(obj));
        /* área get */
        [HttpGet("nome/{pedido_nome}")]
        public IActionResult GetByNome(string pedido_nome)
        {
            return Ok(_apps.PegarPedidoByNome(pedido_nome));
        }
        public IActionResult GetAll()
        {
            return Ok(_apps.PegarPedidoAll());
        }
        [HttpGet("id/{id}")]
        public IActionResult GetId(int id)
        {
            return Ok(_apps.PegarPedidoById(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] PedidoRequest obj)
        {
            return Ok(_apps.AlterarPedidoById(obj, id));
        }
        public IActionResult DeleteById(int id)
        {
            return Ok(_apps.RemoverPedidoById(id));
        }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IProcessEstabelecimento _processEstabelecimento;
        public EstabelecimentoController(IProcessEstabelecimento estabelecimento)
        {
            _processEstabelecimento = estabelecimento;
        }
        [HttpPost]
        public IActionResult EstabelecimentoSalvar([FromBody] EstabelecimentoRequest estabelecimentoRequest)
        {
            return Ok(_processEstabelecimento.SalvarEstabelecimento(estabelecimentoRequest));
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult EstabelecimentoGetById(int id)
        {
            return Ok(_processEstabelecimento.GetEstabelecimentoById(id));
        }
        [HttpGet]
        [Route("pedidoNome/{pedidoNome}")]
        public IActionResult EstabelecimentoGetByNome(string nome)
        {
            return Ok(_processEstabelecimento.GetEstabelecimentoByNome(nome));
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteEstabelecimentoById(int id)
        {
            return Ok(_processEstabelecimento.DeleteEstabelecimentoById(id));
        }
        [HttpDelete]
        [Route("pedidoNome/{pedidoNome}")]
        public IActionResult DeleteEstabelecimentoByNome(string nome)
        {
            return Ok(_processEstabelecimento.DeleteEstabelecimentoByNome(nome));
        }
    }
}
