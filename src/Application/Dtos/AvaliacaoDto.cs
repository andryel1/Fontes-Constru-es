using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record AvaliacaoDto(
    int Nota,
    required string Comentario,
    DateTime Data
);
