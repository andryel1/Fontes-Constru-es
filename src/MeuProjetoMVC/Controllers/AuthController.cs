using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Application.Dtos;
using Application.Interfaces.Service;
using Ecommerce.Domain.Entities;
using System.Security.Claims;

namespace MeuProjetoMVC.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        try
        {
            var isLoginValid = await _authService.LoginAsync(loginDto);
            
            if (!isLoginValid)
            {
                return Unauthorized(new { message = "Email ou senha inválidos" });
            }

            // Buscar o usuário para criar as claims
            var usuario = await _authService.GetUserByEmailAsync(loginDto.Email);
            if (usuario == null)
            {
                return Unauthorized(new { message = "Usuário não encontrado" });
            }

            // Criar claims do usuário
            var claimsPrincipal = _authService.CreateUserClaims(usuario);

            // Fazer login com cookies
            await HttpContext.SignInAsync("Cookies", claimsPrincipal, new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTimeOffset.UtcNow.AddHours(2) 
            });

            return Ok(new 
            { 
                message = "Login realizado com sucesso",
                user = new
                {
                    id = usuario.Id,
                    name = usuario.UserName,
                    email = usuario.Email,
                    role = usuario.Administrador != null ? "Admin" : "User"
                }
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno do servidor", error = ex.Message });
        }
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegistroDto registroDto)
    {
        try
        {
            var isRegistered = await _authService.RegisterAsync(registroDto);
            
            if (!isRegistered)
            {
                return BadRequest(new { message = "Erro ao registrar usuário. Verifique se o email já não está em uso e se as senhas coincidem." });
            }

            return Ok(new { message = "Usuário registrado com sucesso" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno do servidor", error = ex.Message });
        }
    }

    [HttpPost("logout")]
    [Authorize]
    public async Task<IActionResult> Logout()
    {
        try
        {
            await HttpContext.SignOutAsync("Cookies");
            return Ok(new { message = "Logout realizado com sucesso" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno do servidor", error = ex.Message });
        }
    }

    [HttpGet("profile")]
    [Authorize]
    public IActionResult GetProfile()
    {
        try
        {
            var userId = User.FindFirst("UserId")?.Value;
            var userName = User.FindFirst(ClaimTypes.Name)?.Value;
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
            var userRole = User.FindFirst(ClaimTypes.Role)?.Value;

            return Ok(new
            {
                id = userId,
                name = userName,
                email = userEmail,
                role = userRole
            });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "Erro interno do servidor", error = ex.Message });
        }
    }

    [HttpGet("check-auth")]
    public IActionResult CheckAuth()
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            return Ok(new
            {
                isAuthenticated = true,
                userName = User.FindFirst(ClaimTypes.Name)?.Value,
                userRole = User.FindFirst(ClaimTypes.Role)?.Value
            });
        }

        return Ok(new { isAuthenticated = false });
    }
} 