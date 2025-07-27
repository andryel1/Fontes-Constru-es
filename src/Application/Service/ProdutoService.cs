using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service;

public class ProdutoService(IProdutoService produtoService) : IProdutoService
{
    private readonly IProdutoService _produtoService = produtoService;

    public async Task<ProdutoDto> VerificarProdutoExistente(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome do produto não existe");
        }
        
        return await _produtoService.VerificarProdutoExistente(nome);
    }

    public async Task<ProdutoDto> NomeNaoPodeSerVazioOuNUlo(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
        return await _produtoService.NomeNaoPodeSerVazioOuNUlo(nome);
    }

    public async Task<ProdutoDto> DescricaoNaoPodeSerVazioOuNulo(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao) || string.IsNullOrEmpty(descricao))
        {
            throw new ArgumentException("A descrição do produto não pode ser vazia ou nula.");
        }
        return await _produtoService.DescricaoNaoPodeSerVazioOuNulo(descricao);
    }

    public async Task<ProdutoDto> PrecoNaoPodeSerVazioOuNulo(decimal preco)
    {
        if (preco <= 0)
        {
            throw new ArgumentException("O preço do produto não pode ser menor ou igual a zero.");
        }
        return await _produtoService.PrecoNaoPodeSerVazioOuNulo(preco);
    }

    public Task<List<ProdutoDto>> ObterProdutosPorCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria) || string.IsNullOrEmpty(categoria))
        {
            throw new ArgumentException("A categoria do produto não pode ser vazia ou nula.");
        }
        return _produtoService.ObterProdutosPorCategoria(categoria);
    }

    public async Task<List<ProdutoDto>> ObterProdutosPorNome(string nome)
    {
        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome do produto não pode ser vazio ou nulo.");
        }
        return await _produtoService.ObterProdutosPorNome(nome);
    }
    public async Task<ProdutoDto> Adicionar(ProdutoDto dto)
    {
        await NomeNaoPodeSerVazioOuNUlo(dto.Nome);
        await VerificarProdutoExistente(dto.Nome);
        await DescricaoNaoPodeSerVazioOuNulo(dto.Descricao);
        await PrecoNaoPodeSerVazioOuNulo(dto.Preco);

        return await _produtoService.Adicionar(dto);
    }
    

    public async Task<ProdutoDto> Atualizar(ProdutoDto dto)
    {
        await VerificarProdutoExistente(dto.Nome);
        await NomeNaoPodeSerVazioOuNUlo(dto.Nome);

        return await _produtoService.Atualizar(dto);
    }

    public async Task<bool> Deletar(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O Id Não pode ser menor que 0.");
        }
        return await _produtoService.Deletar(id);
    }

    public async Task<ProdutoDto> ObterPorId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("O Id não pode ser menor que 0.");
        }
        return await _produtoService.ObterPorId(id);
    }

    public async Task<List<ProdutoDto>> ObterTodos()
    {
        return await _produtoService.ObterTodos();
    }
}