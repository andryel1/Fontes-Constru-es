using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record DescontoDto(
    required string Nome,
    required decimal Valor,
    DateTime DataInicio,
    DateTime DataFim,
    bool Ativo = true,
    required List<Produto> Produtos,
    int ProdutoId
);