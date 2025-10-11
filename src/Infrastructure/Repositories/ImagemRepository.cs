using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;

namespace Infrastructure.Repositories;

public class ImagemRepository(Context context) : IImagemRepository
{
    private readonly Context _context = context;
    public async Task<ImagemDto> Adicionar(ImagemDto entity)
    {
        var image = new ImagemDto
        {
            Id = entity.Id,
            Produto = entity.Produto
        };
        _context.Add(image);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<ImagemDto> Atualizar(ImagemDto entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Deletar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ImagemDto> ObterImagemPorId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ImagemDto> ObterImagemPorIdProduto(Guid idProduto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ImagemDto>> ObterImagensPorIdProduto(Guid idProduto)
    {
        throw new NotImplementedException();
    }

    public Task<ImagemDto> ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ImagemDto>> ObterTodos()
    {
        throw new NotImplementedException();
    }
}