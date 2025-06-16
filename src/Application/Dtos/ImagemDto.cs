using System;

namespace Application.Dtos
{
    public record ImagemDto
    {
        public int Id { get; init; }
        public Uri? Url { get; init; }
        public int ProdutoId { get; init; }
        public ProdutoDto? Produto { get; init; }
    }
}
