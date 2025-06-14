namespace Application.Dtos;
public record LoginDto(
    required string Email,
    required string Password
);