using Application.Dtos;

namespace Application.Interfaces.Repository;

public interface IAuthRepository
{
    Task<bool> RegisterAsync(RegistroDto dto);
    Task<bool> LoginAsync(LoginDto dto);
}