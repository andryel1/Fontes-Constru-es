using System;
using Ecommerce.Domain.Entities;

namespace Application.Dtos;

public record AvaliacaoDto(
    int Id,
    int Nota,
    string Comentario,
    DateTime Data
);
