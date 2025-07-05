using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using System.Security.Claims;

namespace Application.Interfaces.Service
{
    public interface IAuthService : IAuthRepository
    {
        Task<Usuario?> GetUserByEmailAsync(string email);
        ClaimsPrincipal CreateUserClaims(Usuario usuario);
    }
}