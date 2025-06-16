using Ecommerce.Domain.Entities;
using System.Collections.Generic;
using System;

namespace Application.Dtos;

public record ListaDesejoDto(
    DateTime DataAdicionada,
    List<Produto> Produtos,
    Cliente Clientes,
    int ClienteId
);