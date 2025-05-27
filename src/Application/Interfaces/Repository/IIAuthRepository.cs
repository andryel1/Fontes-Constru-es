using Application.Dtos;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Application.Interfaces.Repository;

public interface IAuthService
{
    Task<bool> RegisterAsync(RegistroDto dto);
    Task<bool> LoginAsync(LoginDto dto);
}