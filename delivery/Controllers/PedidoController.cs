using AppService.Interfaces.Estabelecimento;
using AppService.Interfaces.Pedido;
using AppService.Interfaces.User;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.PedidoContracts.Request;
using Contracts.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Api.Delivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IProcessPedido _apps;
        public PedidosController(IProcessPedido apsP)
        {
            _apps = apsP;
        }
        [HttpPost]
        
        public IActionResult Post(PedidoRequest obj) => Ok(_apps.SalvarPedido(obj));
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

    [ApiController]
    [Route("api/[controller]")]
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
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(_processEstabelecimento.SalvarEstabelecimento(estabelecimentoRequest));
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult EstabelecimentoGetById(int id)
        {
            return Ok(_processEstabelecimento.GetEstabelecimentoById(id));
        }
        [HttpGet]
        [Route("nome/{nome}")]
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
        [Route("nome/{nome}")]
        public IActionResult DeleteEstabelecimentoByNome(string nome)
        {
            return Ok(_processEstabelecimento.DeleteEstabelecimentoByNome(nome));
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IProcessUser _apps;
        public UserController(IProcessUser processUser)
            => _apps = processUser;
        [HttpPost]
        public IActionResult Post([FromBody] UserRequest user)
        {
            return Ok(_apps.SalvarUsuario(user));
        }

        [HttpGet("nome/{name}")]
        public IActionResult GetByNome(string name)
        {
            return Ok(_apps.GetUserByName(name));
        }
        
    }

}
