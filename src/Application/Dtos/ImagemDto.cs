namespace Application.Dtos;

public record ImagemDto(
    int Id,
    required Uri Url,
    int ProdutoId
);