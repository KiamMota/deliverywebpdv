using AppService.Interfaces.Estabelecimento;
using AppService.Interfaces.Pedido;
using AppService.Interfaces.User;
using Contracts.ContractsEstabelecimento.Request;
using Contracts.PedidoContracts.Request;
using Contracts.User;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Post(PedidoRequest obj)
        {
            return Ok(await _apps.SalvarPedido(obj));
        }
     
        [HttpGet("nome/{PedidoNome}")]
        public async Task<IActionResult> GetByNome(string PedidoNome)
        {
            return Ok(await _apps.PegarPedidoByNome(PedidoNome));
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _apps.PegarPedidoAll());
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetId(int id)
        {
            return Ok(await _apps.PegarPedidoById(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] PedidoRequest obj)
        {
            return Ok(await _apps.AlterarPedidoById(obj, id));
        }
        public async Task<IActionResult> DeleteById(int id)
        {
            return Ok(await _apps.RemoverPedidoById(id));
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
        public async Task<IActionResult> EstabelecimentoSalvar([FromBody] EstabelecimentoRequest estabelecimentoRequest)
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
        private readonly IProcessUser _appS;
        public UserController(IProcessUser processUser)
            => _appS = processUser;
        [HttpPost]
        public IActionResult Post([FromBody] UserRequest user)
        {
            return Ok(_appS.SalvarUsuario(user));
        }

        [HttpGet("nome/{name}")]
        public IActionResult GetByNome(string name)
        {
            var result = _appS.GetUserByName(name);
            if(result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            return Ok(await _appS.GetUserByEmail(email));
        }
    }
}
