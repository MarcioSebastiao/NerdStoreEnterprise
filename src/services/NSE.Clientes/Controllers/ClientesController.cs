using Microsoft.AspNetCore.Mvc;
using NSE.Clientes.Application.Commands;
using NSE.Clientes.Models;
using NSE.Core.Mediator;
using NSE.WebAPI.Core.Controllers;
using NSE.WebAPI.Core.Usuario;
using System.Threading.Tasks;

namespace NSE.Clientes.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IAspNetUser _user;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediatorHandler _mediator;

        public ClientesController(
            IAspNetUser user,
            IClienteRepository clienteRepository, 
            IMediatorHandler mediator
            )
        {
            _user = user;
            _clienteRepository = clienteRepository;
            _mediator = mediator;
        }

        [HttpGet("cliente/endereco")]
        public async Task<IActionResult> ObterEndereco()
        {
            var endereco = await _clienteRepository.ObterEnderecoPorClienteId(_user.ObterUserId());

            return endereco == null ? NotFound() : CustomResponse(endereco);
        }

        [HttpPost("cliente/endereco")]
        public async Task<IActionResult> AdicionarEndereco(AdicionarEnderecoCommand endereco)
        {
            endereco.ClienteId = _user.ObterUserId();
            return CustomResponse(await _mediator.EnviarComando(endereco));
        }
    }
}