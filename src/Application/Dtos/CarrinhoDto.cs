using Ecommerce.Domain.Entities;
using System.Collections.Generic;
using System;

namespace Application.Dtos;
public record CarrinhoDto(
    int Id,
    DateTime DataCriacao,
    List<ItemCarrinho> Itens,
    double PrecoTotal,
    int ClienteId,
    int PedidoId
); 