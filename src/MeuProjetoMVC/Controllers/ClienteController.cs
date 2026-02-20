using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Application.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace MeuProjetoMVC.Controllers
{
[Route("Cliente")]
public class ClienteController(IClienteService clienteService, ILogger<ClienteController> logger) : Controller
    {
        private readonly IClienteService _clienteService = clienteService;
        private readonly ILogger _logger = logger;

        [HttpGet("Id")]

        public async Task<IActionResult> Get( int id)
        {
            var Cliente = await _clienteService.ObterPorId(id);
            if(Cliente == null)
            {
                _logger.LogError("Não foi encontrado o Cliente no iD");
            }
            return Ok(Cliente);
            
        }
    }
}