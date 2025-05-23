using Application.Dtos;
using Application.Interfaces.Services;

namespace Application.Service;

public class ProdutoService
{
    private readonly IProdutoService _produto;

    public ProdutoService(IProdutoService produto)
    {
        _produto = produto;
    }
}