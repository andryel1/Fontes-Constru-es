using Application.Dtos;
using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ProdutoRepository : IProdutoRepository
{
    private readonly Context _context;

    public ProdutoRepository(Context context)
    {
        _context = context;
    }

    public async Task<ProdutoDto> Adicionar(ProdutoDto dto)
    {
        var produto = new Produto
        {
            Nome = dto.Nome,
            Descricao = dto.Descricao,
            Estoque = dto.Estoque,
            Preco = dto.Preco,
            Categorias = dto.Categorias,
            Imagens = dto.Imagens,
            Avaliacoes = dto.Avaliacoes,
            ItensCarrinho = dto.ItensCarrinho,
            Pedidos = dto.Pedidos,
            ListaDesejos = dto.ListaDesejos,
            Tags = dto.Tags
        };
    
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
    
        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }

    public async Task<bool> Deletar(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null) return false;

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        var produto = await _context.Produtos.FindAsync(dto.Id);
        if (produto == null) return null!;

        produto.Nome = dto.Nome;
        produto.Descricao = dto.Descricao;
        produto.Estoque = dto.Estoque;
        produto.Preco = dto.Preco;
        produto.Categorias = dto.Categorias;
        produto.Imagens = dto.Imagens;
        produto.Avaliacoes = dto.Avaliacoes;
        produto.ItensCarrinho = dto.ItensCarrinho;
        produto.Pedidos = dto.Pedidos;
        produto.ListaDesejos = dto.ListaDesejos;
        produto.Tags = dto.Tags;

        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();

        return dto;
    }

    public async Task<ProdutoDto> ObterPorId(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null) return null!;

        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }

    public async Task<List<ProdutoDto>> ObterTodos()
    {
        var produtos = await _context.Produtos.ToListAsync();
        return produtos.Select(p => new ProdutoDto(
            p.Id,
            p.Nome ?? "",
            p.Descricao ?? "",
            p.Estoque ?? "",
            p.Preco,
            p.Imagens.ToList(),
            p.Avaliacoes.ToList(),
            p.ItensCarrinho.ToList(),
            p.Pedidos.ToList(),
            p.ListaDesejos.ToList(),
            p.Categorias.ToList(),
            p.Tags.ToList()
        )).ToList();
    }

    public async Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria)
    {
        var produtos = await _context.Produtos
            .Where(p => p.Categorias.Any(c => c.Nome == categoria))
            .ToListAsync();

        return produtos.Select(p => new ProdutoDto(
            p.Id,
            p.Nome ?? "",
            p.Descricao ?? "",
            p.Estoque ?? "",
            p.Preco,
            p.Imagens.ToList(),
            p.Avaliacoes.ToList(),
            p.ItensCarrinho.ToList(),
            p.Pedidos.ToList(),
            p.ListaDesejos.ToList(),
            p.Categorias.ToList(),
            p.Tags.ToList()
        )).ToList();
    }

    public async Task<List<ProdutoDto>> ObterProdutosPorNome(string nome)
    {
        var produtos = await _context.Produtos
            .Where(p => !string.IsNullOrEmpty(p.Nome) && p.Nome.Contains(nome))
            .ToListAsync();

        return produtos.Select(p => new ProdutoDto(
            p.Id,
            p.Nome ?? "",
            p.Descricao ?? "",
            p.Estoque ?? "",
            p.Preco,
            p.Imagens.ToList(),
            p.Avaliacoes.ToList(),
            p.ItensCarrinho.ToList(),
            p.Pedidos.ToList(),
            p.ListaDesejos.ToList(),
            p.Categorias.ToList(),
            p.Tags.ToList()
        )).ToList();
    }

    public async Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.Nome == nome);

        if (produto == null) return null!;

        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }

    public async Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
        
        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.Nome == nome);

        if (produto == null) return null!;

        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }

    public async Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrEmpty(descricao))
        {
            throw new ArgumentException("A descrição do produto não pode ser vazia ou nula.");
        }
        
        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.Descricao == descricao);

        if (produto == null) return null!;

        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }

    public async Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        if (preco <= 0)
        {
            throw new ArgumentException("O preço do produto não pode ser menor ou igual a zero.");
        }
        
        var produto = await _context.Produtos
            .FirstOrDefaultAsync(p => p.Preco == preco);

        if (produto == null) return null!;

        return new ProdutoDto(
            produto.Id,
            produto.Nome ?? "",
            produto.Descricao ?? "",
            produto.Estoque ?? "",
            produto.Preco,
            produto.Imagens.ToList(),
            produto.Avaliacoes.ToList(),
            produto.ItensCarrinho.ToList(),
            produto.Pedidos.ToList(),
            produto.ListaDesejos.ToList(),
            produto.Categorias.ToList(),
            produto.Tags.ToList()
        );
    }
}