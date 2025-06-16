namespace Application.Dtos
{
    public record EnviarEmailDto(
        int Id,
        string? Nome,
        string? Assunto,
        string? Email,
        string? Mensagem
    );
}
