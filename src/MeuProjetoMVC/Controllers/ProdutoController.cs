using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Application.Interfaces.Service;
using Application.Dtos;

namespace MeuProjetoMVC.Controllers
{
    [Route("produto")]
    public class ProdutoController(IProdutoService produtoService, ILogger<ProdutoController> logger) : Controller
    {
        private readonly IProdutoService _produtoService = produtoService;
        private readonly ILogger<ProdutoController> _logger = logger;

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            _logger.LogInformation("Obtendo produto com ID {Id}", id);
            var produto = await _produtoService.ObterPorId(id);
            if (produto == null)
            {
                _logger.LogWarning("Produto com ID {Id} não encontrado", id);
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoDto produto)
        {
            if (produto == null)
            {
                _logger.LogWarning("Tentativa de adicionar produto nulo");
                return BadRequest();
            }

            var result = await _produtoService.Adicionar(produto);
            _logger.LogInformation("Produto adicionado com ID {Id}", result.Id);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProdutoDto produto)
        {
            if (produto == null)
            {
                _logger.LogWarning("Tentativa de atualizar produto nulo");
                return BadRequest();
            }

            var result = await _produtoService.Atualizar(produto);
            if (result == null)
            {
                _logger.LogWarning("Produto para atualização não encontrado: ID {Id}", produto.Id);
                return NotFound();
            }

            _logger.LogInformation("Produto atualizado: ID {Id}", produto.Id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _produtoService.Deletar(id);
            if (!result)
            {
                _logger.LogWarning("Produto para exclusão não encontrado: ID {Id}", id);
                return NotFound();
            }

            _logger.LogInformation("Produto excluído: ID {Id}", id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Obtendo todos os produtos");
            var produtos = await _produtoService.ObterTodos();
            return Ok(produtos);
        }
    }
}