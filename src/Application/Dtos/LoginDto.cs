namespace Application.Dtos;
public record LoginDto(
    int Id,
    string Email,
    string Password
);