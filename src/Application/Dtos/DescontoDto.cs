using System;
using System.Collections.Generic;
using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record DescontoDto(
    int Id,
    string Nome,
    decimal Valor,
    DateTime DataInicio,
    DateTime DataFim,
    List<Produto> Produtos,
    int ProdutoId,
    bool Ativo;
);