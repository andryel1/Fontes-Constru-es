using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Interfaces.Service;
using Application.Dtos;
using Ecommerce.Domain.Entities;


namespace MeuProjetoMVC.Controllers
{
    [Route("Avaliação")]
    public class AvaliacaoController(IAvaliacaoService avaliacaoService, ILogger<AvaliacaoController> logger) : Controller
    {
        
        private readonly IAvaliacaoService __avaliacaoService = avaliacaoService;
        private readonly ILogger<AvaliacaoController> _logger = logger;

          [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            _logger.LogInformation("Obtendo avaliação{Id}", id);
            var avaliacao = await __avaliacaoService.ObterPorId(id);
            if (avaliacao == null)
            {
                _logger.LogWarning("Avaliação com ID {Id} não encontrado", id);
                return NotFound();
            }
            return Ok(avaliacao);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AvaliacaoDto avaliacao)
        {
            if(avaliacao == null)
            {
                _logger.LogInformation("Você não enviou nenhuma mensagem.");
                return BadRequest();
            }
            var result = await __avaliacaoService.Adicionar(avaliacao);
            _logger.LogInformation("Sua avaliação foi ralizada com sucesso");
            return CreatedAtAction(nameof(Get),new{id = result.Id}, result );

        }

        [HttpPut]
        
        public async Task<IActionResult> Put([FromBody] AvaliacaoDto avaliacao)
        {
            if(avaliacao == null)
            {
                _logger.LogError("Você não mudou nada");
                return BadRequest();
            }
        var result =  await __avaliacaoService.Atualizar(avaliacao);
            if( result == null)
            {
                _logger.LogError("Produto para atualização não encontrado.");
                return  NotFound();
            }
            return Ok(result);

        }
        [HttpDelete("id")]

        public async Task<IActionResult> Delete(int id)
        {
            var avaliacao = await __avaliacaoService.Deletar(id);
            if(!avaliacao)
            {
                _logger.LogInformation("Não existe nada para apagar!");
            }
            return NoContent();
        }
    }
}