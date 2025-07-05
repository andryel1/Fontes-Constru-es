using Application.Dtos;
using Ecommerce.Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IAuthRepository
{
    Task<bool> RegisterAsync(RegistroDto dto);
    Task<bool> LoginAsync(LoginDto dto);
    Task<Usuario?> GetUserByEmailAsync(string email);
}