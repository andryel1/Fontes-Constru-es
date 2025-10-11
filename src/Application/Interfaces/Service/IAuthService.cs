using Application.Interfaces.Repository;
using Ecommerce.Domain.Entities;
using System.Security.Claims;

namespace Application.Interfaces.Service
{
    public interface IAuthService : IAuthRepository
    {
       ClaimsPrincipal CreateUserClaims(Usuario usuario);
    }
}