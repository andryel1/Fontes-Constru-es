using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.Service;
using Application.Dtos;

namespace MeuProjetoMVC.Controllers
{
    [Route("produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var produto = await _produtoService.ObterPorId(id);
            if (produto == null)
                return NotFound();
            
            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoDto produto)
        {
            if (produto == null)
                return BadRequest();
            
            var result = await _produtoService.Adicionar(produto);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProdutoDto produto)
        {
            if (produto == null)
                return BadRequest();
            
            var result = await _produtoService.Atualizar(produto);
            if (result == null)
                return NotFound();
            
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _produtoService.Deletar(id);
            if (!result)
                return NotFound();
            
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _produtoService.ObterTodos();
            return Ok(produtos);
        }
    }
}