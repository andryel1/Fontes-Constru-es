namespace Application.Dtos;

public record RegistroDto(
    int Id,
    string? Nome,
    string? Email,
    string? Password,
    string? ConfirmarPassword
);