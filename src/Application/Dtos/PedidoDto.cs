using Ecommerce.Domain.Entities;
using System.Collections.Generic;
using System;

namespace Application.Dtos;

public record PedidoDto(
    int Id,
    DateTime DataPedido,
    string? Status,
    double ValorTotal,
    ICollection<Carrinho> Itens,
    ICollection<Cliente> Clientes,
    DateTime? DataEnvio,
    DateTime? DataEntrega,
    ICollection<Pagamento> Pagamentos,
    ICollection<InformacoesEnvio> InformacoesEnvio
);