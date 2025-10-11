using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Import necessário para o Repositório
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service;

// CORRIGIDO: Injeta ICarrinhoRepository para evitar o ciclo de dependência.
public class CarrinhoService(ICarrinhoRepository carrinhoRepository) : ICarrinhoService
{
    private readonly ICarrinhoRepository _carrinhoRepository = carrinhoRepository;

    // Os métodos abaixo usam a dependência de Repositório (_carrinhoRepository)
    // para buscar/salvar dados.

    public Task<CarrinhoDto> ObterCarrinhoPorUsuarioId(int usuarioId)
    {
        throw new NotImplementedException("O método ObterCarrinhoPorUsuarioId deve ser implementado usando a dependência de Repositório.");
    }

    public Task<bool> AdicionarProdutoAoCarrinho(int usuarioId, int produtoId, int quantidade)
    {
        throw new NotImplementedException("O método AdicionarProdutoAoCarrinho deve ser implementado usando a dependência de Repositório.");
    }

    public Task<bool> LimparCarrinho(int usuarioId)
    {
        throw new NotImplementedException("O método LimparCarrinho deve ser implementado usando a dependência de Repositório.");
    }

    public Task<bool> FinalizarCompra(int usuarioId, InformacoesEnvioDto informacoesEnvio)
    {
        throw new NotImplementedException("O método FinalizarCompra deve ser implementado usando a dependência de Repositório.");
    }

    public Task<CarrinhoDto> Adicionar(CarrinhoDto dto)
    {
        throw new NotImplementedException("O método Adicionar deve ser implementado usando a dependência de Repositório.");
    }

    public Task<CarrinhoDto> Atualizar(CarrinhoDto dto)
    {
        throw new NotImplementedException("O método Atualizar deve ser implementado usando a dependência de Repositório.");
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException("O método Deletar deve ser implementado usando a dependência de Repositório.");
    }

    public Task<CarrinhoDto> ObterPorId(int id)
    {
        throw new NotImplementedException("O método ObterPorId deve ser implementado usando a dependência de Repositório.");
    }

    public Task<List<CarrinhoDto>> ObterTodos()
    {
        throw new NotImplementedException("O método ObterTodos deve ser implementado usando a dependência de Repositório.");
    }
}
