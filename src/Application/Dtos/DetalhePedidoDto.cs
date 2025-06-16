namespace Application.Dtos;

public record DetalhePedidoDto(
        string? NomeProduto,
        int Quantidade,
        double Preco,
        double SubTotal,
        int PedidoId
);
