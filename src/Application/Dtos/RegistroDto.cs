namespace Application.Dtos;

public record RegistroDto(
    string? Nome,
    string? Email,
    string? Password,
    string? ConfirmarPassword
);