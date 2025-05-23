using Application.Interfaces.Service;
using Application.Dtos; 

namespace Application.Service;

public class CarrinhoService(ICarrinhoService carrinhoService) : ICarrinhoService
{
    private readonly ICarrinhoService _carrinhoService = carrinhoService;

    public Task<CarrinhoDto> ObterCarrinhoPorUsuarioId(int usuarioId)
    {
        return _carrinhoService.ObterCarrinhoPorUsuarioId(usuarioId);
    }

    public Task<bool> AdicionarProdutoAoCarrinho(int usuarioId, int produtoId, int quantidade)
    {
        return _carrinhoService.AdicionarProdutoAoCarrinho(usuarioId, produtoId, quantidade);
    }

    public Task<bool> LimparCarrinho(int usuarioId)
    {
        return _carrinhoService.LimparCarrinho(usuarioId);
    }

    public Task<bool> FinalizarCompra(int usuarioId, InformacoesEnvioDto informacoesEnvio)
    {
        return _carrinhoService.FinalizarCompra(usuarioId, informacoesEnvio);
    }

    public Task<CarrinhoDto> Adicionar(CarrinhoDto dto)
    {
        return _carrinhoService.Adicionar(dto);
    }

    public Task<CarrinhoDto> Atualizar(CarrinhoDto dto)
    {
        return _carrinhoService.Atualizar(dto);
    }

    public Task<bool> Deletar(int id)
    {
        return _carrinhoService.Deletar(id);
    }

    public Task<CarrinhoDto> ObterPorId(int id)
    {
        return _carrinhoService.ObterPorId(id);
    }

    public Task<List<CarrinhoDto>> ObterTodos()
    {
        return _carrinhoService.ObterTodos();
    }
}
