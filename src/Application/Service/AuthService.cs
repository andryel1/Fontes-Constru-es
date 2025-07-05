using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Interfaces.Service;
using Ecommerce.Domain.Entities;
using System.Security.Claims;

namespace Application.Service;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task<bool> LoginAsync(LoginDto dto)
    {
        return await _authRepository.LoginAsync(dto);
    }

    public async Task<bool> RegisterAsync(RegistroDto dto)
    {
        return await _authRepository.RegisterAsync(dto);
    }

    public async Task<Usuario?> GetUserByEmailAsync(string email)
    {
        return await _authRepository.GetUserByEmailAsync(email);
    }

    public ClaimsPrincipal CreateUserClaims(Usuario usuario)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
            new Claim(ClaimTypes.Name, usuario.UserName ?? ""),
            new Claim(ClaimTypes.Email, usuario.Email ?? ""),
            new Claim("UserId", usuario.Id.ToString())
        };

        // Adicionar role baseado no tipo de usuário
        if (usuario.Administrador != null)
        {
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
        }
        else if (usuario.Cliente != null)
        {
            claims.Add(new Claim(ClaimTypes.Role, "User"));
        }
        else
        {
            claims.Add(new Claim(ClaimTypes.Role, "User")); // Default role
        }

        var identity = new ClaimsIdentity(claims, "Cookies");
        return new ClaimsPrincipal(identity);
    }
} 